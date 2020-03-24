using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Gráficos : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        CN_Gráficos g = new CN_Gráficos();
        GMapOverlay Poligono = new GMapOverlay("Poligono");
        GMapPolygon poligonoPuntos;
        /*
         * Tabla de base de datos para los puntos guardados en el DGV, sé que le falta normalizar (Anael) 
         * 
           CREATE TABLE `saspre`.`graficos` (
          `idGraficos` INT NOT NULL AUTO_INCREMENT,
          `Identificador` BIGINT NOT NULL DEFAULT 0,
          `Latitud` VARCHAR(50) NOT NULL,
          `Longitud` VARCHAR(50) NOT NULL,
          `Color` VARCHAR(45) NOT NULL,
          `NombreDelTerreno` VARCHAR(100) NOT NULL,
          `Usuario` VARCHAR(100) NOT NULL,
          `Cultivo` VARCHAR(100) NOT NULL,
          `FechaPlantado` VARCHAR(100) NOT NULL,
          `FechaCosecha` VARCHAR(100) NOT NULL,
          `Cantidad` DOUBLE NOT NULL,
          `Estado` VARCHAR(255) NULL,
          PRIMARY KEY (`idGraficos`)); 
        */



        int filaSeleccionada = 0;
        double LatInicial = 22.7031103;
        double LongInicial = -99.0117213;

        public Gráficos()
        {
            InitializeComponent();
            gMapControl1.Controls.Add(btnMenu);
            btnMenu.Location = new Point(gMapControl1.Width - 50,  4);
            btnMenu.BackColor = Color.Transparent;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ///Se obtiene los datos de lat y lng del mapa donde el usuario presiono
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;


            //Se posicionan en el txt de la latitud y longitud

            txtLati.Text = lat.ToString();
            txtLong.Text = lng.ToString();

            //Creamos el marcador para moverlo al lugar índicado

            marker.Position = new PointLatLng(lat, lng);
            //Tambien agregamos el mensaje al marcador (tooltip)

            //marker.ToolTipText = string.Format("Doble click para iniciar un punto");
        }

        private void Gráficos_Load(object sender, EventArgs e)
        {

            txtcultivo.SelectedIndex = 0;
            panel1.Width = 0;
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Punto", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //Insertando datos al dt para mostrar en la lista
            //dt.Rows.Add("Ubicación 1", LatInicial, LongInicial);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;

            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.CacheLocation = @"cache";
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl1.MinZoom = 10;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;


            //Marcador

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.white_small);
            markerOverlay.Markers.Add(marker); //Agregamos al mapa

            //Agregamos un tooltip de texto a los marcadores

            marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud{1}", LatInicial, LongInicial);

            //Ahora agregamos el mapa y el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
            CargarPoligonos();

            txtid.Text = Convert.ToString(g.UltimoID());
            txtid.Text = Convert.ToString(Convert.ToInt32(txtid.Text)+1);
        }


        int contador = 0;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtLati.Text.Length > 0 && txtLati.Text.Length > 0)
            {
                dt.Rows.Add(contador, txtLati.Text, txtLong.Text); //agregar
                contador++;
            }
            else
            {
                MessageBox.Show("Agregué puntos");
            }

            //Procedimientos para ingresar a una base de datos
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaSeleccionada); //remover de la tabla
            //Procedimientos para borrar a una base de datos
        }


        

        private void CargarPoligonos()
        {

            datos.DataSource = g.MostrarGraficos("Admin","Admin");
            string[] colores = new string[999];
            char[] delimitador = {'=',',',']'};

            if (datos.Rows.Count > 2)
            {
                GMapOverlay Poligono = new GMapOverlay("Poligono");
                List<PointLatLng> puntos = new List<PointLatLng>();
                puntos.Clear();
                Poligono.Clear();

                //variables para almacenar los datos
                double lng = 0, lat = 0;
                int temp = 0;
                bool ultimopunto = false;
                //agarramos los datos del grid
                String identificadortemp = "",  nombredelterrenotemp = "", usuariotemp = "", cultivotemp = "", fechaplantadotemp = "", fechacosechatemp = "", cantidadtemp = "", estadotemp = "";

                for (int filas = 0; filas < datos.Rows.Count; filas++)
                {

                    if (filas == 0)
                    {
                        temp = Convert.ToInt32(datos.Rows[filas].Cells[1].Value);
                        lat = Convert.ToDouble(datos.Rows[filas].Cells[2].Value);
                        lng = Convert.ToDouble(datos.Rows[filas].Cells[3].Value);
                        puntos.Add(new PointLatLng(lat, lng));
                    }

                    if (filas > 0)
                    {
                        if (temp == Convert.ToDouble(datos.Rows[filas].Cells[1].Value) || ultimopunto)
                        {
                            identificadortemp = datos.Rows[filas].Cells[1].Value.ToString();
                            colores = datos.Rows[filas].Cells[4].Value.ToString().Split(delimitador);
                            nombredelterrenotemp = datos.Rows[filas].Cells[5].Value.ToString();
                            usuariotemp = datos.Rows[filas].Cells[6].Value.ToString();
                            cultivotemp = datos.Rows[filas].Cells[7].Value.ToString();
                            fechaplantadotemp = datos.Rows[filas].Cells[8].Value.ToString();
                            fechacosechatemp = datos.Rows[filas].Cells[9].Value.ToString();
                            cantidadtemp = datos.Rows[filas].Cells[10].Value.ToString();
                            estadotemp = datos.Rows[filas].Cells[11].Value.ToString();
                            lat = Convert.ToDouble(datos.Rows[filas].Cells[2].Value);
                            lng = Convert.ToDouble(datos.Rows[filas].Cells[3].Value);
                            puntos.Add(new PointLatLng(lat, lng));
                            ultimopunto = false;
                        }
                        else
                        {
                            poligonoPuntos = new GMapPolygon(puntos, "Poligono");
                            poligonoPuntos.Fill = new SolidBrush(Color.FromArgb(Convert.ToInt32(colores[1]), Convert.ToInt32(colores[3]), Convert.ToInt32(colores[5]), Convert.ToInt32(colores[7])));
                            poligonoPuntos.Stroke = new Pen(Color.FromArgb(Convert.ToInt32(colores[1]), Convert.ToInt32(colores[3]), Convert.ToInt32(colores[5]), Convert.ToInt32(colores[7])), 1);
                            poligonoPuntos.IsHitTestVisible = true;

                            Poligono.Polygons.Add(poligonoPuntos);
                            gMapControl1.Overlays.Add(Poligono);
                            Poligono.Markers.Add(new GMarkerCross(new PointLatLng(lat, lng)) { ToolTipText = "\nIdentificador #:" + identificadortemp + "\n" + "\nAgregado por:" + usuariotemp + "\nTipo de cultivo:" + cultivotemp + "\nFecha plantado:" + fechaplantadotemp + "\nFecha cosecha:" + fechacosechatemp + "\nCantidad:" + cantidadtemp /*"\nÁrea(m²):" + calcularArea(puntos) +*/ + "\nEstado:" + estadotemp, IsVisible = true, ToolTipMode = MarkerTooltipMode.Always });

                            #region actualizaciónDelMapa
                            gMapControl1.Zoom = gMapControl1.Zoom + 1;
                            gMapControl1.Zoom = gMapControl1.Zoom - 1;
                            puntos.Clear();
                            lat = Convert.ToDouble(datos.Rows[filas].Cells[2].Value);
                            lng = Convert.ToDouble(datos.Rows[filas].Cells[3].Value);
                            puntos.Add(new PointLatLng(lat, lng));
                            ultimopunto = true;
                            #endregion
                        }

                        if (filas == datos.Rows.Count - 1)
                        {
                            identificadortemp = datos.Rows[filas].Cells[1].Value.ToString();
                            colores = datos.Rows[filas].Cells[4].Value.ToString().Split(delimitador);
                            nombredelterrenotemp = datos.Rows[filas].Cells[5].Value.ToString();
                            usuariotemp = datos.Rows[filas].Cells[6].Value.ToString();
                            cultivotemp = datos.Rows[filas].Cells[7].Value.ToString();
                            fechaplantadotemp = datos.Rows[filas].Cells[8].Value.ToString();
                            fechacosechatemp = datos.Rows[filas].Cells[9].Value.ToString();
                            cantidadtemp = datos.Rows[filas].Cells[10].Value.ToString();
                            estadotemp = datos.Rows[filas].Cells[11].Value.ToString();
                            poligonoPuntos = new GMapPolygon(puntos, "Poligono");
                            poligonoPuntos.Fill = new SolidBrush(Color.FromArgb(Convert.ToInt32(colores[1]), Convert.ToInt32(colores[3]), Convert.ToInt32(colores[5]), Convert.ToInt32(colores[7])));
                            poligonoPuntos.Stroke = new Pen(Color.FromArgb(Convert.ToInt32(colores[1]), Convert.ToInt32(colores[3]), Convert.ToInt32(colores[5]), Convert.ToInt32(colores[7])), 1);
                            poligonoPuntos.IsHitTestVisible = true;

                            Poligono.Polygons.Add(poligonoPuntos);
                            gMapControl1.Overlays.Add(Poligono);

                            Poligono.Markers.Add(new GMarkerCross(new PointLatLng(lat, lng)) { ToolTipText = "\nIdentificador #:" + identificadortemp + "\n" + "\nAgregado por:" + usuariotemp + "\nTipo de cultivo:" + cultivotemp + "\nFecha plantado:" + fechaplantadotemp + "\nFecha cosecha:" + fechacosechatemp + "\nCantidad:" + cantidadtemp /*"\nÁrea(m²):" + calcularArea(puntos) +*/+ "\nEstado:" + estadotemp, IsVisible = true, ToolTipMode = MarkerTooltipMode.Always });

                           
                            gMapControl1.Zoom = gMapControl1.Zoom + 1;
                            gMapControl1.Zoom = gMapControl1.Zoom - 1;
                            puntos.Clear();
                        }

                    }

                    temp = Convert.ToInt32(datos.Rows[filas].Cells[1].Value);
                }
            }

        }


        private string calcularArea(List<PointLatLng> pt)
        {
            IList<PointLatLng> coords = pt;

            IList < PointLatLng > points = new List<PointLatLng>();
            foreach (PointLatLng coord in coords)
            {
                PointLatLng p = new PointLatLng(
                  coord.Lng * (System.Math.PI * 6378137 / 180),
                  coord.Lat * (System.Math.PI * 6378137 / 180)
                );
                points.Add(p);
            }

            points.Add(points[0]);

            var area = System.Math.Abs(points.Take(points.Count - 1)
              .Select((p, i) => (points[i + 1].Lat - p.Lat) * (points[i + 1].Lng + p.Lng))
              .Sum() / 2);

            return string.Format("{0:n2}", (Math.Truncate(area * 100) / 100));
        }



        List<int> poligonosExistentes = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            btnAgregarPoligono.Visible = false;
            btnBorrarPoligono.Visible = false;



            
            if(cbPoligonos.Items.Count > 0 )
            {
                cbPoligonos.Items.Clear();

            }
            cbPoligonos.DataSource = g.ObtenerPoligonosExistentes();
            cbPoligonos.DisplayMember = "valor";
            cbPoligonos.ValueMember = "valor";

           
            pnlBorrarPoligono.Visible = true;


        }




        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex; //Seleciona la fila
            //Recuperamos los datos del grid y los asignamos a los textbox

            txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtLati.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtLong.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

            //Se asignan los valores del grid al marcador
            marker.Position = new PointLatLng(Convert.ToDouble(txtLati.Text), Convert.ToDouble(txtLong.Text));
            //Se posiciona el foco en el punto
            gMapControl1.Position = marker.Position;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLati_TextChanged(object sender, EventArgs e)
        {

        }


        Color colorActual = Color.FromArgb(50,255,0,0);
        private void button2_Click(object sender, EventArgs e)
        {
            if (Colores.ShowDialog() == DialogResult.OK)
            {
                colorActual = Colores.Color;
                colorActual = Color.FromArgb(50, colorActual);
                //button2.BackColor = colorActual;
            }
        }

        private void btnAgregarPoligono_Click(object sender, EventArgs e)
        {
            pnlAgregarPoligono.Visible = true;
            btnAgregarPoligono.Visible = false;
            btnBorrarPoligono.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = (DataTable) dataGridView1.DataSource;
            
            if (dataGridView1.Rows.Count > 0)
            {
                contador = 0;
                dt.Clear();
            }

            pnlAgregarPoligono.Visible = false;
            pnlDetallesAgregar.Visible = false;
            btnAgregarPoligono.Visible = true;
            btnBorrarPoligono.Visible = true;
        }

        private void btnDetallesAgregar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count >= 3)
            {
                pnlDetallesAgregar.Visible = true;
                pnlAgregarPoligono.Visible = false;
            }
            else
            {
                MessageBox.Show("Debe agregar al menos 3 puntos");
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            pnlDetallesAgregar.Visible = false;
            pnlAgregarPoligono.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlBorrarPoligono.Visible = false;
            btnAgregarPoligono.Visible = true;
            btnBorrarPoligono.Visible = true;
        }

        Menu menu = new Menu();
        private void button4_Click(object sender, EventArgs e)
        {
            g.BorrarGraficos(cbPoligonos.SelectedValue.ToString());
            //Actualizar el mapa


            reiniciarMapa();

            MessageBox.Show("Se ha eliminado el polígono #"+ cbPoligonos.SelectedValue.ToString()+" correctamente");


            cbPoligonos.DataSource = g.ObtenerPoligonosExistentes();
            cbPoligonos.DisplayMember = "valor";
            cbPoligonos.ValueMember = "valor";


            pnlBorrarPoligono.Visible = false;
            pnlDetallesAgregar.Visible = false;
            pnlAgregarPoligono.Visible = false;
            btnAgregarPoligono.Visible = true;
            btnBorrarPoligono.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("alav");

            if (panel1.Width == 0 )
            {
                panel1.Width = 302;
            }
            else
            {
                panel1.Width = 0;
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void reiniciarMapa()
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.CacheLocation = @"cache";
            gMapControl1.ShowCenter = false;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleHybridMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl1.MinZoom = 10;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;
           

            //Marcador

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.white_small);
            markerOverlay.Markers.Add(marker); //Agregamos al mapa

            //Agregamos un tooltip de texto a los marcadores

            marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud{1}", LatInicial, LongInicial);

            //Ahora agregamos el mapa y el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
            CargarPoligonos();
        }

        private void BtnAgregarTerreno_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtnombreterreno.Text) || String.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                MessageBox.Show("Por favor llene por completo todos los campos");
            }
            else
            {
                //Ahora agregamos el mapa y el marcador al map control
                //gMapControl1.Overlays.Add(markerOverlay); //Descomentar esto si quieres tener posiciones
                GMapOverlay Poligono = new GMapOverlay("Poligono");
                List<PointLatLng> puntos = new List<PointLatLng>();

                //variables para almacenar los datos

                double lng = 0, lat = 0;


                //agarramos los datos del grid

                for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
                {

                    lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                    lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                    puntos.Add(new PointLatLng(lat, lng));

                    g.AgregarGraficos(txtid.Text, Convert.ToString(lat), Convert.ToString(lng), colorActual.ToString(), txtnombreterreno.Text, txtusuario.Text, txtcultivo.Text, txtfechaplantado.Text, txtfechacosecha.Text, txtcantidad.Text, null);

                }


                GMapPolygon poligonoPuntos = new GMapPolygon(puntos, "Poligono");
                poligonoPuntos.Fill = new SolidBrush(colorActual);
                poligonoPuntos.Stroke = new Pen(colorActual, 1);
                poligonoPuntos.IsHitTestVisible = true;

                Poligono.Polygons.Add(poligonoPuntos);
                gMapControl1.Overlays.Add(Poligono);
                Poligono.Markers.Add(new GMarkerCross(new PointLatLng(lat, lng)) { ToolTipText = "\nIdentificador #:" + txtid.Text + "\n" + txtnombreterreno.Text + "\nAgregado por:" + txtusuario.Text + "\nTipo de cultivo:" + txtcultivo.Text + "\nFecha plantado:" + txtfechaplantado.Text + "\nFecha cosecha:" + txtfechacosecha.Text + "\nCantidad:" + txtcantidad.Text + /*"\nÁrea(m²):" + calcularArea(puntos) +*/ "\nEstado:", IsVisible = true, ToolTipMode = MarkerTooltipMode.Always });

                //Actualizar el mapa
                gMapControl1.Zoom = gMapControl1.Zoom + 1;
                gMapControl1.Zoom = gMapControl1.Zoom - 1;

                MessageBox.Show("Se ha guardado correctamente");
                txtid.Text = Convert.ToString(Convert.ToInt32(txtid.Text) + 1);
                txtnombreterreno.Clear();
                txtcantidad.Clear();
                DataTable dt = (DataTable)dataGridView1.DataSource;

                if (dataGridView1.Rows.Count > 0)
                {
                    contador = 0;
                    dt.Clear();
                }

                pnlAgregarPoligono.Visible = false;
                pnlDetallesAgregar.Visible = false;
                pnlBorrarPoligono.Visible = false;
                btnAgregarPoligono.Visible = true;
                btnBorrarPoligono.Visible = true;
            }


            
        }
    }


}
