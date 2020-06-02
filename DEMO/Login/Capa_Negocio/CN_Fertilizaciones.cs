using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Fertilizaciones
    {
        DataTable tablaFertilizaciones = new DataTable();
        private CD_Fertilizaciones _CD_Fertilizaciones = new CD_Fertilizaciones();

        public DataTable MostrarFertilizaciones()
        {
            return _CD_Fertilizaciones.MostrarFertilizaciones();
        }

        public void AgregarFertilizaciones(String idCultivos, String idFertilizaciones, String idUsuario, String fecha)
        {
            _CD_Fertilizaciones.AgregarFertilizaciones(idCultivos, idFertilizaciones, idUsuario, fecha);
        }

        public void EliminarFertilizaciones(String idFertilizacion)
        {
            _CD_Fertilizaciones.EliminarFertilizaciones(Convert.ToInt32(idFertilizacion));
        }
    }
}
