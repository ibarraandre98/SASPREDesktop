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
        DataTable tablaCargo = new DataTable();
        DataTable tablaUsuarios = new DataTable();
        DataTable tablaEmpresas = new DataTable();

        public void RegistrarUsuario(String nombre, String apellidos, String contra, String cargo, String nickname, String correo,String empresa)
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO usuario (idCargo,idEmpresa,nombre,apellidos,contra,nickname,correo) VALUES (" +
                "(SELECT idCargo FROM cargo WHERE nombreCargo = '"+cargo+"')," +
                "(SELECT idEmpresa FROM empresa WHERE nombreEmpresa = '"+empresa+"')," +
                "'"+nombre+"'," +
                "'"+apellidos+"'," +
                "'"+contra+"'," +
                "'"+nickname+"'," +
                "'"+correo+"'" +
                ");";
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
                conexion.CerrarConexion();
        }

        public DataTable ObtenerContra(string correo)
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT contra FROM usuario WHERE correo = '"+correo+"' LIMIT 1;";
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tablaUsuarios.Load(leer);
                conexion.CerrarConexion();
            return tablaUsuarios;
        }

        public void EditarUsuario(int id, String nombre, String apellidos, String contra, String cargo, String nickname, String correo, String empresa)
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE usuario SET " +
                "idCargo = (SELECT idCargo FROM cargo WHERE nombreCargo = '" + cargo + "')," +
                "idEmpresa = (SELECT idEmpresa FROM empresa WHERE nombreEmpresa = '" + empresa + "')," +
                "nombre = '"+nombre+"'," +
                "apellidos = '"+apellidos+"'," +
                "contra = '"+contra+"'," +
                "nickname = '"+nickname+"'," +
                "correo = '"+correo+"' " +
                "WHERE idUsuario = "+id+";";
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
        }
        public void EliminarUsuario(int id)
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DELETE FROM usuario WHERE idUsuario = "+id+";";
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
                conexion.CerrarConexion();
        }

        public DataTable MostrarUsuarios()
        {
                var comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT usuario.idUsuario, " +
                "cargo.nombreCargo, " +
                "empresa.nombreEmpresa, " +
                "usuario.nombre, " +
                "usuario.apellidos, " +
                "usuario.contra," +
                "usuario.nickname, " +
                "usuario.correo " +
                "FROM usuario " +
                "INNER JOIN cargo ON usuario.idCargo = cargo.idCargo " +
                "INNER JOIN empresa ON usuario.idEmpresa = empresa.idEmpresa;";
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tablaUsuarios.Load(leer);
                conexion.CerrarConexion();
            return tablaUsuarios;
        }

        public DataTable MostrarEmpresas()
        {
            var comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT idEmpresa,nombreEmpresa FROM empresa;";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaEmpresas.Load(leer);
            conexion.CerrarConexion();
            return tablaEmpresas;
        }

        public DataTable MostrarCargo()
        {
            var comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT idCargo, nombreCargo FROM cargo;";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaCargo.Load(leer);
            conexion.CerrarConexion();
            return tablaCargo;
        }
    }
}
