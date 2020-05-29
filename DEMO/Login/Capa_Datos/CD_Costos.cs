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
        public void InsertarCostos(String cultivo, double precio, String descripcion)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO costos (idSemillas,precio,descripcion) VALUES (" +
                "(SELECT idSemillas FROM semillas WHERE nombreSemilla = '"+cultivo+"')," +
                ""+precio+"," +
                "'"+descripcion+"'" +
                ");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        //Elimina Alarma 
        public void ELimiarCostos(String cultivo)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM costos WHERE idSemillas = (SELECT idSemillas FROM semillas WHERE nombreSemilla = '" + cultivo + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        //Modifica una alarma
        public void ModificarCostos(String cultivo, double precio, String descripcion)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE costos SET " +
                "precio = "+precio+"," +
                "descripcion = '"+descripcion+"' " +
                "WHERE idSemillas = (SELECT idSemillas FROM semillas WHERE nombreSemilla = '" + cultivo + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        public DataTable MostrarCostos()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT DISTINCT costos.idCostos," +
                "semillas.nombreSemilla, " +
                "costos.precio, " +
                "costos.descripcion " +
                "FROM costos " +
                "INNER JOIN semillas ON costos.idSemillas = semillas.idSemillas;";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaCostos.Load(leer);
            conexion.CerrarConexion();

            return tablaCostos;
        }

        public DataTable MostrarCultivo()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT cultivos.idCultivos," +
                "semillas.nombreSemilla," +
                "usuario.nombre," +
                "cultivos.fechaPlantado," +
                "cultivos.fechaCosechado," +
                "cultivos.cantidad," +
                "cultivos.estado," +
                "cultivos.cosechado" +
                " FROM cultivos " +
                "INNER JOIN semillas ON cultivos.idSemillas = semillas.idSemillas " +
                "INNER JOIN usuario ON cultivos.idUsuario = usuario.idUsuario;";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaCultivo.Load(leer);
            conexion.CerrarConexion();

            return tablaCultivo;
        }


    }
}
 
