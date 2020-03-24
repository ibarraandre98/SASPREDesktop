using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Gráficos
    {
        DataTable tablaPoligono = new DataTable();
        CD_Gráficos CD_Gráficos = new CD_Gráficos();
        public DataTable MostrarGraficos(String cargo, String usuario)
        {
            return tablaPoligono = CD_Gráficos.MostrarPoligonos(cargo, usuario);
        }

        public void AgregarGraficos(string identificador, string latitud, string longitud, string color, string nombredelterreno, string usuario, string cultivo, string fechaplantado, string fechacosecha, string cantidad, string estado)
        {
            CD_Gráficos.AgregarPoligono(Convert.ToInt32(identificador), latitud, longitud, color, nombredelterreno, usuario, cultivo,fechaplantado,fechacosecha,Convert.ToDouble(cantidad),estado);
        }

        //public void EditarGraficos(String IDAlmacen, String tipoObjeto, String nombreObjeto, String cantidadObjeto, String tipoSiembra, String precio, String fechaIngreso)
        //{
        //    _CD_Almacen.EditarAlmacen(Convert.ToInt32(IDAlmacen), tipoObjeto, nombreObjeto, Convert.ToDouble(cantidadObjeto), tipoSiembra, Convert.ToDouble(precio), fechaIngreso);
        //}

        public int UltimoID()
        {
            return CD_Gráficos.ObtenerUltimoId();
        }

        public void BorrarGraficos(String Indentificador)
        {
            CD_Gráficos.BorrarPoligono(Convert.ToInt32(Indentificador));
        }

        public DataTable ObtenerPoligonosExistentes()
        {
            return CD_Gráficos.PoligonosExistentes();
        }

    }
}
