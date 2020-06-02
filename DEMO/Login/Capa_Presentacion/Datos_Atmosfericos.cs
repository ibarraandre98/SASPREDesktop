using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Capa_Presentacion
{
    public partial class Datos_Atmosfericos : Form
    {
        int Filtro_dia = 100;
        private string rutadirectorio;
        String thisDay = DateTime.Now.ToLongDateString().ToString();
        CN_DatosClimaMes _DatosClimaMes = new CN_DatosClimaMes();
        Menu _menu = new Menu();
        public Datos_Atmosfericos()
        {
            InitializeComponent();
        }

        private void Datos_Atmosfericos_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i < 31; i++)
                {
                    dias.Items.Add(i + " días");
                }
                dias.SelectedIndex = 6;

                rutadirectorio = "C:\\SASPRE_DATOS_ATMOSFERICOS\\datos_CIUDADMANTE_" + thisDay + ".csv";
                //crear carpeta
                //crear_carpeta();
                //Guardar informacion
                //getArchivo("https://smn.cna.gob.mx/tools/PHP/sivea/siveaEsri2/php/manejador_descargas_csv_estaciones.php?estacion=CIUDADMANTE&organismo=SMN&variable=temperatura%27&fbclid=IwAR3lT8srywft8Sy7OVAHDQ9_6ePUYm-am6ZzcN-zSsdCOVxGGMy0aa_guDQ");
                leercsv(rutadirectorio);
                if(dtgDatosElMante.Columns.Count != 0)
                {
                    dtgDatosElMante.Columns[1].Visible = false;
                    dtgDatosElMante.Columns[9].Visible = false;
                    dtgDatosElMante.Columns[10].Visible = false;
                }
                
                _DatosClimaMes.AgregarDiario(DateTime.Now.ToString("yy-MM-dd"));
               
                button1_Click_1(null, e);
                

            }
            catch (MySqlException ex)
            {

            }
            finally
            {

            }

        }
        //Metodo para descargar archivo de datos atmosfericos
        public async void getArchivo(String url)
        {
            try
            {
                WebClient wc = new WebClient();
                await Task.Run(() =>
                {
                    wc.DownloadFileAsync(new Uri(url), rutadirectorio);
                });
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error muski3" + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //metodo para crear carpeta donde se almacenara el documento descargado
        public void crear_carpeta()
        {
            try
            {
                string ruta = "C:\\SASPRE_DATOS_ATMOSFERICOS";
                if (!Directory.Exists(ruta))
                {
                    System.IO.Directory.CreateDirectory(ruta);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error muski4" + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //lectura del archivo con datos atmosfericos
        public void leercsv(String filepath)
        {
            int contadordias = 0;
            String cambiodia = null;
            bool salir = false;
            while (!salir == true)
            {
                salir = true;
                try
                {
                    DataTable dt = new DataTable();
                    String[] lines = System.IO.File.ReadAllLines(filepath);
                    if (lines.Length > Filtro_dia)
                    {
                        String firsline = "Fecha Local,Fecha UTC,Dirección del Viento (grados),Dirección de ráfaga (grados),Rapidez de viento (km/h),Rapidez de ráfaga (km/h),Temperatura del Aire (°C),Humedad relativa (%),Presión Atmosférica,Precipitación (mm),Radiación Solar (W/m²)";
                        String[] headerlabels = firsline.Split(',');
                        foreach (String headerword in headerlabels)
                        {
                            dt.Columns.Add(new DataColumn(headerword));
                        }
                        //for data
                        int columnindex = 0;
                        for (int r = 12; r < lines.Length; r++)
                        {
                            //separa el csv utilizando las comas
                            String[] dataword = lines[r].Split(','
                                );
                            DataRow dr = dt.NewRow();
                            String[] buscar = dataword[1].Split(':');

                            String aux = buscar[2].Replace("\"", "");



                            if (buscar[1].Equals("00") && aux.Equals("00"))
                            {
                                //llenar valores vacios
                                if (dataword[11].Equals(""))
                                {
                                    dataword[11] = "0";

                                }
                                //filtro de 7 dias 
                                String[] sietedias = dataword[1].Split('-');
                                String[] sietediasaux1 = sietedias[2].Split(' ');
                                if (!sietediasaux1[0].Equals(cambiodia))
                                {
                                    cambiodia = sietediasaux1[0];
                                    contadordias++;
                                }
                                if (contadordias <= Filtro_dia)
                                {
                                    foreach (String headerword in headerlabels)
                                    {

                                        dr[headerword] = dataword[columnindex];
                                        columnindex++;
                                    }
                                    dt.Rows.Add(dr);
                                    columnindex = 0;
                                }

                            }
                            //

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido descargar el archivo, cargue de nuevo el sistema");
                    }
                    if (dt.Rows.Count > 0)
                    {
                        dtgDatosElMante.DataSource = dt;
                    }
                }
                catch (System.IO.IOException e)
                {
                    salir = false;
                }
            }
            InsertarDatosClimaMes();
        }

        private void filtrar_Click(object sender, EventArgs e)
        {

        }
        public int intervalos(String anterior)
        {
            DateTime fecha_actual = DateTime.Now;
            DateTime fecha_anterior; //= Convert.ToDateTime(anterior);
            
            if(anterior == "")
            {
                fecha_anterior = DateTime.Now.AddDays(-1);
            }
            else
            {
                fecha_anterior = Convert.ToDateTime(anterior);
            }

            TimeSpan tSpan = fecha_actual - fecha_anterior;
            String[] dias = tSpan.ToString().Split('.');
            int intervalo = 0;

            try
            {
                intervalo = Convert.ToInt32(dias[0]);
            }
            catch (Exception e)
            {
                intervalo = 0;
            }

            return intervalo;
        }

        public String acomodarfecha(String fecha)
        {   //2019/10/08
            String[] separar = fecha.Split('/');
            return separar[2] + "/" + separar[1] + "/" + separar[0];
        }
        private void InsertarDatosClimaMes()
        {
            String fecha="";
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                CN_DatosClimaMes _DatosClimaMes = new CN_DatosClimaMes();
                String[] aux1 = _DatosClimaMes.top_fecha().Split(' ');
                int parametro = intervalos(aux1[0]);

                foreach (DataGridViewRow item in dtgDatosElMante.Rows)
                {
                    String aux = item.Cells["Fecha Local"].Value.ToString().Replace(@"""", "");
                    aux = aux.Replace("-", "/");
                    aux = aux.Replace("\"", "");
                    String[] aux2 = aux.Split(' ');
                    int intervalo2 = intervalos(acomodarfecha(aux2[0]));
                    
                    if (parametro > intervalo2 && intervalo2 != 0 )
                    {
                        fecha = item.Cells["Fecha Local"].Value.ToString().Replace(@"""", "");
                        String fechautc = item.Cells["Fecha UTC"].Value.ToString().Replace(@"""", "");
                        _DatosClimaMes.InsertarDatosClimaMes("CIUDADMANTE",fecha, item.Cells["Dirección del Viento (grados)"].Value.ToString(), item.Cells["Dirección de ráfaga (grados)"].Value.ToString(),
                        item.Cells["Rapidez de viento (km/h)"].Value.ToString(), item.Cells["Rapidez de ráfaga (km/h)"].Value.ToString(), item.Cells["Temperatura del Aire (°C)"].Value.ToString(), item.Cells["Humedad relativa (%)"].Value.ToString(),
                        item.Cells["Presión Atmosférica"].Value.ToString(), item.Cells["Precipitación (mm)"].Value.ToString(), item.Cells["Radiación Solar (W/m²)"].Value.ToString());
                    }
                    

                    //Funcionara unicamente cuando la base de datos no tenga ningun dato admosfericos
                    /*
                    if (parametro >= intervalo2) //&& intervalo2 != 0 )
                    {
                        fecha = item.Cells["Fecha Local"].Value.ToString().Replace(@"""", "");
                        String fechautc = item.Cells["Fecha UTC"].Value.ToString().Replace(@"""", "");
                        _DatosClimaMes.InsertarDatosClimaMes(item.Cells["Estación"].Value.ToString(), fecha, item.Cells["Dirección del Viento (grados)"].Value.ToString(), item.Cells["Dirección de ráfaga (grados)"].Value.ToString(),
                        item.Cells["Rapidez de viento (km/h)"].Value.ToString(), item.Cells["Rapidez de ráfaga (km/h)"].Value.ToString(), item.Cells["Temperatura del Aire (°C)"].Value.ToString(), item.Cells["Humedad relativa (%)"].Value.ToString(),
                        item.Cells["Presión Atmosférica"].Value.ToString(), item.Cells["Precipitación (mm)"].Value.ToString(), item.Cells["Radiación Solar (W/m²)"].Value.ToString());
                    }
                    */

                    //De aqui para abajo mantener comentarios
                    /* if (Convert.ToDateTime(item.Cells["Fecha Local"].Value.ToString().Replace(@"""", "")).ToString("yy-MM-dd") == DateTime.Now.AddDays(-1).ToString("yy-MM-dd"))
                     {


                       /*  String fechautc = item.Cells["Fecha UTC"].Value.ToString().Replace(@"""", "");
                         _DatosClimaMes.InsertarDatosClimaMes(item.Cells["Estación"].Value.ToString(), fecha, fechautc, item.Cells["Dirección del Viento (grados)"].Value.ToString(), item.Cells["Dirección de ráfaga (grados)"].Value.ToString(),
                         item.Cells["Rapidez de viento (km/h)"].Value.ToString(), item.Cells["Rapidez de ráfaga (km/h)"].Value.ToString(), item.Cells["Temperatura del Aire (°C)"].Value.ToString(), item.Cells["Humedad relativa (%)"].Value.ToString(),
                         item.Cells["Presión Atmosférica"].Value.ToString(), item.Cells["Precipitación (mm)"].Value.ToString(), item.Cells["Radiación Solar (W/m²)"].Value.ToString());
                     }*/

                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error muski1" + a, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cursor.Current = Cursors.Default;
            }
        }
        private void MostrarAlarmaClima()
        {
            int contadorAlarma = 0;
            int contadorDias = 0;
            int contadorHoras = 0;
            String fecha1 = "", fecha2 = "", fecha3 = "";
            String fechaMin1 = "", fechaMin2 = "", fechaMin3 = "";
            double temperatura;
            double temperaturaMaxima = 24;
            double temperaturaMin = 5;
            double temperatura1 = 0, temperatura2 = 0, temperatura3 = 0;
            double temperaturaMin1 = 0, temperaturaMin2 = 0, temperaturaMin3 = 0;
            DataTable tablaDatosClima = new DataTable();
            tablaDatosClima = _DatosClimaMes.MostrarAlarmaClima();


            for (int i = 0; i < 72; i++)
            {
                contadorHoras++;
                temperatura = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);

                if (i < 24 && contadorDias == 0)
                {
                    if (temperatura >= temperaturaMaxima)
                    {
                        fecha1 = tablaDatosClima.Rows[i]["Fecha_Local"].ToString();
                        temperatura1 = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);
                        contadorDias++;
                    }
                }
                else
                {
                    if (i >= 24 && contadorHoras < 48 && contadorDias == 1)
                    {
                        if (temperatura >= temperaturaMaxima)
                        {
                            fecha2 = tablaDatosClima.Rows[i]["Fecha_Local"].ToString();
                            temperatura2 = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);
                            contadorDias++;
                        }
                    }
                    else
                    {

                        if (i > 48 && contadorDias == 2)
                        {
                            if (temperatura >= temperaturaMaxima)
                            {
                                fecha3 = tablaDatosClima.Rows[i]["Fecha_Local"].ToString();
                                temperatura3 = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);
                                alert.Show("Se ha registrado que en 3 dias seguidos" + "\n la temperatura a revasado el limite estable para " + "\nlos cultivos: " + temperaturaMaxima + " C", Alertype.warning);
                                alert.Show("Fecha 1: " + fecha1 + " " + temperatura1 + "\nFecha 2: " + fecha2 + " " + temperatura2 + "\nFecha 3: " + fecha3 + " " + temperatura3, Alertype.warning);
                                //MessageBox.Show("Se ha registrado que en 3 dias seguidos" + "\n la temperatura a revasado el limite estable para " + "\nlos cultivos: " + temperaturaMaxima + " C");
                                //MessageBox.Show("\nFecha 1: " + fecha1 + " " + temperatura1 + "\nFecha 2: " + fecha2 + " " + temperatura2 + "\nFecha 3: " + fecha3 + " " + temperatura3);
                                contadorDias++;
                                i = 72;
                            }
                        }
                    }
                }
            }

            contadorDias = 0;
            for (int i = 0; i < 72; i++)
            {
                contadorHoras++;
                temperatura = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);

                if (i < 24 && contadorDias == 0)
                {
                    if (temperatura <= temperaturaMin)
                    {
                        fechaMin1 = tablaDatosClima.Rows[i]["Fecha_Local"].ToString();
                        temperaturaMin1 = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);
                        contadorDias++;
                    }
                }
                else
                {
                    if (i >= 24 && contadorHoras < 48 && contadorDias == 1)
                    {
                        if (temperatura <= temperaturaMin)
                        {
                            fechaMin2 = tablaDatosClima.Rows[i]["Fecha_Local"].ToString();
                            temperaturaMin2 = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);
                            contadorDias++;
                        }
                    }
                    else
                    {

                        if (i > 48 && contadorDias == 2)
                        {
                            if (temperatura <= temperaturaMin)
                            {
                                fechaMin3 = tablaDatosClima.Rows[i]["Fecha_Local"].ToString();
                                temperaturaMin3 = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);
                                alert.Show("Se ha registrado que en 3 dias seguidos" + "\n la temperatura a bajado del limite estable para " + "\nlos cultivos: " + temperaturaMin + " C", Alertype.warning);
                                alert.Show("Fecha 1: " + fechaMin1 + " " + temperaturaMin1 + "\nFecha 2: " + fechaMin2 + " " + temperaturaMin2 + "\nFecha 3: " + fechaMin3 + " " + temperaturaMin3, Alertype.warning);
                                //MessageBox.Show("Se ha registrado que en 3 dias seguidos" + "\n la temperatura a revasado el limite estable para " + "\nlos cultivos: " + temperaturaMaxima + " C");
                                //MessageBox.Show("\nFecha 1: " + fecha1 + " " + temperatura1 + "\nFecha 2: " + fecha2 + " " + temperatura2 + "\nFecha 3: " + fecha3 + " " + temperatura3);
                                contadorDias++;
                                i = 72;
                            }
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarDatosClimaMes();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                Filtro_dia = Convert.ToInt32(dias.Text.Substring(0, 2));
                while (dtgDatosElMante.RowCount > 1)
                {
                    dtgDatosElMante.Rows.Remove(dtgDatosElMante.CurrentRow);

                }
                leercsv(rutadirectorio);
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error muski2" + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void MOstrardatosatmosfericos(){
            leercsv(rutadirectorio);
        }
        public void Mostrardatosatmosfericos(){
            rutadirectorio = "C:\\SASPRE_DATOS_ATMOSFERICOS\\datos_CIUDADMANTE_" + thisDay + ".csv";
            leercsv(rutadirectorio);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertarDatosClimaMes();
            //MostrarAlarmaClima(); Arreglar
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //_menu.bunifuFlatButton4_Click(null, e);
            //Fecha local,Temperatura, Humedad relativa, presion atmosferica, precipitacion
            dsAtmosfericos Ds = new dsAtmosfericos();
            int filas = dtgDatosElMante.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] { dtgDatosElMante[0,i].Value.ToString(),
                    dtgDatosElMante[1,i].Value.ToString(),
                    dtgDatosElMante[2,i].Value.ToString(),
                    dtgDatosElMante[3,i].Value.ToString(),
                    dtgDatosElMante[4,i].Value.ToString(),
                    dtgDatosElMante[5,i].Value.ToString(),
                    dtgDatosElMante[6,i].Value.ToString(),
                    dtgDatosElMante[7,i].Value.ToString(),
                    dtgDatosElMante[8,i].Value.ToString()});
                /* Ds.Tables[0].Rows.Add(new object[] { dtgDatosElMante[0,i].Value.ToString(),
                    dtgDatosElMante[5,i].Value.ToString(),
                    dtgDatosElMante[7,i].Value.ToString(),
                    dtgDatosElMante[8,i].Value.ToString(),
                    dtgDatosElMante[9,i].Value.ToString()});*/
            }
            Reportes r = new Reportes();
            r.setData(Ds);
            r.setReporte(6);
            DialogResult resultado = new DialogResult();
            resultado = r.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea cerrar el programa?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void BtnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
          
        }

        int posX = 0;
        int posY = 0;
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {

        }
    }
}