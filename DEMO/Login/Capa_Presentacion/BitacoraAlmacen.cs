using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class BitacoraAlmacen : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public BitacoraAlmacen()
        {
            InitializeComponent();
        }

        private void BtnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BitacoraAlmacen_Load(object sender, EventArgs e)
        {
            MostrarAlmacen();
        }

        private void MostrarAlmacen()
        {
            CN_Almacen _CN_Almacen = new CN_Almacen();
            dgvAlmacen.DataSource = _CN_Almacen.MostrarBitacoraAlmacen(Program.cargo, Program.nickname);
            if (Program.cargo != "Admin")
            {
                dgvAlmacen.Columns["usuarioAlmacen"].Visible = false;
            }
        }
        int posX = 0;
        int posY = 0;
        private void dgvAlmacen_MouseMove(object sender, MouseEventArgs e)
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

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            dsBitacoraAlmacen Ds = new dsBitacoraAlmacen();
            int filas = dgvAlmacen.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] {
                    dgvAlmacen[0,i].Value.ToString(),
                    dgvAlmacen[1,i].Value.ToString(),
                    dgvAlmacen[2,i].Value.ToString(),
                    dgvAlmacen[3,i].Value.ToString(),
                    dgvAlmacen[4,i].Value.ToString(),
                    dgvAlmacen[5,i].Value.ToString(),
                    dgvAlmacen[6,i].Value.ToString(),
                    dgvAlmacen[7,i].Value.ToString()});
            }
            Reportes r = new Reportes();
            r.setData(Ds);
            r.setReporte(10);
            DialogResult resultado = new DialogResult();
            resultado = r.ShowDialog();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
