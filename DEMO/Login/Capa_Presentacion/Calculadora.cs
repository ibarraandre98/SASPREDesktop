using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Calculadora : Form
    {
        String cultivo;
        double precio, total, cantidad;
        DataTable tablaCostos = new DataTable();
        private CN_Costos _Costos = new CN_Costos();
        public Calculadora()
        {
            InitializeComponent();
        }

        int posX = 0;
        int posY = 0;
        private void Calculadora_MouseMove(object sender, MouseEventArgs e)
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

        private void btnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cbCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in tablaCostos.Rows)
            {
                if (row["nombreSemilla"].ToString().Equals(cbCultivo.Text))
                {
                    precio = Convert.ToDouble( row["precio"].ToString());
                    lbPrecio.Text = " $ " + precio;
                }
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            tablaCostos = _Costos.MostrarCostos();
            // cbCultivo.SelectedIndex = 0;
            cbCultivo.Items.Clear();

            foreach (DataRow row in tablaCostos.Rows)
            {
                cbCultivo.Items.Add(row["nombreSemilla"].ToString());
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToDouble(tbCantidad.Text.ToString());
            total = precio * cantidad;
            lbTotal.Text = "$ " + total;
        }
    }
}
