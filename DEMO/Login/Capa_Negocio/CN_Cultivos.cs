using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Cultivos
    {
        private CD_Cultivos _Cultivos = new CD_Cultivos();
        DataTable tablaCultivos = new DataTable();
        public DataTable MostrarCultivos(String cargo, String usuario)
        {
            tablaCultivos = _Cultivos.MostrarCultivos(cargo, usuario);
            return tablaCultivos;
        }
        public void AgregarCultivo(String Usuario_Cultivo, String Cultivo, String Fecha_Plantado, String Fecha_Cosecha, String Cantidad, String Estado)
        {
            _Cultivos.AgregarCultivo(Usuario_Cultivo, Cultivo, Fecha_Plantado, Fecha_Cosecha, Convert.ToString(Cantidad), Estado);
        }
        public void EliminarCultivo(String id)
        {
            _Cultivos.EliminarCultivo(id);
        }
        public void EditarCultivo(String IDcultivo,String Estado)
        {
            _Cultivos.EditarCultivo(IDcultivo,Estado);
        }
    }
}
