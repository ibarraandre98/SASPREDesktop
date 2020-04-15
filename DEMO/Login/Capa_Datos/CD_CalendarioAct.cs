using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Capa_Datos
{
    public class CD_CalendarioAct
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaCalendario = new DataTable();
        MySqlCommand comando;
        public DataTable MostrarCalendario(String cargo, String usuario)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            if (cargo == "Admin")
            {
                comando.CommandText = "SELECT * FROM calendarioactividades;";
            }
            else
            {
                comando.CommandText = "SELECT * FROM calendarioactividades WHERE idUsuario = (SELECT idUsuario FROM usuario WHERE nickname = '"+usuario+"');";
            }
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaCalendario.Load(leer);
            conexion.CerrarConexion();
            return tablaCalendario;
        }
        
        public void AgregarCalendario(String Usuario_Calendario,String Nombre,String Descripcion,String FechaInicio,String FechaFin)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO calendarioactividades (idUsuario,nombreActividad,descripcion,fechaInicio,fechaFin) VALUES (" +
                "(SELECT idUsuario FROM usuario WHERE nickname = '"+Usuario_Calendario+"')," +
                "'"+Nombre+"'," +
                "'"+Descripcion+"'," +
                "'"+FechaInicio+"'," +
                "'"+FechaFin+"'" +
                ");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void EliminarCalendario(int idCalendario)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM calendarioactividades WHERE idCalendarioActividades = "+idCalendario+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        public void EditarCalendario(String Nombre,String Descripcion,String FechaInicio,String FechaFin, int idCalendario)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE calendarioactividades SET " +
                "nombreActividad = '"+Nombre+"'," +
                "descripcion = '"+Descripcion+"'," +
                "fechaInicio = '"+FechaInicio+"'," +
                "fechaFin = '"+FechaFin+"' " +
                "WHERE idCalendarioActividades = "+idCalendario+" ";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }
    }
}
