using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Insecticidas
    {

        CD_Insecticidas _Insecticidas = new CD_Insecticidas();
        DataTable tablaInsecticida = new DataTable();

        public DataTable MostrarInsecticidas(String cargo, String usuario)
        {
            tablaInsecticida = _Insecticidas.MostrarInsecticidas(cargo, usuario);
            return tablaInsecticida;
        }

        public void AgregarInsecticida(String Usuario, String Nombre, String Precio, String Plaga,String Descripcion)
        {
            _Insecticidas.AgregarInsecticida(Usuario, Nombre,float.Parse(Precio),Convert.ToString(Plaga),Descripcion);
        }

        public void EditarInsecticida(String Nombre, String Precio, String Plaga, String idInsecticida, String Descripcion)
        {
            _Insecticidas.EditarInsecticida(Nombre,float.Parse(Precio),Plaga,Convert.ToInt32(idInsecticida), Descripcion);
        }

        public void EliminarInsecticida(String idInsecticida)
        {
            _Insecticidas.EliminarInsecticida(Convert.ToInt32(idInsecticida));
        }
    }
}
