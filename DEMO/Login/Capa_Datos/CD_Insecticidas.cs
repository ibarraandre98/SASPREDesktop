using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public class CD_Insecticidas
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaInsecticida = new DataTable();
        MySqlCommand comando;
        public DataTable MostrarInsecticidas(String cargo, String usuario)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            if (cargo == "Admin")
            {
                comando.CommandText = "MostrarInsecticida";
            }
            else
            {
                comando.CommandText = "MostrarInsecticidasUsuario";
                comando.Parameters.AddWithValue("_usuario", usuario);
            }
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaInsecticida.Load(leer);
            conexion.CerrarConexion();
            return tablaInsecticida;
        }

        public void AgregarInsecticida(String Usuario, String Nombre, int Precio, String Plaga)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarInsecticida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_usuario", Usuario);
            comando.Parameters.AddWithValue("_nombre", Nombre);
            comando.Parameters.AddWithValue("_precio", Precio);
            comando.Parameters.AddWithValue("_nombre_plaga", Plaga);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarInsecticida(int idInsecticida)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarInsecticida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_idinsecticida", idInsecticida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarInsecticida(String Nombre, int Precio, String Plaga, int idInsecticida)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarInsecticida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_nombre", Nombre);
            comando.Parameters.AddWithValue("_precio", Precio);
            comando.Parameters.AddWithValue("_nombre_plaga", Plaga);
            comando.Parameters.AddWithValue("_idinsecticida", idInsecticida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

