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
        public void InsertarAlarma(String nombreAlarma, String nombrePlanta, double tempMaxAlarma, double tempMinAlarma, int lapsoDias, String descripcion)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO alarmas (idSemillas,nombreAlarma,tempMaxAlarma,tempMinAlarma,lapsoDias,descripcion) VALUES (" +
                "(SELECT idSemillas FROM semillas WHERE nombreSemilla = '"+nombrePlanta+"'), " +
                "'"+nombreAlarma+"', " +
                ""+tempMaxAlarma+", " +
                ""+tempMinAlarma+", " +
                ""+lapsoDias+", " +
                "'"+descripcion+"'" +
                ");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        //Elimina Alarma 
        public void EliminarAlarma(int id)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM alarmas WHERE idAlarmas ="+id;
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        //Modifica una alarma
        public void ModificarAlarma(String nombreAlarma, String nombrePlanta, double tempMaxAlarma, double tempMinAlarma, int lapsoDias, String descripcion, int id)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE alarmas SET " +
                "idSemillas = (SELECT idSemillas FROM semillas WHERE nombreSemilla = '"+nombrePlanta+"')," +
                "nombreAlarma = '"+nombreAlarma+"'," +
                "tempMaxAlarma = "+tempMaxAlarma+", " +
                "tempMinAlarma = "+tempMinAlarma+", " +
                "lapsoDias = "+lapsoDias+"," +
                "descripcion = '"+descripcion+"' " +
                "WHERE idAlarmas = "+id+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        public DataTable MostrarNombreCultivos()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM semillas";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaNombresCultivos.Load(leer);
            conexion.CerrarConexion();

            conexion.CerrarConexion();

            return tablaNombresCultivos;
        }

        public DataTable MostrarAlarmas()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT alarmas.idAlarmas," +
                "semillas.nombreSemilla," +
                "alarmas.nombreAlarma," +
                "alarmas.tempMaxAlarma," +
                "alarmas.tempMinAlarma," +
                "alarmas.lapsoDias," +
                "alarmas.descripcion FROM alarmas " +
                "INNER JOIN semillas ON alarmas.idSemillas = semillas.idSemillas;";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaAlarmas.Load(leer);
            conexion.CerrarConexion();

            return tablaAlarmas;
        }

        public DataTable MostrarNombreAlarmas()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT nombreAlarma FROM alarmas;";
            comando.CommandType = CommandType.Text;
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
