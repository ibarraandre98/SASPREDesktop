using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using MySql.Data.MySqlClient;

namespace Capa_Negocio
{
    public class CN_Almacen
    {
        DataTable tablaAlmacen = new DataTable();
        DataTable tablaBitacoraAlmacen = new DataTable();
        CD_Almacen _CD_Almacen = new CD_Almacen();
        public DataTable MostrarAlmacen(String cargo, String usuario)
        {
            return tablaAlmacen = _CD_Almacen.MostrarAlmacen(cargo,usuario);
        }

        public void AgregarAlmacen(String tipoObjeto, String nombreObjeto, String cantidadObjeto, String tipoSiembra, String precio, String fechaIngreso, String usuarioAlmacen)
        {
            _CD_Almacen.AgregarAlmacen(tipoObjeto, nombreObjeto, Convert.ToDouble(cantidadObjeto), tipoSiembra, Convert.ToDouble(precio), fechaIngreso, usuarioAlmacen);
        }

        public void EditarAlmacen(String IDAlmacen, String tipoObjeto, String nombreObjeto, String cantidadObjeto, String tipoSiembra, String precio, String fechaIngreso)
        {
            _CD_Almacen.EditarAlmacen(Convert.ToInt32(IDAlmacen), tipoObjeto, nombreObjeto, Convert.ToDouble(cantidadObjeto), tipoSiembra, Convert.ToDouble(precio), fechaIngreso);
        }

        public void BorrarAlmacen(String IDAlmacen)
        {
            _CD_Almacen.BorrarAlmacen(Convert.ToInt32(IDAlmacen));
        }

        public MySqlDataReader DisponibleCultivo(String cultivo)
        {
            return _CD_Almacen.DisponibleCultivo(cultivo);
        }

        public DataTable MostrarBitacoraAlmacen(String cargo, String usuario)
        {
            return tablaBitacoraAlmacen = _CD_Almacen.MostrarBitacoraAlmacen(cargo, usuario);
        }

        public void AgregarBitacoraAlmacen(String tipoObjeto, String nombreObjeto, String cantidadObjeto, String tipoSiembra, String precio, String fechaIngreso, String usuarioAlmacen)
        {
            _CD_Almacen.AgregarBitacoraAlmacen(tipoObjeto, nombreObjeto, Convert.ToDouble(cantidadObjeto), tipoSiembra, Convert.ToDouble(precio), fechaIngreso, usuarioAlmacen);
        }
    }
}
