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
    public partial class Costos : Form
    {
        String cultivo, opcion = "", descripcio;
        double precio;
        int id;
        DataTable tablaCostos = new DataTable();
        DataTable tablaCultivo = new DataTable();
        DataTable tablaNombresCultivos = new DataTable();

        private CN_Costos _Costos = new CN_Costos();
        private CN_Alarmas _Alarmas = new CN_Alarmas();
        public Costos()
        {
            InitializeComponent();
            BtnExp.Enabled=true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cultivo = cbCultivo.Text;
            descripcio = descripcion.Text;
            if (Evaluar(cultivo) == true)
            {
                precio = Convert.ToDouble(tbPrecio.Text);
                
                _Costos.InsertarCostos(cultivo, precio,descripcio);
                alert.Show("Se agrego exitosamente el costo", Alertype.succes);
            }
            else
            {
                alert.Show("No se puede agregar costo a un cultivo que ya a sido registrado", Alertype.warning);
            }
            
            tbPrecio.Text = "0";
            MostraCostos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            cultivo = cbCultivo.Text;
            String idCostos = dgvCultivo.CurrentRow.Cells["idCostos"].Value.ToString();




            precio = Convert.ToDouble(tbPrecio.Text);
                descripcio = descripcion.Text;
                _Costos.ModificarCostos(idCostos,cultivo, precio, descripcio);

                alert.Show("Se ha modificado el costo", Alertype.succes);
           
            MostraCostos();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnElimiar_Click(object sender, EventArgs e)
        {
            cultivo = cbCultivo.Text;
            _Costos.ElimiarCostos(idCostos);
            MostraCostos();
            alert.Show("Se ha eliminado el costo", Alertype.succes);
            tbPrecio.Text = "";
            cbCultivo.Text = "";
            
        }

        private Boolean Evaluar(String cultivo)
        {
            String nombre;
            tablaCostos = _Costos.MostrarCostos();

            foreach (DataRow row in tablaCostos.Rows)
            {
                nombre = row["nombreSemilla"].ToString();
                if (nombre == cultivo)
                {
                    return false;
                }
            }
            return true;
        }

        private void MostraCostos()
        {
                    
           CN_Costos _Costos = new CN_Costos();

        dgvCultivo.DataSource = null;
            dgvCultivo.DataSource = _Costos.MostrarCostos();
        }

        private void Costos_Load(object sender, EventArgs e)
        {
            bool ban1 = false;
            MostraCostos();
            tablaCultivo = _Costos.MostrarCultivo();
            CargarNombresCultivos();
            //cbCultivo.SelectedIndex = 0;
            //cbCultivo.Items.Clear();

        }

        private void CargarNombresCultivos()
        {
            tablaNombresCultivos = _Alarmas.MostrarNombresCultivos();
            cbCultivo.DataSource = tablaNombresCultivos;
            cbCultivo.ValueMember = "idSemillas";
            cbCultivo.DisplayMember = "nombreSemilla";
           
                       
        }
        String idCostos,idSemilla;
        private void dgvCultivo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

            cbCultivo.Text = dgvCultivo.CurrentRow.Cells["nombreSemilla"].Value.ToString();
            tbPrecio.Text = dgvCultivo.CurrentRow.Cells["precio"].Value.ToString();
            descripcion.Text = dgvCultivo.CurrentRow.Cells["descripcion"].Value.ToString();

            tbPrecio.Enabled = false;
            btnEditar.Enabled = true;
            btnElimiar.Enabled = true;
        }

        private void BtnExportar(object sender,EventArgs e)
        {
            dsCostos Ds = new dsCostos();
            int filas = dgvCultivo.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] { dgvCultivo[0,i].Value.ToString(),
                    dgvCultivo[1,i].Value.ToString(),
                    dgvCultivo[2,i].Value.ToString(),});
            }
            Reportes r = new Reportes();
            r.setData(Ds);
            r.setReporte(8);
            DialogResult resultado = new DialogResult();
            resultado = r.ShowDialog();
            //r.Show();
        }
    }
}
