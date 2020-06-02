using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using MySql.Data.MySqlClient;

namespace Capa_Presentacion
{
    public partial class Fertilizaciones : Form
    {
        CN_Fertilizaciones _CN_Fertilizaciones = new CN_Fertilizaciones();
        CN_Cultivos _CN_Cultivos = new CN_Cultivos();
        CN_Fertilizantes _CN_Fertilizante = new CN_Fertilizantes();

        public Fertilizaciones()
        {
            InitializeComponent();
        }

        private void Fertilizaciones_Load(object sender, EventArgs e)
        {

            llenarCB();
            //MessageBox.Show(DateTime.Now.ToString("MM/dd/yyyy"));
            
            MostrarFertilizaciones();
            agregarFilas();
        }

        MySqlConnection conexion = new MySqlConnection("Server=162.241.60.239; Database = saspreco_saspreuniversal; Uid = saspreco_muski; Pwd = muski1234; Convert Zero Datetime=True;");
        
        private void llenarCB()
        {
            cbFertilizante.Items.Clear();
            cbCultivo.Items.Clear();

            cbCultivo.DataSource = _CN_Cultivos.MostrarCultivos(Program.cargo, Program.nickname);
            cbCultivo.ValueMember = "idCultivos";
            cbCultivo.DisplayMember = "nombreSemilla";

            cbFertilizante.DataSource = _CN_Fertilizante.MostrarFertilizantes();
            cbFertilizante.ValueMember = "idFertilizantes";
            cbFertilizante.DisplayMember = "nombreFertilizante";



            /*
            
            MySqlCommand comando = new MySqlCommand("SELECT nombreFertilizante from fertilizantes", conexion);
            conexion.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbFertilizante.Items.Add(registro["nombreFertilizante"].ToString());
            }

            conexion.Close();


            MySqlCommand comando2 = new MySqlCommand("SELECT nombreSemilla, id from semillas JOIN cultivos ON semillas.idSemillas = cultivos.idSemillas ", conexion);
            conexion.Open();
            MySqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                cbCultivo.Items.Add(registro2["nombreSemilla"].ToString());

            }
            conexion.Close();*/
        }

        private void agregarFilas()
        {   
            dgvEtapas.Rows.Add("Siembra", "0", "", "0");
            dgvEtapas.Rows.Add("Floración", "0", "", "0");
            dgvEtapas.Rows.Add("Floración a Fructificación", "0", "", "0");
            dgvEtapas.Rows.Add("Fructificación a cosecha", "0", "", "0");
            dgvEtapas.Rows.Add("Cosecha", "0", "", "0");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarFertilizaciones();
        }

        private void AgregarFertilizaciones()
        {

            try
            {
                /*
                MySqlCommand comando = new MySqlCommand("SELECT * from fertilizantes", conexion);
                conexion.Open();
                MySqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    if (fertilizante.Equals(registro["nombreFertilizante"].ToString()))
                    {
                        idF = int.Parse( registro["idFertilizantes"].ToString());
                    }
                }

                conexion.Close();

                MySqlCommand comando2 = new MySqlCommand("SELECT * from semillas JOIN cultivos ON semillas.idSemillas = cultivos.idSemillas ", conexion);
                conexion.Open();
                MySqlDataReader registro2 = comando2.ExecuteReader();
                while (registro.Read())
                {
                    if (cultivo.Equals(registro["nombreSemilla"].ToString()))
                    {
                        idF = int.Parse(registro["idFertilizantes"].ToString());
                    }
                }

                conexion.Close();
                */
                fecha = dateTimePicker1.Value;

                _CN_Fertilizaciones.AgregarFertilizaciones(cbCultivo.SelectedValue.ToString(), cbFertilizante.SelectedValue.ToString(), Program.idusuario.ToString(), dateTimePicker1.Value.ToString("yy-MM-dd")) ;
                MostrarFertilizaciones();

                    MessageBox.Show("Agregado con éxito");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarFertilizaciones()
        {
            try
            {

                CN_Costos _Costos = new CN_Costos();
                CN_Fertilizaciones _CN_Fertilizaciones = new CN_Fertilizaciones();
                dgvFertilizaciones.DataSource = _CN_Fertilizaciones.MostrarFertilizaciones();

            }
            catch (Exception a)
            {

                MessageBox.Show("ADVERTENCIA", "Error al mostrar fertilizaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        double total = 0;
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            total = 0;
            double kgetapa = 0;
            double kgpordias = 0;
            foreach (DataGridViewRow row in dgvEtapas.Rows)
            {
                kgetapa = Convert.ToDouble(row.Cells[1].Value.ToString());
                kgpordias = Convert.ToDouble(row.Cells[3].Value.ToString());
                row.Cells[4].Value = kgetapa * kgpordias;
                total += Convert.ToDouble(row.Cells[4].Value.ToString());
            }

            foreach (DataGridViewRow row in dgvEtapas.Rows)
            {
                row.Cells[5].Value = calcularPorcentaje(Convert.ToDouble(row.Cells[4].Value.ToString()));

            }
            String[] arrayNecesitado = new String[3];
            String[] arrayTiene = new String[3];
            int[] arregloTotal = new int[3];
            arrayNecesitado = dgvFertilizaciones.CurrentRow.Cells[2].Value.ToString().Split(',');
            arrayTiene = dgvFertilizaciones.CurrentRow.Cells[3].Value.ToString().Split(',');

            for (int i = 0; i < 3; i++)
            {
                arregloTotal[i] = Convert.ToInt32(arrayNecesitado[i]) - Convert.ToInt32(arrayTiene[i]);
                //MessageBox.Show(arregloTotal[i].ToString());
            }

            for (int i = 0; i < 3; i++)
            {
                foreach (DataGridViewRow row in dgvEtapas.Rows)
                {
                    double val1 = 0;
                    int val2 = 0;
                    val1 = Math.Ceiling(arregloTotal[i]*(Convert.ToDouble(row.Cells[5].Value)/100));
                    val2 = Convert.ToInt32(Math.Ceiling((val1 / Convert.ToDouble(row.Cells[4].Value) * 100)));
                    if (i != 2)
                        row.Cells[2].Value += val2 + ",";
                    else
                        row.Cells[2].Value += val2.ToString();
                }
            }

        }

        private double calcularPorcentaje(double kgetapa)
        {
            double res = (kgetapa * 100) / total;
            return Convert.ToDouble(res.ToString("F"));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea elimnar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _CN_Fertilizaciones.EliminarFertilizaciones(idFertilizaciones.Text);
                MostrarFertilizaciones();
                limpiar();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                MessageBox.Show("Fertilización eliminada con éxito");

            }
        }

        public void limpiar()
        {/*
            idFertilizaciones.Text = "";
            txtFertilizante.Text = "";
            txtNPKNecesario.Text = "";
            cbCultivo.SelectedIndex = 0;*/
        }

        private void dgvFertilizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idFertilizaciones.Text = dgvFertilizaciones.CurrentRow.Cells["idFertilizaciones"].Value.ToString();
            
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
        }
        DateTime fecha;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha = dateTimePicker1.Value;
        }
    }
}
