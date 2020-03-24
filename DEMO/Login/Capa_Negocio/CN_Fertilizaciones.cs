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

        public void AgregarFertilizaciones(String cultivo, String necesitaNPK, String tieneNPK, String diaCalculado)
        {
            _CD_Fertilizaciones.AgregarFertilizaciones(cultivo, necesitaNPK, tieneNPK, diaCalculado);
        }
    }
}
