using System;
using System.Data;
using Capa_Negocio;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Capa_Presentacion
{
    public partial class FromUsuarioABC : Form
    {

        private bool isEditar = false;
        private CN_ABCUsuario _ABCUsuario = new CN_ABCUsuario();
        private int id;

        public FromUsuarioABC()
        {
            InitializeComponent();
        }

        private void FromUsuarioABC_Load(object sender, EventArgs e)
        {
            Mostrar();
            MostrarEmpresas();
            MostrarCargo();
            txtCargo.SelectedIndex = 0;
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var fila = dgvUsers.SelectedRows[0];
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtApellidos.Text = fila.Cells[2].Value.ToString();
                txtContra.Text = fila.Cells[3].Value.ToString();
                txtCargo.Text = fila.Cells[4].Value.ToString();
                txtNick.Text = fila.Cells[5].Value.ToString();

                var correo = fila.Cells[6].Value.ToString();
                txtCorreo.Text = String.IsNullOrEmpty(correo) ? "" : correo;

                id = Convert.ToInt32(fila.Cells[0].Value.ToString());
                if (id != Program.IDADMINPRINCIPAL)
                {
                    IsEditar(isEditar = true);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos() == true)
                {
                    Editar();
                    VaciarCampos();
                    Mostrar();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool EsDireccionDeCorreoValida(string correo)
        {
            try
            {
                var c = new MailAddress(correo);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void Agregar()
        {
            try
            {
                if (!EsDireccionDeCorreoValida(txtCorreo.Text))
                    MessageBox.Show("Verifique el correo electrónico", "Correo invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if((txtNombre.Text != "" && txtApellidos.Text != "" && txtContra.Text != "" && txtCargo.Text != "" && txtNick.Text != "" && txtCorreo.Text != "") && (txtNombre.Text != "" || txtApellidos.Text != "" || txtContra.Text != "" || txtCargo.Text != "" || txtNick.Text != "" || txtCorreo.Text != ""))
                    {
                        _ABCUsuario.RegistrarUsuario(txtNombre.Text, txtApellidos.Text, txtContra.Text, txtCargo.Text, txtNick.Text, txtCorreo.Text,empresas.Text);
                        MessageBox.Show("Usuario registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VaciarCampos();
                        Mostrar();
                    }
                    else
                    {
                        MessageBox.Show("Debe tener todos los campos llenos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                    


            }
            catch(MySqlException ex)
            {
                if(ex.Number == 1062)
                {
                    MessageBox.Show("Ya existe una cuenta con este nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            try
            {
                if (!EsDireccionDeCorreoValida(txtCorreo.Text))
                    MessageBox.Show("Verifique el correo electrónico", "Correo invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    
                    if (id == Program.IDADMINPRINCIPAL) return;

                    else
                    {
                        id = Convert.ToInt32(txtID.Text);
                        _ABCUsuario.EditarUsuario(id, txtNombre.Text, txtApellidos.Text,
                    txtContra.Text, txtCargo.Text, txtNick.Text, txtCorreo.Text,empresas.Text);
                        MessageBox.Show("Usuario actualizado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IsEditar(isEditar = false);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Modificar(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvUsers.CurrentRow.Cells["idUsuario"].Value.ToString();
            txtNombre.Text = dgvUsers.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidos.Text = dgvUsers.CurrentRow.Cells["apellidos"].Value.ToString();
            txtNick.Text = dgvUsers.CurrentRow.Cells["nickname"].Value.ToString();
            txtContra.Text = dgvUsers.CurrentRow.Cells["contra"].Value.ToString();
            txtCorreo.Text = dgvUsers.CurrentRow.Cells["correo"].Value.ToString();
        }

        private void Eliminar()
        {
            var selectedRows = dgvUsers.SelectedRows;

            foreach (DataGridViewRow row in selectedRows)
            {
                //MessageBox.Show($"Row: {row.}");
                try
                {
                    if (Convert.ToInt32(row.Cells["IDUsuario"].Value.ToString()) == Program.IDADMINPRINCIPAL)
                        continue;
                    else
                    {
                        id = Convert.ToInt32(txtID.Text);
                        _ABCUsuario.EliminarUsuario(id);
                        MessageBox.Show("Usuario eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Mostrar()
        {
            try
            {
                CN_ABCUsuario _ABCUsuarioo = new CN_ABCUsuario();
                var tablaUsuarios = _ABCUsuarioo.MostrarUsuarios();
                dgvUsers.DataSource = tablaUsuarios;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void MostrarEmpresas()
        {
            DataTable tablaEmpresas = new DataTable();
            tablaEmpresas = _ABCUsuario.MostrarEmpresas();
            empresas.DataSource = tablaEmpresas;
            empresas.DisplayMember = "nombreEmpresa";
            empresas.ValueMember = "idEmpresa";
        }

        public void MostrarCargo()
        {
            DataTable tablaCargos = new DataTable();
            tablaCargos = _ABCUsuario.MostrarCargo();
            txtCargo.DataSource = tablaCargos;
            txtCargo.DisplayMember = "nombreCargo";
            txtCargo.ValueMember = "idCargo";
        }

        private void IsEditar(bool isEditar)
        {
            try
            {
                if (isEditar)
                {
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    btnAgregar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ValidarCampos()
        {
            var validos = true;
            try
            {


                if (!EsCampoValido(txtApellidos)) validos = false;
                if (!EsCampoValido(txtNombre)) validos = false;
                if (!EsCampoValido(txtContra)) validos = false;
                if (!EsCampoValido(txtCorreo)) validos = false;
                if (!EsCampoValido(txtNick)) validos = false;
                //if (!EsCampoValido(txtCargo)) validos = false;
                return validos;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return validos;
            }

        }

        private bool EsCampoValido(TextBox txtbox)
        {
            if (txtbox.Text == String.Empty)
            {
                return false;
            }
            return true;
        }

        private void VaciarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtNick.Text = string.Empty;
            txtContra.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCargo.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VaciarCampos();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var op = DialogResult.Yes;
            if (MessageBox.Show("¿Esta seguro de eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == op)
            {
                Eliminar();
                VaciarCampos();
                Mostrar();
            }
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsUsuario Ds = new dsUsuario();
            int filas = dgvUsers.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] { dgvUsers[0,i].Value.ToString(),
                    dgvUsers[1,i].Value.ToString(),
                    dgvUsers[2,i].Value.ToString(),
                    dgvUsers[3,i].Value.ToString(),
                    dgvUsers[4,i].Value.ToString(),
                    dgvUsers[5,i].Value.ToString(),
                    dgvUsers[6,i].Value.ToString(),
                    dgvUsers[7,i].Value.ToString()});
            }
            Reportes r = new Reportes();
            r.setData(Ds);
            r.setReporte(1);
            DialogResult resultado = new DialogResult();
            resultado = r.ShowDialog();
            //r.Show();
        }

        private void TableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
