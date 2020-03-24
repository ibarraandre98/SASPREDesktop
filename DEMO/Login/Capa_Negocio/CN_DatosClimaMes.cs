using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_DatosClimaMes
    {
        private CD_DatosClimaMes _DatosClimaMes = new CD_DatosClimaMes();
        DataTable tablaDatosClimaMes = new DataTable();
        DataTable tablaDatosClima = new DataTable();

        public void InsertarDatosClimaMes(String Estacion,String Fecha_Local,String Fecha_UTC, String Direccion_de_Viento, String Direccion_de_Rafaga,
            String Rapidez_de_Viento, String Rapidez_de_Rafaga, String Temperatura, String Humedad_Relativa, String Presion_Atmosferica,
            String Precipitacion, String Radiacion_Solar)
        {
            _DatosClimaMes.InsertarDatosClimaMes(Estacion,Fecha_Local,Fecha_UTC,Direccion_de_Viento, Direccion_de_Rafaga,
                Rapidez_de_Viento,Rapidez_de_Rafaga,Temperatura,
                Humedad_Relativa,Presion_Atmosferica,Precipitacion,Radiacion_Solar);
        }

        public DataTable MostrarDatosClimaMes()
        {
            tablaDatosClimaMes = _DatosClimaMes.MostrarDatosClimaMes();
            return tablaDatosClimaMes;
        }

        public DataTable MostrarAlarmaClima()
        {
            tablaDatosClima = _DatosClimaMes.MostrarAlarmaClima();
            return tablaDatosClima;
        }

        public void AgregarDiario(String fecha)
        {
            _DatosClimaMes.AgregarDiario(fecha);
        }
        public String top_fecha()
        {
            return _DatosClimaMes.top_fecha();
        }
    }
}
