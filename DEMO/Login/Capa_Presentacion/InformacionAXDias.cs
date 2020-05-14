using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    class InformacionAXDias
    {
        public double temperaturaprom { get; set; }
        public double humedad_relativaprom { get; set; }
        public double precipitacionprom { get; set; }
        public InformacionAXDias()
        {

        }
        public InformacionAXDias(DataTable tablaDatosClimaMes, String fechacultivo, int registros)
        {
            try { 
            var query = from row in tablaDatosClimaMes.AsEnumerable()
                        where row.Field<DateTime>("fechaLocal") >= Convert.ToDateTime(fechacultivo) && row.Field<DateTime>("fechaLocal") <= DateTime.Now
                        select row;


            //0.- Estacion, 1.- Fecha Local, 2.- Fecha UTC, 3.- Direccion del viento, 4.-Direccion de rafaga, 5.- Rapidez de viento, 
            //6.- Rapidez de rafaga, 7.- Temperatura, 8.- Humedad Relativa, 9.- Presion Atmosferica, 10.- Precipitacion, 11.- Radiacion Solar

            int cont = 0;
            if (query.Any())
            {
                DataTable resultados = query.CopyToDataTable();

                foreach (DataRow row in resultados.Rows)
                {
                    if (cont <= registros)
                    {
                        temperaturaprom += Convert.ToDouble(row[7].ToString());
                        humedad_relativaprom += Convert.ToDouble(row[8].ToString());
                        precipitacionprom += Convert.ToDouble(row[10].ToString());
                        cont++;
                    }
                    else
                    {
                        break;
                    }

                }
                temperaturaprom /= cont;
                humedad_relativaprom /= cont;
                precipitacionprom /= cont;
            }
            else
            {
            }
        }catch(Exception a){
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
