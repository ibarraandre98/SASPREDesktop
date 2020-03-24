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

        public void AgregarCosechas(String Usuario_Cultivo, String Cultivo, String Fecha_Plantado, String Fecha_Cosecha, String Cantidad, String Estado)
        {
            _Cosechas.AgregarCosechas(Usuario_Cultivo, Cultivo, Fecha_Plantado, Fecha_Cosecha, 
                Convert.ToString(Cantidad), Estado);
        }

        public void EditarCosechas(String id, String estado)
        {
            _Cosechas.EditarCosechas(id, estado);
        }
    }
}
