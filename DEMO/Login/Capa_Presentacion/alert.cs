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
    public partial class alert : Form
    {
        public alert(string _message, Alertype type)
        {
            InitializeComponent();

            message.Text = _message;

            switch (type)
            {
                case Alertype.succes:
                    this.BackColor = Color.SeaGreen;
                    pictureBox.Image = imageList1.Images[0];
                    break;
                case Alertype.info:
                    this.BackColor = Color.FromArgb(31, 139, 188);
                    pictureBox.Image = imageList1.Images[1];
                    break;
                case Alertype.warning:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    pictureBox.Image = imageList1.Images[2];
                    break;
                case Alertype.error:
                    this.BackColor = Color.Red;
                    pictureBox.Image = imageList1.Images[3];
                    break;
            }
        }
        /// <summary>
        /// Alerts the specified message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>

        public static void Show(string message, Alertype type)
        {
            new alert(message, type).Show();
        }

        private void Alerta_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;

            show.Start();
        }



        private void btnCer_Click(object sender, EventArgs e)
        {
            close.Start();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            close.Start();
        }

        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }

        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
        }
    }

    public enum Alertype
    {
        succes, info, warning, error
    }
}
