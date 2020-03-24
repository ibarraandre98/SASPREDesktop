using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Costos
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlCommand comando = new MySqlCommand();
        DataTable tablaCostos = new DataTable();
        DataTable tablaCultivo = new DataTable();

        MySqlDataReader leer;
        //Da de alta las alarmas a la base de datos
        public void InsertarCostos(String cultivo, double precio)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaCostos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_nombreCultivoCostos", cultivo);
            comando.Parameters.AddWithValue("_precioCultivoXtonelada", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Elimina Alarma 
        public void ELimiarCostos(String cultivo)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "bajaCostos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_nombreCultivoCostos", cultivo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Modifica una alarma
        public void ModificarCostos(String cultivo, double precio)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "cambioCostos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_nombreCultivoCostos", cultivo);
            comando.Parameters.AddWithValue("_precioCultivoXtonelada", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable MostrarCostos()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "verCostos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaCostos.Load(leer);
            conexion.CerrarConexion();

            return tablaCostos;
        }

        public DataTable MostrarCultivo()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "verCultivo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tablaCultivo.Load(leer);
            conexion.CerrarConexion();

            return tablaCultivo;
        }


    }
}
 
