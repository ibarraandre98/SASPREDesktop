using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Capa_Negocio;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Fertilizantes : Form
    {
        DataTable tablaFertilizantes;

        private List<string> _plagas, _cultivos;

        public Fertilizantes()
        {
            InitializeComponent();
            _plagas = new List<string>();
            _cultivos = new List<string>();
        }

        private void IniciarComponentes()
        {
            try
            {
                MostrarFertilizantes();
                LlenarComboCultivo();
                LlenarComboPlaga();
                loaded = true;
                comboPlaga.SelectedIndex = 0;
                comboCultivo.SelectedIndex = 0;
            }
            catch (Exception a)
            {

                MessageBox.Show("ADVERTENCIA", "Error al iniciar componentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void MostrarFertilizantes()
        {
            try
            {
                tablaFertilizantes = CN_Fertilizantes.MostrarFertilizantes();
                dgvFertilizantes.DataSource = tablaFertilizantes;

            }
            catch (Exception a)
            {

                MessageBox.Show("ADVERTENCIA", "Error al mostrar fertilizantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LlenarComboPlaga()
        {
            try
            {
                DataTable tablaControlPlagas = CN_Fertilizantes.MostrarFertilizantes();
                foreach (DataRow row in tablaControlPlagas.Rows)
                {
                    var valor = row["Plaga"].ToString();
                    if (!_plagas.Contains(valor))
                    {
                        _plagas.Add(valor);
                    }
                }

                foreach (var item in _plagas)
                {
                    comboPlaga.Items.Add(item.ToString());
                }
                comboPlaga.SelectedIndex = 0;
            }
            catch (Exception a)
            {

                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LlenarComboCultivo()
        {
            try
            {
                DataTable tablaControlPlagas = CN_Fertilizantes.MostrarFertilizantes();
                foreach (DataRow row in tablaControlPlagas.Rows)
                {
                    var valor = row["Cultivo"].ToString();
                    if (!_cultivos.Contains(valor))
                    {
                        _cultivos.Add(valor);
                    }
                }

                foreach (var item in _cultivos)
                {
                    comboCultivo.Items.Add(item.ToString());
                }
                comboCultivo.SelectedIndex = 0;
            }
            catch (Exception a)
            {

                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvFertilizantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtBuscar.Text.Equals("Buscar") || txtBuscar.Text.Equals(""))
                {
                    MostrarFertilizantes();
                }
                else
                {
                    DataView dv = tablaFertilizantes.DefaultView;
                    var query = "Plaga like '%{0}%'";
                    query += " or `Nombre Comercial` like '%{0}%'";
                    query += " or `Epoca de Control` like '%{0}%'";
                    query += " or Cultivo like '%{0}%'";
                    dv.RowFilter = string.Format(query, txtBuscar.Text);
                    dgvFertilizantes.DataSource = dv.ToTable();
                }
                
            }
            catch (Exception a)
            {

                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text.Equals(""))
                {
                    txtBuscar.Text = "Buscar";
                    txtBuscar.ForeColor = Color.Gray;
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text.Equals("Buscar"))
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = Color.Black;
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool loaded = false;

        private void comboPlaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tablaFertilizantes.DefaultView;
                var query = "Plaga like '%{0}%'";
                var index = comboPlaga.SelectedIndex;
                if (index != -1)
                {
                    var value = _plagas[index];
                    dv.RowFilter = string.Format(query, value);
                    dgvFertilizantes.DataSource = dv.ToTable();
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tablaFertilizantes.DefaultView;
                var query = "Cultivo like '%{0}%'";
                var index = comboCultivo.SelectedIndex;
                if (index != -1)
                {
                    var value = _cultivos[index];
                    dv.RowFilter = string.Format(query, value);
                    dgvFertilizantes.DataSource = dv.ToTable();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsFertilizantes Ds = new dsFertilizantes();
            int filas = dgvFertilizantes.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] {
                    dgvFertilizantes[1,i].Value.ToString(),
                    dgvFertilizantes[2,i].Value.ToString(),
                    dgvFertilizantes[3,i].Value.ToString(),
                    dgvFertilizantes[4,i].Value.ToString(),
                dgvFertilizantes[7,i].Value.ToString()});
            }
            Reportes r = new Reportes();
            r.setData(Ds);
            r.setReporte(2);
            DialogResult resultado = new DialogResult();
            resultado = r.ShowDialog();
        }

        private void Fertilizantes_Load(object sender, EventArgs e)
        {
            IniciarComponentes();
        }
    }
}

