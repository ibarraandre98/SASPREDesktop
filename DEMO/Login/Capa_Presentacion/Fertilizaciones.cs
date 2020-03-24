using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Fertilizaciones : Form
    {
        CN_Fertilizaciones _CN_Fertilizaciones = new CN_Fertilizaciones();
        public Fertilizaciones()
        {
            InitializeComponent();
        }

        private void Fertilizaciones_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString("MM/dd/yyyy"));
            cbCultivo.SelectedIndex = 0;
            MostrarFertilizaciones();
            agregarFilas();
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
                if (String.IsNullOrWhiteSpace(txtNPKActual.Text) || String.IsNullOrWhiteSpace(txtNPKNecesario.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {
                    _CN_Fertilizaciones.AgregarFertilizaciones(cbCultivo.Text, txtNPKNecesario.Text, txtNPKActual.Text, DateTime.Now.ToString("yy-MM-dd"));
                    MostrarFertilizaciones();
                    MessageBox.Show("Agregado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarFertilizaciones()
        {
            CN_Fertilizaciones _CN_Fertilizaciones = new CN_Fertilizaciones();
            dgvFertilizaciones.DataSource = _CN_Fertilizaciones.MostrarFertilizaciones();
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
    }
}
