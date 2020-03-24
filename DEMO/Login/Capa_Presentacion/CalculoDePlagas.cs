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
    public partial class CalculoDePlagas : Form
    {
        DataGridView dgvDatosClimaMes = new DataGridView();
        DataTable tablaDatosClimaMes;
        public CalculoDePlagas()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CN_DatosClimaMes _DatosClimaMes = new CN_DatosClimaMes();
            
             tablaDatosClimaMes = _DatosClimaMes.MostrarDatosClimaMes();
            dgvDatosClimaMes.DataSource = tablaDatosClimaMes;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {



            var query = from row in tablaDatosClimaMes.AsEnumerable()
                        where row.Field<DateTime>("Fecha_Local") >= dateTimePicker1.Value && row.Field<DateTime>("Fecha_Local") <= dateTimePicker2.Value
                        select row;



            if (query.Any())
            {
                DataTable resultados = query.CopyToDataTable();

                foreach (DataRow item in resultados.Rows)
                {
                    MessageBox.Show(item[0].ToString()+ " " + item[1].ToString() + " " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString() + " " + item[5].ToString() + " " + item[6].ToString() + " " + item[7].ToString() + " " + item[8].ToString() + " " + item[9].ToString() + " " + item[10].ToString() + " " + item[11].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay resultados");
                
            }
            




            //DateTime FECHA1, FECHA2;
            //String fecha1 = dateTimePicker1.Value.ToString("yy/MM/dd");
            //String fecha2 = dateTimePicker2.Value.ToString("yy/MM/dd");
            //MessageBox.Show(fecha1);
            //double prom=0;
            //DateTime.TryParse(fecha1, out FECHA1);
            //DateTime.TryParse(fecha2, out FECHA2);
            //DataRow[] result = tablaDatosClimaMes.Select("Temperatura <= 19" );

            //foreach (DataColumn item in tablaDatosClimaMes.Columns)
            //{
            //    MessageBox.Show(item.ColumnName);
            //}
            //foreach (DataRow row in result)
            //{

            //    MessageBox.Show(Convert.ToDateTime(row[1].ToString()).ToString("yy/MM/dd"));
            //    MessageBox.Show(row[7].ToString());
            //    prom += Convert.ToDouble(row[7].ToString());
            //}
            //prom = prom / tablaDatosClimaMes.Rows.Count;
            //MessageBox.Show(prom.ToString());
        }
    }
}
