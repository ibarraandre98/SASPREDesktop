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
    public partial class Cosechas : Form
    {
        DataTable tablaCosechas;
        public Cosechas()
        {
            InitializeComponent();
        }

        CN_Cosechas _Cosechas = new CN_Cosechas();
        private void Cosechas_Load(object sender, EventArgs e)
        {
            MostrarCosechas();
        }
        public void MostrarCosechas()
        {
            try
            {
                tablaCosechas = null;
                CN_Cosechas _Cosechas = new CN_Cosechas();
                tablaCosechas = _Cosechas.MostrarCosechas(Program.cargo, Program.nickname);
                dgvCultivo.DataSource = tablaCosechas;
                if(Program.cargo!= "Admin")
                    dgvCultivo.Columns["Usuario"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al mostrar las cosechas","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtBuscarUnCultivo_TextChanged(object sender, EventArgs e)
        {
            try { 
            DataView dv = tablaCosechas.DefaultView;
            dv.RowFilter = string.Format("nombreSemilla like '%{0}%'", txtBuscarUnCultivo.Text);
            dgvCultivo.DataSource = dv.ToTable();
        }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataView dv = tablaCosechas.DefaultView;
            dv.RowFilter = string.Format("fechaPlantado = '{0:yyyy-MM-dd}' or fechaCosechado = '{0:yyyy-MM-dd}'", dtpPlantado.Value);
            dgvCultivo.DataSource = dv.ToTable();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            dsCosechas Ds = new dsCosechas();
            int filas = dgvCultivo.Rows.Count;
            for(int i = 0; i <filas; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] { dgvCultivo[0,i].Value.ToString(),
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),
                    dgvCultivo[3,i].Value.ToString(),
                    dgvCultivo[4,i].Value.ToString(),
                    dgvCultivo[5,i].Value.ToString()});
            }
            Reportes r = new Reportes();
            r.setData(Ds);
            r.setReporte(3);
            DialogResult resultado = new DialogResult();
            resultado = r.ShowDialog();
           //r.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MostrarCosechas();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarCosechas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarCosechas();
            MostrarCosechas();
        }

        private void EditarCosechas()
        {
            try
            {
                if(dgvCultivo.CurrentRow.Cells["Estado"].Value.ToString() == "")
                {
                    MessageBox.Show("Ya está limpio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _Cosechas.EditarCosechas(dgvCultivo.CurrentRow.Cells["IDCultivo"].Value.ToString(), null);
                    MessageBox.Show("Limpiado estado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
           
        }
    }
}
