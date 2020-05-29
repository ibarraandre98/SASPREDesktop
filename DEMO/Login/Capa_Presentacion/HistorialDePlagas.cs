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
    public partial class HistorialDePlagas : Form
    {
        private CN_Plagas _Plagas = new CN_Plagas();
        private DataTable tablaPlagas;
        public HistorialDePlagas()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            dsHistorialPlagas Ds = new dsHistorialPlagas();
            int filas = dgvHistorial.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] {
                    dgvHistorial[0,i].Value.ToString(),
                    dgvHistorial[1,i].Value.ToString(),
                    dgvHistorial[2,i].Value.ToString(),
                    dgvHistorial[3,i].Value.ToString()});
            }
            Reportes r = new Reportes();
            r.setData(Ds);
            r.setReporte(5);
            DialogResult resultado = new DialogResult();
            resultado = r.ShowDialog();
        }
        public void MostrarHistorialplagas()
        {
            CN_Plagas _Plagas = new CN_Plagas();
            tablaPlagas = _Plagas.MostrarPlaga();
            dgvHistorial.DataSource = tablaPlagas;
        }
        public void HistorialDePlagas_Load(object sender, EventArgs e)
        {
            MostrarHistorialplagas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tablaPlagas.DefaultView;
                dv.RowFilter = string.Format("nombreSemilla like '%{0}%' or nombrePlaga like '%{0}%'", textBox1.Text);
                dgvHistorial.DataSource = dv.ToTable();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al buscar cultivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataView dv = tablaPlagas.DefaultView;
            dv.RowFilter = string.Format("fechaprediccion = '{0:yyyy-MM-dd}'", dateTimePicker1.Value);
            dgvHistorial.DataSource = dv.ToTable();
        }
    }
}
