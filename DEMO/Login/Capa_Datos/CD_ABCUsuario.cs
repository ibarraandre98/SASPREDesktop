using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class CD_ABCUsuario
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaUsuarios = new DataTable();

        public void RegistrarUsuario(String nombre, String apellidos, String contra, String cargo, String nickname, String correo)
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "RegistrarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_Nombre", nombre);
                comando.Parameters.AddWithValue("_Apellidos", apellidos);
                comando.Parameters.AddWithValue("_Contra", contra);
                comando.Parameters.AddWithValue("_Cargo", cargo);
                comando.Parameters.AddWithValue("_Nickname", nickname);
                comando.Parameters.AddWithValue("_Correo", correo);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
        }

        public DataTable ObtenerContra(string correo)
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ObtenerContra";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_Correo", correo);
                leer = comando.ExecuteReader();
                tablaUsuarios.Load(leer);
                conexion.CerrarConexion();
            return tablaUsuarios;
        }

        public void EditarUsuario(int id, String nombre, String apellidos, String contra, String cargo, String nickname, String correo)
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_Idusuario", id);
                comando.Parameters.AddWithValue("_Nombre", nombre);
                comando.Parameters.AddWithValue("_Apellidos", apellidos);
                comando.Parameters.AddWithValue("_Contra", contra);
                comando.Parameters.AddWithValue("_Cargo", cargo);
                comando.Parameters.AddWithValue("_Nickname", nickname);
                comando.Parameters.AddWithValue("_Correo", correo);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
        }
        public void EliminarUsuario(String NickName)
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_nickname", NickName);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
        }

        public DataTable MostrarUsuarios()
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "MostrarUsuarios";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tablaUsuarios.Load(leer);
                conexion.CerrarConexion();
            return tablaUsuarios;
        }
    }
}
