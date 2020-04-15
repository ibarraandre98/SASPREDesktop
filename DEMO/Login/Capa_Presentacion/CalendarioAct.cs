using System;
using System.Collections;
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
    public partial class CalendarioAct : Form
    {
        CN_CalendarioAct _calendario = new CN_CalendarioAct();
        DataTable tablaCalendario;


        public CalendarioAct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea agregar?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nombre.Text == "" || descripcion.Text == "")
                {
                    MessageBox.Show("Favor de completar los campos vacios");
                }
                else
                {

                    _calendario.AgregarCalendario(Program.nickname, nombre.Text, descripcion.Text, monthCalendar1.SelectionRange.Start.ToString("yy-MM-dd"), monthCalendar2.SelectionRange.Start.ToString("yy-MM-dd"));
                    //fechaInicio.Value.ToString("yy-MM-dd"), fechaFin.Value.ToString("yy-MM-dd"), id.Text
                    MostrarCalendario();
                    limpiar();
                }
            }
        }

        private void CalendarioAct_Load(object sender, EventArgs e)
        {
            MostrarCalendario();
            editar.Enabled = false;
            eliminar.Enabled = false;
            monthCalendar1.MinDate = DateTime.Now;
            monthCalendar2.MinDate = DateTime.Now;

        }


        public bool Evaluar(String fecha) {
            CN_CalendarioAct _Calendario = new CN_CalendarioAct();
            tablaCalendario = _Calendario.MostrarCalendario(Program.cargo, Program.nickname);
            String nombre;
            
            foreach (DataRow row in tablaCalendario.Rows)
            {
                nombre = row["FechaInicio"].ToString();
                var nombre2 = DateTime.Parse(nombre);
                var fec = nombre2.ToShortDateString();

                if (fec == fecha)
                {
                    return false;
                }
            }
            return true;
        }
        private void MostrarCalendario()
        {
            CN_CalendarioAct _Calendario = new CN_CalendarioAct();
            tablaCalendario = _Calendario.MostrarCalendario(Program.cargo, Program.nickname);
            dataGridView1.DataSource = tablaCalendario;
            if (Program.cargo != "Admin")
            {
                dataGridView1.Columns["idCalendarioActividades"].Visible = false;
            }

        }

        

        private void editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea editar?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nombre.Text == "" || descripcion.Text == "")
                {
                    MessageBox.Show("Favor de completar los campos vacios");
                }
                else
                {

                    _calendario.EditarCalendario(nombre.Text, descripcion.Text, monthCalendar1.SelectionRange.Start.ToString("yy-MM-dd"), monthCalendar2.SelectionRange.Start.ToString("yy-MM-dd"), id.Text);
                    MostrarCalendario();
                    limpiar();
                    editar.Enabled = false;
                    eliminar.Enabled = false;
                    agregar.Enabled = true;
                }
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _calendario.EliminarCalendario(id.Text);
                MostrarCalendario();
                limpiar();
                editar.Enabled = false;
                eliminar.Enabled = false;
                agregar.Enabled = true;
            }
        }
        public void limpiar() {
            id.Text = "";
            nombre.Text = "";
            descripcion.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre.Text = dataGridView1.CurrentRow.Cells["nombreActividad"].Value.ToString();
            descripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
            //fechaInicio.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FechaInicio"].Value.ToString());
            //fechaFin.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FechaFin"].Value.ToString());
            id.Text = dataGridView1.CurrentRow.Cells["idCalendarioActividades"].Value.ToString();
            editar.Enabled = true;
            eliminar.Enabled = true;
            agregar.Enabled = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar2.MinDate = monthCalendar1.SelectionRange.Start;
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            dsCalendario Ds = new dsCalendario();
            int filas = dataGridView1.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] { dataGridView1[0,i].Value.ToString(),
                    dataGridView1[1,i].Value.ToString(),
                    dataGridView1[2,i].Value.ToString(),
                    dataGridView1[3,i].Value.ToString(),
                    dataGridView1[4,i].Value.ToString(),
                    dataGridView1[5,i].Value.ToString(),});
            }
            Reportes r = new Reportes();
            r.setData(Ds);
            r.setReporte(9);
            DialogResult resultado = new DialogResult();
            resultado = r.ShowDialog();
            //r.Show();
        }
    }
}
