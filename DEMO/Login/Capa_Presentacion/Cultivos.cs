using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion;
using Capa_Negocio;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace Capa_Presentacion
{
    public partial class Cultivos : Form
    {
        private CN_Cultivos _Cultivo = new CN_Cultivos();
        private CN_Cosechas _Cosechas = new CN_Cosechas();
        private CN_Plagas _Plagas = new CN_Plagas();
        private CN_Almacen _CN_Almacen = new CN_Almacen();
        DataTable tablaCultivos;
        int disponibleCultivo = 0;
        MySqlDataReader lectorDisp;
        String disp;

        public Cultivos()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            try
            {
                Form formulario;
                //formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault();

                //si el formulario/instancia no existe, creamos nueva instancia y mostramos
                /*
                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                   // panelContenedor.Controls.Add(formulario);
                    //panelContenedor.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                    formulario.Opacity = .5;
                    //  formulario.FormClosed += new FormClosedEventHandler(CloseForms);
                }
                else
                {

                    //si la Formulario/instancia existe, lo traemos a frente
                    formulario.BringToFront();

                    //Si la instancia esta minimizada mostramos
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }

                }
                */
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error muski1" + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CerrarFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            //formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault();

            if (!(formulario == null))
            {

                formulario.Close();
            }

        }
        public void limpiar()
        {
            txtCantidad.Clear();
            dtpPlantado.Value = DateTime.Now;
            dtpCosecha.Value = DateTime.Now;
            cbPlanta.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                if (Convert.ToInt32(txtCantidad.Text) != 0)
                {
                    AgregarCultivo();
                    MostrarCultivos();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("¡Debe ingresar una cantidad mayor a 0!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("¡Debe ingresar una cantidad!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void AgregarCultivo()
        {
            if (Convert.ToInt32(txtCantidad.Text) == 0)
            {
                MessageBox.Show("¡No puede ingresar esta cantidad!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _Cultivo.AgregarCultivo(Program.nickname, cbPlanta.SelectedItem.ToString(), dtpPlantado.Value.ToString("yy-MM-dd"), dtpCosecha.Value.ToString("yy-MM-dd"), txtCantidad.Text, "Sin estado");
                MessageBox.Show("¡Cultivo agregado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvCultivo.Rows.Count == 0)
            {
                MessageBox.Show("¡No hay ningun cultivo agregado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var op = DialogResult.Yes;
                if (MessageBox.Show("¿Esta seguro de eliminar este cultivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == op)
                {
                    EliminarCultivo();
                    MostrarCultivos();
                    MessageBox.Show("¡Cultivo eliminado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void EliminarCultivo()
        {
            String id = dgvCultivo.CurrentRow.Cells["IDCultivo"].Value.ToString();
            _Cultivo.EliminarCultivo(id);
        }

        private void AdministrarCultivos2_Load(object sender, EventArgs e)
        {
            cbPlanta.SelectedIndex = 0;
            dtpCosecha.MinDate = dtpPlantado.Value;
            MostrarCultivos();
            
            LlenarDataTableDatosClimaMes();
            //Error aqui
            CalcularPlagaAutomatico();
            
        }

        public void MostrarCultivos()
        {
            CN_Cultivos _Cultivos = new CN_Cultivos();
            tablaCultivos = _Cultivos.MostrarCultivos(Program.cargo, Program.nickname);
            dgvCultivo.DataSource = tablaCultivos;
            //if (Program.cargo != "Admin")
            //{
            //    dgvCultivo.Columns["Usuario"].Visible = false;
            //}
        }

        private void cbPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                disp = "Disponible (Kgs): ";
                if (cbPlanta.SelectedItem.ToString() == "Sorgo")
                {
                    picCultivo.Image = imageListPlantas.Images[1];
                    //lectorDisp = _CN_Almacen.DisponibleCultivo("Sorgo");
                    //calcularDisponible();
                }
                else if (cbPlanta.SelectedItem.ToString() == "Maíz")
                {
                    picCultivo.Image = imageListPlantas.Images[0];
                    //lectorDisp = _CN_Almacen.DisponibleCultivo("Maíz");
                    //calcularDisponible();
                }
                else if (cbPlanta.SelectedItem.ToString() == "Soya")
                {
                    picCultivo.Image = imageListPlantas.Images[2];
                }
                else if (cbPlanta.SelectedItem.ToString() == "Caña")
                {
                    picCultivo.Image = imageListPlantas.Images[3];
                }
                else if (cbPlanta.SelectedItem.ToString() == "Cebolla")
                {
                    picCultivo.Image = imageListPlantas.Images[4];
                }
            }
            catch (Exception a)
            {
                //Error esto falla debido a que manda llamar la tabla almacén la cual aun no existe
                MessageBox.Show("Este es el primer error");
                MessageBox.Show("Ha ocurrido un error " + a, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void calcularDisponible()
        {
            if (lectorDisp.Read())
            {
                if (lectorDisp[0].ToString().Equals(""))
                    disponibleCultivo = 0;
                else
                    disponibleCultivo = Convert.ToInt32(lectorDisp[0].ToString());

                disp += disponibleCultivo;
                lblDisponible.Text = disp + " Kgs";
            }
            lectorDisp.Close();
        }

        private void dtpPlantado_ValueChanged(object sender, EventArgs e)
        {
            dtpCosecha.MinDate = dtpPlantado.Value;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void SoloNumeros(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtBuscarUnCultivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

            }
        }

        private void txtBuscarUnCultivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tablaCultivos.DefaultView;
                dv.RowFilter = string.Format("nombreSemilla like '%{0}%'", txtBuscarUnCultivo.Text);
                dgvCultivo.DataSource = dv.ToTable();
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error muski2" + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCosechar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCultivo.Rows.Count == 0)
                {
                    MessageBox.Show("¡No hay ningun cultivo agregado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de cosechar este cultivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String Cantidad;
                        Cantidad = Interaction.InputBox("Ingrese cantidad de cosechados", "Cantidad");
                        if (saberSiEsNumero(Cantidad) == false)
                        {
                            MessageBox.Show("¡No es un numero el que se ingresó!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (Convert.ToInt32(Cantidad) == 0 || Convert.ToInt32(Cantidad) < 0 || Convert.ToInt32(Cantidad) > Convert.ToInt32(dgvCultivo.CurrentRow.Cells["Cantidad"].Value.ToString()))
                            {
                                MessageBox.Show("¡Error con la cantidad!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                AgregarCosecha(Cantidad);
                                //EliminarCultivo();
                                MostrarCultivos();
                                MessageBox.Show("¡Cultivo cosechado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error muski3" + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private Boolean saberSiEsNumero(String numero)
        {
            try
            {
                int n = Convert.ToInt32(numero);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void AgregarCosecha(String Cantidad)
        {
            try
            {
                DateTime fechaplantado;
                float cantidad;
                String Usuario_Cultivo, Cultivo, fechacosecha, estado;
                int idCultivo;
                /*
                Usuario_Cultivo = dgvCultivo.CurrentRow.Cells["Usuario"].Value.ToString();
                Cultivo = dgvCultivo.CurrentRow.Cells["Cultivo"].Value.ToString();
                fechaplantado = Convert.ToDateTime(dgvCultivo.CurrentRow.Cells["Plantado"].Value.ToString());
                fechacosecha = DateTime.Now.ToString("yy-MM-dd");
                //Cantidad = dgvCultivo.CurrentRow.Cells["Cantidad"].Value.ToString();
                estado = dgvCultivo.CurrentRow.Cells["Estado"].Value.ToString();
                _Cosechas.AgregarCosechas(Usuario_Cultivo, Cultivo, fechaplantado.ToString("yy-MM-dd"), fechacosecha, Cantidad, estado);
                */
                cantidad = float.Parse(Cantidad);
                idCultivo = int.Parse( dgvCultivo.CurrentRow.Cells["IDCultivo"].Value.ToString());
                //MessageBox.Show(idCultivo);
                _Cosechas.AgregarCosechas(idCultivo,cantidad);
                
                
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error muski4" + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public String[] obtenercultivo() //REGRERAS
        {
            String[] cultivos = new String[dgvCultivo.Rows.Count];
            for (int i = 0; i < dgvCultivo.Rows.Count; i++)
            {
                cultivos[i] = dgvCultivo[2, i].Value.ToString();
            }
            return cultivos;
        }
        public String[] obtenerfplantado()
        {
            String[] plantado = new String[dgvCultivo.Rows.Count];
            for (int i = 0; i < dgvCultivo.Rows.Count; i++)
            {
                plantado[i] = dgvCultivo[3, i].Value.ToString();
            }
            return plantado;
        }
        public String[] obtenerfcosecha()
        {
            String[] cosecha = new String[dgvCultivo.Rows.Count];
            for (int i = 0; i < dgvCultivo.Rows.Count; i++)
            {
                cosecha[i] = dgvCultivo[4, i].Value.ToString();
            }
            return cosecha;
        }
        public void filtrar_y_exportar(String cultivo,String fplantado,String fcosecha  )
        {
            if (dgvCultivo.Rows.Count == 0)
            {
                MessageBox.Show("¡La tabla se encuentra vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dsCultivos Ds = new dsCultivos();
                int filas = dgvCultivo.Rows.Count;
                for (int i = 0; i < filas; i++)
                {
                    // MessageBox.Show(dgvCultivo[2, i].Value.ToString());
                    if (cultivo.Equals("Todos")&& fplantado.Equals("Todos")&& fcosecha.Equals("Todos"))
                    {
                    Ds.Tables[0].Rows.Add(new object[] {
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString(),
                    dgvCultivo[6,i].Value.ToString()});
                    }
                    if (!cultivo.Equals("Todos") && fplantado.Equals("Todos") && fcosecha.Equals("Todos"))
                    {
                        if (cultivo.Equals(dgvCultivo[2, i].Value.ToString()))
                        {
                            Ds.Tables[0].Rows.Add(new object[] {
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString(),
                    dgvCultivo[6,i].Value.ToString()});
                        }
                      
                    }
                    if (cultivo.Equals("Todos") && !fplantado.Equals("Todos") && fcosecha.Equals("Todos"))
                    {
                        if (fplantado.Equals(dgvCultivo[3, i].Value.ToString()))
                        {
                            Ds.Tables[0].Rows.Add(new object[] {
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString(),
                    dgvCultivo[6,i].Value.ToString()});
                        }

                    }
                    if (cultivo.Equals("Todos") && fplantado.Equals("Todos") && !fcosecha.Equals("Todos"))
                    {
                        if (fcosecha.Equals(dgvCultivo[4, i].Value.ToString()))
                        {
                            Ds.Tables[0].Rows.Add(new object[] {
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString(),
                    dgvCultivo[6,i].Value.ToString()});
                        }

                    }
                    //dobles filtros
                    if (!cultivo.Equals("Todos") && !fplantado.Equals("Todos") && fcosecha.Equals("Todos"))
                    {
                        if (cultivo.Equals(dgvCultivo[2, i].Value.ToString())&& fplantado.Equals(dgvCultivo[3, i].Value.ToString()))
                        {
                            Ds.Tables[0].Rows.Add(new object[] {
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString(),
                    dgvCultivo[6,i].Value.ToString()});
                        }

                    }
                    if (cultivo.Equals("Todos") && !fplantado.Equals("Todos") &&!fcosecha.Equals("Todos"))
                    {
                        if (fcosecha.Equals(dgvCultivo[4, i].Value.ToString()) && fplantado.Equals(dgvCultivo[3, i].Value.ToString()))
                        {
                            Ds.Tables[0].Rows.Add(new object[] {
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString(),
                    dgvCultivo[6,i].Value.ToString()});
                        }

                    }
                    if (!cultivo.Equals("Todos") && fplantado.Equals("Todos") && !fcosecha.Equals("Todos"))
                    {
                        if (fcosecha.Equals(dgvCultivo[4, i].Value.ToString()) && cultivo.Equals(dgvCultivo[2, i].Value.ToString()))
                        {
                            Ds.Tables[0].Rows.Add(new object[] {
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString(),
                    dgvCultivo[6,i].Value.ToString()});
                        }

                    }
                    if (!cultivo.Equals("Todos") && !fplantado.Equals("Todos") && !fcosecha.Equals("Todos"))
                    {
                        if (fcosecha.Equals(dgvCultivo[4, i].Value.ToString()) && cultivo.Equals(dgvCultivo[2, i].Value.ToString())&& fplantado.Equals(dgvCultivo[3, i].Value.ToString()))
                        {
                            Ds.Tables[0].Rows.Add(new object[] {
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString(),
                    dgvCultivo[6,i].Value.ToString()});
                        }

                    }



                }
                Reportes r = new Reportes();
                r.setData(Ds);
                r.setReporte(4);
                DialogResult resultado = new DialogResult();
                resultado = r.ShowDialog();
            }
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {

            FRM_FiltroCultivos filtro = new FRM_FiltroCultivos();
           // filtrar_y_exportar("","","");
            filtro.Visible = true;
        }
        
        DataTable tablaDatosClimaMes;
        String estadocaña = null;
        String estadocebolla = null;
        String estadomaiz = null;
        DateTime fechadehoy = DateTime.Now;

        private void CalcularPlaga()
        {
            String estadoprincipal = null;
            estadocaña = null;
            estadocebolla = null;
            estadomaiz = null;
            var query = from row in tablaDatosClimaMes.AsEnumerable()
                        where row.Field<DateTime>("fechaLocal") >= Convert.ToDateTime(dgvCultivo.CurrentRow.Cells["Plantado"].Value.ToString()) && row.Field<DateTime>("fechaLocal") <= DateTime.Now
                        select row;


            //0.- Estacion, 1.- Fecha Local, 2.- Fecha UTC, 3.- Direccion del viento, 4.-Direccion de rafaga, 5.- Rapidez de viento, 
            //6.- Rapidez de rafaga, 7.- Temperatura, 8.- Humedad Relativa, 9.- Presion Atmosferica, 10.- Precipitacion, 11.- Radiacion Solar
            double temperaturaprom = 0;
            double humedad_relativaprom = 0;
            double precipitacionprom = 0;
            int cont = 0;
            if (query.Any())
            {
                DataTable resultados = query.CopyToDataTable();

                foreach (DataRow row in resultados.Rows)
                {
                    if (cont <= 360)
                    {
                        temperaturaprom += Convert.ToDouble(row[7].ToString());
                        humedad_relativaprom += Convert.ToDouble(row[8].ToString());
                        precipitacionprom += Convert.ToDouble(row[10].ToString());
                        cont++;
                    }
                    else
                    {
                        break;
                    }

                }
                temperaturaprom /= cont;
                humedad_relativaprom /= cont;
                precipitacionprom /= cont;


                String cultivo = dgvCultivo.CurrentRow.Cells["Cultivo"].Value.ToString();
                estadoprincipal = "Probabilidad de ";
                if (cultivo == "Caña")
                {
                    estadoprincipal = PlagaCañaAndre(temperaturaprom, humedad_relativaprom, precipitacionprom, dgvCultivo.CurrentRow.Cells["Plantado"].Value.ToString(), dgvCultivo.CurrentRow.Cells["Cosecha"].Value.ToString());
                }
                else if (cultivo == "Maíz")
                {
                    estadoprincipal = PlagaMaiz(temperaturaprom, humedad_relativaprom, precipitacionprom, dgvCultivo.CurrentRow.Cells["Plantado"].Value.ToString(), dgvCultivo.CurrentRow.Cells["Cosecha"].Value.ToString());
                }
                else if (cultivo == "Cebolla")
                {
                    estadoprincipal = PlagaCebolla(temperaturaprom, humedad_relativaprom, precipitacionprom, dgvCultivo.CurrentRow.Cells["Plantado"].Value.ToString(), dgvCultivo.CurrentRow.Cells["Cosecha"].Value.ToString());
                }
                else if (cultivo == "Sorgo")
                {
                    estadoprincipal = PlagaSorgoAndres(Convert.ToDateTime(dgvCultivo.CurrentRow.Cells["Plantado"].Value.ToString()), temperaturaprom, humedad_relativaprom, precipitacionprom);
                }
                else if (cultivo == "Soya")
                {
                    estadoprincipal = Plagasojaoscar(temperaturaprom, humedad_relativaprom, precipitacionprom);
                }

                if (estadoprincipal == "" || estadoprincipal == null || estadoprincipal == "Probabilidad de ")
                {
                    estadoprincipal = "Sin estado";
                    _Cultivo.EditarCultivo(dgvCultivo.CurrentRow.Cells["IDCultivo"].Value.ToString(), estadoprincipal);
                }
                else
                {
                    _Cultivo.EditarCultivo(dgvCultivo.CurrentRow.Cells["IDCultivo"].Value.ToString(), "Probabilidad de " + estadoprincipal);
                    String[] plagaarreglo = estadoprincipal.Split(',');
                    for (int i = 0; i < plagaarreglo.Length; i++)
                    {
                        _Plagas.AgregarPlagas(dgvCultivo.CurrentRow.Cells["IDCultivo"].Value.ToString(), plagaarreglo[i].TrimStart(' '), fechadehoy.ToString("yy-MM-dd"));
                    }

                }

            }
            else
            {
               // MessageBox.Show("No hay datos climaticos de estas fechas");
            }
            MostrarCultivos();
        }

        private void btnCalcularEstado_Click(object sender, EventArgs e)
        {
            CalcularPlaga();
            buscarPlaga();
        }

        public void buscarPlaga()
        {
            DataTable tablaInsecticidas = new DataTable();
            CN_Insecticidas _Insecticidas = new CN_Insecticidas();
            tablaInsecticidas = _Insecticidas.MostrarInsecticidas();
            alertCalendario obj = new alertCalendario();
            alertInsecticida obj2 = new alertInsecticida();

            //foreach (DataRow row in tablaCultivos.Rows) {
            //    if (row["Estado"].ToString() == "Sin estado") {
            //        obj2.ShowDialog();
            //    }
            //    else
            //    {
            //        obj.ShowDialog();
            //    }
                
            //}
        }
        private void CalcularPlagaAutomatico()
        {
            foreach (DataGridViewRow item in dgvCultivo.Rows)
            {
                String estadoprincipal = null;
                estadocaña = null;
                estadocebolla = null;
                estadomaiz = null;
                var query = from row in tablaDatosClimaMes.AsEnumerable()
                            where row.Field<DateTime>("fechaLocal") >= Convert.ToDateTime(item.Cells["Plantado"].Value.ToString()) && row.Field<DateTime>("fechaLocal") <= DateTime.Now
                            select row;
                

                //0.- idDatosAtmosfericos, 1.- estacion, 2.- fechaLocal, 3.- direccionViento, 4.-direccionRafaga, 5.- rapidezViento, 
                //6.- repidezRafaga, 7.- temperatura, 8.- humedadRelativa, 9.- presionAtmosferica, 10.- precipitacion
                double temperaturaprom = 0;
                double humedad_relativaprom = 0;
                double precipitacionprom = 0;
                int cont = 0;
                if (query.Any())
                {
                    DataTable resultados = query.CopyToDataTable();
                    
                    foreach (DataRow row in resultados.Rows)
                    {
                        if (cont <= 360)
                        {
                            temperaturaprom += Convert.ToDouble(row[7].ToString());
                            humedad_relativaprom += Convert.ToDouble(row[8].ToString());
                            precipitacionprom += Convert.ToDouble(row[10].ToString());
                            cont++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    temperaturaprom /= cont;
                    humedad_relativaprom /= cont;
                    precipitacionprom /= cont;


                    String cultivo = item.Cells["Cultivo"].Value.ToString();
                    estadoprincipal = "Probabilidad de ";
                    if (cultivo == "Caña")
                    {
                        estadoprincipal = PlagaCañaAndre(temperaturaprom, humedad_relativaprom, precipitacionprom, item.Cells["Plantado"].Value.ToString(), item.Cells["Cosecha"].Value.ToString());
                    }
                    else if (cultivo == "Maíz")
                    {
                        estadoprincipal = PlagaMaiz(temperaturaprom, humedad_relativaprom, precipitacionprom, item.Cells["Plantado"].Value.ToString(), item.Cells["Cosecha"].Value.ToString());
                    }
                    else if (cultivo == "Cebolla")
                    {
                        estadoprincipal = PlagaCebolla(temperaturaprom, humedad_relativaprom, precipitacionprom, item.Cells["Plantado"].Value.ToString(), item.Cells["Cosecha"].Value.ToString());
                    }
                    else if (cultivo == "Sorgo")
                    {
                        estadoprincipal = PlagaSorgoAndres(Convert.ToDateTime(item.Cells["Plantado"].Value.ToString()), temperaturaprom, humedad_relativaprom, precipitacionprom);
                    }
                    else if (cultivo == "Soya")
                    {
                        estadoprincipal = Plagasojaoscar(temperaturaprom, humedad_relativaprom, precipitacionprom);
                    }

                    if (estadoprincipal == "" || estadoprincipal == null || estadoprincipal == "Probabilidad de ")
                    {
                        estadoprincipal = "Sin estado";
                        _Cultivo.EditarCultivo(item.Cells["IDCultivo"].Value.ToString(), estadoprincipal);
                    }
                    else
                    {
                        _Cultivo.EditarCultivo(item.Cells["IDCultivo"].Value.ToString(), "Probabilidad de " + estadoprincipal);
                    }

                }
                else
                {
                    //MessageBox.Show("No hay datos climaticos de estas fechas");
                }
                MostrarCultivos();
            }
        }

        
        private void LlenarDataTableDatosClimaMes()
        {
            CN_DatosClimaMes _DatosClimaMes = new CN_DatosClimaMes();
            tablaDatosClimaMes = _DatosClimaMes.MostrarDatosClimaMes();
        }
        

        private String PlagaMaiz(double temperaturaprom, double humedad_relativaprom, double precipitacionprom,String dgvplantado,String dgvcosecha)
        {
            DateTime fechahoy = DateTime.Now;
            DateTime fechatentativacosecha = Convert.ToDateTime(dgvcosecha);
            DateTime fechatentativacosecha5dias = fechatentativacosecha.AddDays(5);
            String mes = fechahoy.ToString("MMMM");
            int dia = Convert.ToInt32(fechahoy.ToString("dd"));
            _informacionAXDias = new InformacionAXDias(tablaDatosClimaMes, dgvplantado, 720);
            if (((fechahoy >= primaverainicio && fechahoy <= veranofin) && (temperaturaprom >= 8 && temperaturaprom <= 35)) || ((fechahoy >= primaverainicio && fechahoy <= veranofin) && (temperaturaprom >= 8 && temperaturaprom <= 35) && _informacionAXDias.precipitacionprom < 0.25))
            {
                estadomaiz += "Gusano cogollero, ";
            }
            _informacionAXDias = new InformacionAXDias(tablaDatosClimaMes, dgvplantado, 240);
            if((_informacionAXDias.temperaturaprom >=34 && _informacionAXDias.temperaturaprom <= 36) && _informacionAXDias.precipitacionprom <0.25 && (fechahoy >= primaverainicio && fechahoy <= veranofin))
            {
                estadomaiz += "Araña roja, ";
            }
            if(fechahoy <= Convert.ToDateTime(dgvplantado).AddDays(25))
            {
                estadomaiz += "Trips, ";
            }
            if(fechahoy <= Convert.ToDateTime(dgvplantado).AddDays(85))
            {
                estadomaiz += "Gusano elotero, ";
            }
            DateTime junioinicio = DateTime.Parse("01/06/19");
            DateTime septiembrefin = DateTime.Parse("30/09/19");
            if (fechahoy >= junioinicio && fechahoy <= septiembrefin)
            {
                if(fechahoy >= junioinicio.AddDays(25))
                {
                    estadomaiz += "Gallina ciega, ";
                }
                else
                {
                    estadomaiz += "30% gallina ciega, ";
                }
            }
            if(estadomaiz == null || estadomaiz == "")
            {
                return estadomaiz;
            }
            else
            {
                return estadomaiz.TrimEnd(new Char[] { ' ', ',' });
            }
        }

        private String Plagasojaoscar(double temperatura, Double humedad_relativa, double precipitacion)
        {
            string fechaa_actual = DateTime.Now.ToString("dd/MM/yyyy");

            String ano = DateTime.Now.ToString("yyyy");

            DateTime fecha__actual = Convert.ToDateTime(fechaa_actual);
            
            String estadosoja = "";
            //--------------------------
            if ((fecha__actual >= Convert.ToDateTime("01/10/" + ano)) && (fecha__actual <= Convert.ToDateTime("01/01/" + ano)))
            {
                estadosoja += "Orugas cortadoras, ";
            }
            if ((fecha__actual >= Convert.ToDateTime("02/01/" + ano)) && (fecha__actual <= Convert.ToDateTime("01/05/" + ano)))
            {
                estadosoja += "Orugas defoliadoras, ";
            }

            if ((fecha__actual >= Convert.ToDateTime("01/02/" + ano)) && (fecha__actual <= Convert.ToDateTime("01/05/" + ano)))
            {
                estadosoja += "Barrenador del brote, ";
            }

            if ((fecha__actual >= Convert.ToDateTime("01/03/" + ano)) && (fecha__actual <= Convert.ToDateTime("01/06/" + ano)))
            {
                estadosoja += "Chinches, ";
            }
            if (estadosoja == null || estadosoja == "")
            {
                return estadosoja;
            }
            else
            {
                return estadosoja.TrimEnd(new Char[] { ' ', ',' });
            }
        }
        private String PlagaSorgoAndres(DateTime fechaPlantado, double precipitacion, double temperatura, double humedad)
        {
            var fechaHoy = DateTime.Now;
            var fechaCogollero = fechaPlantado.AddMonths(1);
            var fechaInicioFloracion = fechaPlantado.AddMonths(2);
            fechaInicioFloracion = fechaInicioFloracion.AddDays(10);
            // 70 dias despues de plantado, puede comenzar a surgir la plaga de la mosca midgee
            // Hasta 15 días depues de que comenzó la floracion
            var fechaFinalFloracion = fechaInicioFloracion.AddDays(15);

            var plagas = "";

            var anio = DateTime.Now.ToString("yyyy");

            // Gusano de la panoja 
            if ((fechaHoy >= Convert.ToDateTime("21/03/" + anio)) && (fechaHoy <= Convert.ToDateTime("20/06/" + anio)))
                if (precipitacion >= 0.25)
                    return $"Presencia Gusano de la Panoja";


            if (fechaPlantado <= fechaCogollero) plagas += $"Inicio desarrollo Gusano Cogollero, ";

            if (fechaHoy >= fechaInicioFloracion && fechaHoy <= fechaFinalFloracion)
                plagas += $"Inicio desarrollo Mosca Midge,  ";

            // Pulgon amarillo
            // el pulgon se desarrolla 5 dias despues del plantado
            // y puede llegar a vivir hasta 23 dias después de haber "nacido".
            var fechaFinalCrecimientoPulgonAmarillo = fechaPlantado.AddDays(5);
            var fechaMuertePulgonAmarillo = fechaFinalCrecimientoPulgonAmarillo.AddDays(23);
            MessageBox.Show($"{fechaPlantado},{fechaFinalCrecimientoPulgonAmarillo}, {fechaMuertePulgonAmarillo}");
            if (fechaHoy <= fechaFinalCrecimientoPulgonAmarillo && temperatura > 24 && temperatura < 26)
                plagas += $"Desarrollo de pulgon amarillo, ";

            if (fechaHoy <= fechaMuertePulgonAmarillo && fechaHoy > fechaFinalCrecimientoPulgonAmarillo)
                plagas += $"Presencia del adulto pulgon amarillo, ";

            // Pulgon del Cogollo
            // Sobrevive y se desarrolla en estas condiciones -> (25, 55 ± 1°C y 68,25 ± 10 %

            if (temperatura > 24 && temperatura < 26 && humedad > 58.25 && humedad < 78.25)
            {
                plagas += $"Presencia del pulgon del cogollo, ";
            }

            // Tizon de la hoja.
            var fechaInicioTizonDeLaHoja = fechaPlantado.AddDays(60);
            var fechaFinTizonDeLaHoja = fechaPlantado.AddDays(60);

            if (fechaHoy >= fechaInicioTizonDeLaHoja && fechaHoy <= fechaFinTizonDeLaHoja)
            {
                plagas += $"Posible Tizon de la Hoja(Helmintosporium sp.), ";
            }

            // Roya del sorgo
            // después de los 60 días comienza a madurar el grano.
            var fechaInicioRoya = fechaPlantado.AddDays(60);
            // aproximadamente después de 90 días, el sorgo se puede cosechar.
            var fechasFinalesCultivo = fechaPlantado.AddDays(90);

            if (fechaHoy >= fechaInicioRoya && fechaHoy <= fechasFinalesCultivo && temperatura > 16 && temperatura < 28)
            {
                plagas += $"Posible Roya o chahuixtle, ";
            }

            // el tizon de la panoja se desarrolla con una alta humedad relativa
            // estandar: 75%

            if (humedad >= 75)
            {
                plagas += $"Posible Tizon de la Panoja(Hongo Fusariummoniliforme), ";
            }

            

            if (plagas == null || plagas == "")
            {
                return plagas;
            }
            else
            {
                return plagas.TrimEnd(new Char[] { ' ', ',' });
            }
        }
        InformacionAXDias _informacionAXDias;
        DateTime primaverainicio = DateTime.Parse("21/03/19");
        DateTime primaverafin = DateTime.Parse("20/06/19");
        DateTime veranoinicio = DateTime.Parse("21/06/19");
        DateTime veranofin = DateTime.Parse("20/09/19");
        DateTime otoñoinicio = DateTime.Parse("21/09/19");
        DateTime otoñofin = DateTime.Parse("20/12/19");
        DateTime inviernoinicio = DateTime.Parse("21/12/19");
        DateTime inviernofin = DateTime.Parse("20/03/19");

        private String PlagaCañaAndre(double temperaturaprom, double humedad_relativaprom, double precipitacionprom, String dgvplantado, String dgvcosecha)
        {
            DateTime fechahoy = DateTime.Now;
            DateTime fechatentativacosecha = Convert.ToDateTime(dgvcosecha);
            DateTime fechatentativacosecha5dias = fechatentativacosecha.AddDays(5);
            _informacionAXDias = new InformacionAXDias(tablaDatosClimaMes, dgvplantado, 360);
            String mes = fechahoy.ToString("MMMM");
            int dia = Convert.ToInt32(fechahoy.ToString("dd"));
            //Mosca pinta 
            if ((dia >= 20 && mes == "octubre") || (dia <= 10 && mes == "noviembre") || mes == "mayo" || mes == "junio")
            {
                if (mes == "octubre" || mes == "noviembre")
                {
                    estadocaña += "Huevecillos de mosca pinta, ";
                }
                if (mes == "mayo" || mes == "junio")
                {
                    if (humedad_relativaprom >= 80)
                        estadocaña += "Mosca pinta comiendo cultivo, ";
                }
            }
            if (fechatentativacosecha <= fechahoy)
            {
                _informacionAXDias = new InformacionAXDias(tablaDatosClimaMes, dgvplantado, 168);
                if (_informacionAXDias.precipitacionprom > 0.25)
                {
                    estadocaña += "Gusano Barrenador, Rata, ";
                }
                estadocaña += "Gusano Barrenador, Rata, ";
            }
            if (fechahoy < fechatentativacosecha5dias && temperaturaprom > 24 && temperaturaprom < 26)
            {
                estadocaña += "Pulgon amarillo, ";
            }
            _informacionAXDias = new InformacionAXDias(tablaDatosClimaMes, dgvplantado, 720);
            if ((mes == "mayo" || mes == "junio" || mes == "julio" || mes == "agosto" || mes == "septiembre") && _informacionAXDias.temperaturaprom > 35)
            {
                estadocaña += "Chinche de encaje, ";
            }
            if ((fechahoy >= primaverainicio && fechahoy <= primaverafin) || (fechahoy >= veranoinicio && fechahoy <= veranoinicio.AddDays(30)))
            {
                estadocaña += "Piojo harinoso de la vid, ";
            }
            if (estadocaña == null || estadocaña == "")
            {
                return estadocaña;
            }
            else
            {
                return estadocaña.TrimEnd(new Char[] { ' ', ',' });
            }
            

        }
        private String PlagaCebolla(double temperaturaprom, double humedad_relativaprom, double precipitacionprom, String dgvplantado, String dgvcosecha)
        {
            DateTime fechahoy = DateTime.Now;
            DateTime fechatentativacosecha = Convert.ToDateTime(dgvcosecha);
            DateTime fechatentativacosecha5dias = fechatentativacosecha.AddDays(5);
            String mes = fechahoy.ToString("MMMM");
            int dia = Convert.ToInt32(fechahoy.ToString("dd"));

            if((fechahoy >= inviernoinicio && fechahoy <= inviernofin) && temperaturaprom >= 25 && temperaturaprom <= 30)
            {
                estadocebolla += "Trips Frankliniella, ";
            }
            if ((dia > 20 && mes == "agosto")||(dia > 15 && mes == "septiembre")||(dia < 15 && mes == "octubre"))
            {
                estadocebolla += "Gusano soldado, ";
            }
            _informacionAXDias = new InformacionAXDias(tablaDatosClimaMes, dgvplantado, 96);
            if(_informacionAXDias.temperaturaprom <= 32 && _informacionAXDias.temperaturaprom >= 28)
            {
                estadocebolla += "Larva minador de la hoja, ";
            }
            _informacionAXDias = new InformacionAXDias(tablaDatosClimaMes, dgvplantado, 192);
            if (_informacionAXDias.temperaturaprom <= 22 && _informacionAXDias.temperaturaprom >= 18)
            {
                estadocebolla += "Larva minador de la hoja, ";
            }
            _informacionAXDias = new InformacionAXDias(tablaDatosClimaMes, dgvplantado, 720);
            if (estadocebolla.Contains("Larva minador de la hoja") && _informacionAXDias.temperaturaprom >= 20 && _informacionAXDias.temperaturaprom <= 30)
            {
                estadocebolla += "Minador de la hoja adulto";
            }

            if (estadocebolla == null || estadocebolla == "")
            {
                return estadocebolla;
            }
            else
            {
                return estadocebolla.TrimEnd(new Char[] { ' ', ',' });
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MostrarCultivos();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataView dv = tablaCultivos.DefaultView;
            dv.RowFilter = string.Format("fechaPlantado = '{0:yyyy-MM-dd}' or fechaCosechado = '{0:yyyy-MM-dd}'", dateTimePicker1.Value);
            dgvCultivo.DataSource = dv.ToTable();
        }
    }
}

