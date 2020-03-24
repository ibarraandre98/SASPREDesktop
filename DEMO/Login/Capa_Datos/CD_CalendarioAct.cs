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
                comando.CommandText = "MostrarCalendario";
            }
            else
            {
                comando.CommandText = "MostrarCalendarioUsuarios";
                comando.Parameters.AddWithValue("nombre_usuario", usuario);
            }
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaCalendario.Load(leer);
            conexion.CerrarConexion();
            return tablaCalendario;
        }
        
        public void AgregarCalendario(String Usuario_Calendario,String Nombre,String Descripcion,String FechaInicio,String FechaFin)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarCalendario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("nombre_usuario", Usuario_Calendario);
            comando.Parameters.AddWithValue("nombre_actividad", Nombre);
            comando.Parameters.AddWithValue("descripcion_act", Descripcion);
            comando.Parameters.AddWithValue("fecha_inicio", FechaInicio);
            comando.Parameters.AddWithValue("fecha_fin", FechaFin);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarCalendario(String idCalendario)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCalendario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_calendario", idCalendario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarCalendario(String Nombre,String Descripcion,String FechaInicio,String FechaFin, String idCalendario)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCalendario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("nombre_actividad", Nombre);
            comando.Parameters.AddWithValue("descripcion_act", Descripcion);
            comando.Parameters.AddWithValue("fecha_inicio", FechaInicio);
            comando.Parameters.AddWithValue("fecha_fin", FechaFin);
            comando.Parameters.AddWithValue("id_calendario", idCalendario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
