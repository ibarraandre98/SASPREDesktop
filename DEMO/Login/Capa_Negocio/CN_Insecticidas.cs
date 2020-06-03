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

        public DataTable MostrarInsecticidas()
        {
           return _Insecticidas.MostrarInsecticidas();
        }

        public void AgregarInsecticida(String Nombre, String Precio,String Descripcion)
        {
            _Insecticidas.AgregarInsecticida(Nombre ,Precio ,Descripcion);
        }

        public void EditarInsecticida(String Nombre, String Precio, String idInsecticida, String Descripcion)
        {
            _Insecticidas.EditarInsecticida(Nombre, Precio, idInsecticida, Descripcion);
        }

        public void EliminarInsecticida(String idInsecticida)
        {
            _Insecticidas.EliminarInsecticida(idInsecticida);
        }
    }
}
