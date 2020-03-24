using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Alarmas
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlCommand comando = new MySqlCommand();
        DataTable tablaNombresCultivos = new DataTable();
        DataTable tablaNombresAlarmas = new DataTable();
        DataTable tablaAlarmas = new DataTable();
        DataTable tablaReportesAlarmas = new DataTable();
        MySqlDataReader leer;
        //Da de alta las alarmas a la base de datos
        public void InsertarAlarma(String nombreAlarma, String nombrePlanta, double tempMaxAlarma, double tempMinAlarma, int lapsoDias)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaAlarmaCultivos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_nombreAlarma", nombreAlarma);
            comando.Parameters.AddWithValue("_nombrePlanta", nombrePlanta);
            comando.Parameters.AddWithValue("_tempMaxAlarma", tempMaxAlarma);
            comando.Parameters.AddWithValue("_tempMinAlarma", tempMinAlarma);
            comando.Parameters.AddWithValue("_lapsoDias", lapsoDias);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Elimina Alarma 
        public void EliminarAlarma(String nombreAlarma)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "bajaAlarmaCultivos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_nombreAlarma", nombreAlarma);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Modifica una alarma
        public void ModificarAlarma(String nombreAlarma, String nombrePlanta, double tempMaxAlarma, double tempMinAlarma, int lapsoDias)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "cambioAlarmaCultivos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_nombreAlarma", nombreAlarma);
            comando.Parameters.AddWithValue("_nombrePlanta", nombrePlanta);
            comando.Parameters.AddWithValue("_tempMaxAlarma", tempMaxAlarma);
            comando.Parameters.AddWithValue("_tempMinAlarma", tempMinAlarma);
            comando.Parameters.AddWithValue("_lapsoDias", lapsoDias);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable MostrarNombreCultivos()
        {
            comando = new MySqlCommand("mostrarNombreCultivos",conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(tablaNombresCultivos);


            conexion.CerrarConexion();

            return tablaNombresCultivos;
        }

        public DataTable MostrarAlarmas()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarAlarmas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaAlarmas.Load(leer);
            conexion.CerrarConexion();

            return tablaAlarmas;
        }

        public DataTable MostrarNombreAlarmas()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarNombreAlarmas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaNombresAlarmas.Load(leer);
            conexion.CerrarConexion();

            return tablaNombresAlarmas;
        }

        public DataTable MostrarReportesAlarmas()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarReportesAlarmas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaReportesAlarmas.Load(leer);
            conexion.CerrarConexion();
            return tablaReportesAlarmas;
        }

        public void InsertarReportesAlarmas(String nombreAlarma, double temperaturaMaxima, double temperaturaMinima, String fechaInicio, String fechaFin, String fechaActivada, String alarmaActivada)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AltaReportesAlarmas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_nombreAlarma", nombreAlarma);
            comando.Parameters.AddWithValue("_temperaturaMaxima", temperaturaMaxima);
            comando.Parameters.AddWithValue("_temperaturaMinima", temperaturaMinima);
            comando.Parameters.AddWithValue("_fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("_fechaFin", fechaFin);
            comando.Parameters.AddWithValue("_fechaActivada", fechaActivada);
            comando.Parameters.AddWithValue("_alarmaActivada", alarmaActivada);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
