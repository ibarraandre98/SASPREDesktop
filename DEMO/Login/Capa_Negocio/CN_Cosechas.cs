using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Cosechas
    {
        CD_Cosechas _Cosechas = new CD_Cosechas();
        DataTable tablaCosechas = new DataTable();

        public DataTable MostrarCosechas(String cargo,String usuario)
        {
            tablaCosechas = _Cosechas.MostrarCosechas(cargo,usuario);
            return tablaCosechas;
        }

        public void AgregarCosechas(int idCultivo,float cantidad)
        {
            _Cosechas.AgregarCosechas(idCultivo,cantidad);
            
        }

        public void EditarCosechas(String id, String estado)
        {
            _Cosechas.EditarCosechas(id, estado);
        }
    }
}
