using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Capa_Datos
{
    public class CD_Almacen
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaAlmacen = new DataTable();
        DataTable tablaBitacoraAlmacen = new DataTable();
        MySqlCommand comando;


        public DataTable MostrarAlmacen(String cargo, String usuario)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            if(cargo == "Admin")
            {
                comando.CommandText = "verAlmacen";
            }
            else
            {
                comando.CommandText = "verAlmacenUsuario";
                comando.Parameters.AddWithValue("_usuarioAlmacen",usuario);
            }
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaAlmacen.Load(leer);
            conexion.CerrarConexion();
            return tablaAlmacen;
        }

        public void AgregarAlmacen(String tipoObjeto, String nombreObjeto, double cantidadObjeto, String tipoSiembra, double precio, String fechaIngreso, String usuarioAlmacen)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaAlmacen";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_tipoObjeto", tipoObjeto);
            comando.Parameters.AddWithValue("_nombreObjeto", nombreObjeto);
            comando.Parameters.AddWithValue("_cantidadObjeto",cantidadObjeto);
            comando.Parameters.AddWithValue("_tipoSiembra", tipoSiembra);
            comando.Parameters.AddWithValue("_precio", precio);
            comando.Parameters.AddWithValue("_fechaIngreso", fechaIngreso);
            comando.Parameters.AddWithValue("_usuarioAlmacen", usuarioAlmacen);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarAlmacen(int IDAlmacen,String tipoObjeto, String nombreObjeto, double cantidadObjeto, String tipoSiembra, double precio, String fechaIngreso)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "cambioAlmacen";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_IDAlmacen", IDAlmacen);
            comando.Parameters.AddWithValue("_tipoObjeto", tipoObjeto);
            comando.Parameters.AddWithValue("_nombreObjeto", nombreObjeto);
            comando.Parameters.AddWithValue("_cantidadObjeto", cantidadObjeto);
            comando.Parameters.AddWithValue("_tipoSiembra", tipoSiembra);
            comando.Parameters.AddWithValue("_precio", precio);
            comando.Parameters.AddWithValue("_fechaIngreso", fechaIngreso);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void BorrarAlmacen(int IDAlmacen)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "bajaAlmacen";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_IDAlmacen", IDAlmacen);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public MySqlDataReader DisponibleCultivo(String cultivo)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT sum(cantidadObjeto) FROM almacen WHERE nombreObjeto = '"+cultivo+"'";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            return leer;
        }

        public DataTable MostrarBitacoraAlmacen(String cargo, String usuario)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            if (cargo == "Admin")
            {
                comando.CommandText = "verBitacoraAlmacen";
            }
            else
            {
                comando.CommandText = "verBitacoraAlmacenUsuario";
                comando.Parameters.AddWithValue("_usuarioAlmacen", usuario);
            }
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaBitacoraAlmacen.Load(leer);
            conexion.CerrarConexion();
            return tablaBitacoraAlmacen;
        }

        public void AgregarBitacoraAlmacen(String tipoObjeto, String nombreObjeto, double cantidadObjeto, String tipoSiembra, double precio, String fechaIngreso, String usuarioAlmacen)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaBitacoraAlmacen";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_tipoObjeto", tipoObjeto);
            comando.Parameters.AddWithValue("_nombreObjeto", nombreObjeto);
            comando.Parameters.AddWithValue("_cantidadObjeto", cantidadObjeto);
            comando.Parameters.AddWithValue("_tipoSiembra", tipoSiembra);
            comando.Parameters.AddWithValue("_precio", precio);
            comando.Parameters.AddWithValue("_fechaIngreso", fechaIngreso);
            comando.Parameters.AddWithValue("_usuarioAlmacen", usuarioAlmacen);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
