using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Alarmas
    {
        DataTable tablaNombresCultivos = new DataTable();
        DataTable tablaNombresAlarmas = new DataTable();
        DataTable tablaAlarmas = new DataTable();
        DataTable tablaReportesAlarmas = new DataTable();
        private CD_Alarmas _Alarmas = new CD_Alarmas();

        public void InsertarAlarma(String nombreAlarma, String nombrePlanta, double tempMaxAlarma, double tempMinAlarma, int lapsoDias)
        {
            _Alarmas.InsertarAlarma(nombreAlarma, nombrePlanta, tempMaxAlarma, tempMinAlarma, lapsoDias);
        }

        public void EliminarAlarma(String nombreAlarma)
        {
            _Alarmas.EliminarAlarma(nombreAlarma);
        }

        public void ModificarAlarma(String nombreAlarma, String nombrePlanta, double tempMaxAlarma, double tempMinAlarma, int lapsoDias)
        {
            _Alarmas.ModificarAlarma(nombreAlarma, nombrePlanta, tempMaxAlarma, tempMinAlarma, lapsoDias);
        }

        public DataTable MostrarNombresCultivos()
        {
            tablaNombresCultivos = _Alarmas.MostrarNombreCultivos();
            return tablaNombresCultivos;
        }

        public DataTable MostrarAlarmas()
        {
            tablaAlarmas = _Alarmas.MostrarAlarmas();
            return tablaAlarmas;
        }

        public DataTable MostrarNombreAlarmas()
        {
            tablaNombresAlarmas = _Alarmas.MostrarNombreAlarmas();
            return tablaNombresAlarmas;
        }

        public void InsertarReportesAlarmas(String nombreAlarma, double temperaturaMaxima, double temperaturaMinima, String fechaInicio, String fechaFin, String fechaActivada, String alarmaActivada)
        {
            _Alarmas.InsertarReportesAlarmas(nombreAlarma, temperaturaMaxima, temperaturaMinima, fechaInicio, fechaFin, fechaActivada, alarmaActivada);
        }

        public DataTable MostrarReportesAlarmas()
        {
            tablaReportesAlarmas = _Alarmas.MostrarReportesAlarmas();

            return tablaReportesAlarmas;
        }
    }
}
