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
    public partial class Insecticidas : Form
    {
        DataTable tablaInsecticidas = new DataTable();
        CN_Insecticidas _Insecticidas = new CN_Insecticidas();

        public Insecticidas()
        {
            InitializeComponent();
        }

        private void Insecticidas_Load(object sender, EventArgs e)
        {
            MostrarInsecticidas();
            comboBox1.SelectedIndex = 0;
            agregar.Enabled = true;
            eliminar.Enabled = false;
            editar.Enabled = false;
        }

        public void MostrarInsecticidas()
        {
            CN_Insecticidas _Insecticidas = new CN_Insecticidas();
            tablaInsecticidas = _Insecticidas.MostrarInsecticidas(Program.cargo, Program.nickname);
            dataGridView1.DataSource = tablaInsecticidas;
            if (Program.cargo != "Admin")
            {
                dataGridView1.Columns["UsuarioNombre"].Visible = false;
            }
        }
        public void limpiar()
        {
            idInsecticida.Text = "";
            nombre.Text = "";
            precio.Text = "";
            comboBox1.SelectedIndex = 0;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea agregar?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nombre.Text == " " || precio.Text == " ")
                {
                    MessageBox.Show("Complete todos los campos");
                }
                else
                {
                    _Insecticidas.AgregarInsecticida(Program.nickname, nombre.Text, precio.Text, comboBox1.Text,desc.Text);
                    MostrarInsecticidas();
                    limpiar();
                    agregar.Enabled = true;
                    eliminar.Enabled = false;
                    editar.Enabled = false;
                }
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea elimnar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Insecticidas.EliminarInsecticida(idInsecticida.Text);
                MostrarInsecticidas();
                limpiar();
                agregar.Enabled = true;
                eliminar.Enabled = false;
                editar.Enabled = false;
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea editar?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nombre.Text == " " || precio.Text == " ")
                {
                    MessageBox.Show("Complete todos los campos");
                }
                else
                {
                    _Insecticidas.EditarInsecticida(nombre.Text, precio.Text, comboBox1.Text, idInsecticida.Text,desc.Text);
                    MostrarInsecticidas();
                    limpiar();
                    agregar.Enabled = true;
                    eliminar.Enabled = false;
                    editar.Enabled = false;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idInsecticida.Text = dataGridView1.CurrentRow.Cells["idInsecticidas"].Value.ToString();
            nombre.Text = dataGridView1.CurrentRow.Cells["nombreInsecticida"].Value.ToString();
            precio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
            comboBox1.Text =dataGridView1.CurrentRow.Cells["nombrePlaga"].Value.ToString();
            desc.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
            agregar.Enabled = false;
            eliminar.Enabled = true;
            editar.Enabled = true;
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; 
            }
        }
    }
}
