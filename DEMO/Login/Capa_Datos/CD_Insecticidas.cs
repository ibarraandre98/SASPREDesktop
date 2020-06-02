using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Datos
{
   public class CD_Insecticidas
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaInsecticida = new DataTable();
        MySqlCommand comando;
        public DataTable MostrarInsecticidas()
        {
            try
            {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();/*
                {
                    comando.CommandText = "SELECT insecticidas.idInsecticidas," +
                        "insecticidas.nombreInsecticida," +
                        "insecticidas.precio," +
                        "insecticidas.descripcion," +
                        "plagas.nombrePlaga FROM insecticidas " +
                        "INNER JOIN plagasinsecticidas ON insecticidas.idInsecticidas = plagasinsecticidas.idInsecticidas " +
                        "INNER JOIN plagas ON plagasinsecticidas.idPlagas = plagas.idPlagas;";
                }
                else
                {
                    comando.CommandText = "SELECT insecticidas.nombreInsecticida, insecticidas.precio, insecticidas.descripcion, plagas.nombrePlaga, usuario.nickname FROM insecticidas " +
                    "JOIN plagasinsecticidas ON insecticidas.idInsecticidas = plagasinsecticidas.idInsecticidas " +
                    "JOIN plagasfertilizantes ON plagasinsecticidas.idPlagas = plagasfertilizantes.idPlagas " +
                    "JOIN fertilizaciones ON plagasfertilizantes.idFertilizantes = fertilizaciones.idFertilizantes " +
                    "JOIN usuario ON fertilizaciones.idUsuario = usuario.idUsuario " +
                    "JOIN plagas ON plagasinsecticidas.idPlagas = plagas.idPlagas " +
                    "WHERE usuario.idUsuario = '" + usuario + "';";

                }*/

                comando.CommandText = "SELECT * from insecticidas";
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tablaInsecticida.Load(leer);
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ha ocurrido un error {e}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return tablaInsecticida;
        }

        public void AgregarInsecticida(String Nombre, String Precio, String Descripcion)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO insecticidas(nombreInsecticida, precio, descripcion) VALUES (" +
                "'" + Nombre + "', " +
                "'" + Precio + "', " +
                "'" + Descripcion + "');";                ;

            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void EliminarInsecticida(String idInsecticida)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM insecticidas WHERE idInsecticidas = '" + idInsecticida+ "';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        public void EditarInsecticida(String Nombre, String Precio, String idInsecticida, String Descripcion)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE insecticidas " +
                "SET nombreInsecticida = '" + Nombre +"', "+
                "precio = '" + Precio + "', " +
                "descripcion = '" + Descripcion + "' " +
                "WHERE idInsecticidas = '" + idInsecticida +"';";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }
    }
}

