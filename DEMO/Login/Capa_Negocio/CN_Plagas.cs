using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Plagas
    {
        private CD_Plagas _Plagas = new CD_Plagas();
        DataTable tablaPlagas = new DataTable();

        public DataTable MostrarPlaga()
        {
            tablaPlagas = _Plagas.MostrarPlaga();
            return tablaPlagas;
        }

        public void AgregarPlagas(String IDCultivo, String Plaga, String fecha)
        {
            _Plagas.AgregarPlaga(Convert.ToInt32(IDCultivo),Plaga,fecha);
        }
    }
}
