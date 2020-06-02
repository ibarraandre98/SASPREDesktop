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
            agregar.Enabled = true;
            eliminar.Enabled = false;
            editar.Enabled = false;
        }

        public void MostrarInsecticidas()
        {
            try { 
            CN_Insecticidas _Insecticidas = new CN_Insecticidas();
                dgvInsecticidas.DataSource = _Insecticidas.MostrarInsecticidas();
            }
            catch (Exception a)
            {
                MessageBox.Show("ADVERTENCIA", "Error al mostrar insecticidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void limpiar()
        {
            idInsecticida.Text = "";
            nombre.Text = "";
            precio.Text = "";
            desc.Text = "";
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea agregar?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nombre.Text == " " || precio.Text == " " || desc.Text ==" ")
                {
                    MessageBox.Show("Complete todos los campos");
                }
                else
                {
                    try
                    {
                        _Insecticidas.AgregarInsecticida(nombre.Text, precio.Text, desc.Text);
                        limpiar();
                        agregar.Enabled = true;
                        eliminar.Enabled = false;
                        editar.Enabled = false;
                        MessageBox.Show("Agregado con éxito");
                        MostrarInsecticidas();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ha ocurrido un error {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
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
                    try { 
                    _Insecticidas.EditarInsecticida(nombre.Text, precio.Text, idInsecticida.Text, desc.Text);
                    MostrarInsecticidas();
                    limpiar();
                    agregar.Enabled = true;
                    eliminar.Enabled = false;
                    editar.Enabled = false;
                    MessageBox.Show("Actualizado con éxito");
                }
                    catch (Exception ex)
                {
                    MessageBox.Show($"Ha ocurrido un error {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; 
            }
        }

        private void dgvFertilizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idInsecticida.Text = dgvInsecticidas.CurrentRow.Cells["idInsecticidas"].Value.ToString();
            nombre.Text = dgvInsecticidas.CurrentRow.Cells["nombreInsecticida"].Value.ToString();
            precio.Text = dgvInsecticidas.CurrentRow.Cells["precio"].Value.ToString();
            desc.Text = dgvInsecticidas.CurrentRow.Cells["descripcion"].Value.ToString();
            agregar.Enabled = false;
            eliminar.Enabled = true;
            editar.Enabled = true;
        }
    }
}
