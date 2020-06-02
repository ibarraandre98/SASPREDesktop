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
        public DataTable MostrarInsecticidas(String cargo, String usuario)
        {
            try
            {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                if (cargo == "Admin")
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
     "WHERE usuario.idUsuario = '" + usuario + "'; ";

                }
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

        public void AgregarInsecticida(String Usuario, String Nombre, float Precio, String Plaga,String Descripcion)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO plagas (nombrePlaga) SELECT '" + Plaga + "' WHERE NOT EXISTS (SELECT nombrePlaga FROM plagas WHERE nombrePlaga = '"+Plaga+"');" +
                "INSERT INTO insecticidas (nombreInsecticida,precio,descripcion) VALUES('"+Nombre+"',"+Precio+",'"+Descripcion+"');" +
                "INSERT INTO plagasinsecticidas (idPlagas,idInsecticidas) VALUES((SELECT idPlagas FROM plagas WHERE nombrePlaga = '"+Plaga+"')," +
                "(SELECT idInsecticidas FROM insecticidas WHERE nombreInsecticida = '"+Nombre+"'))";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }
        public void EliminarInsecticida(int idInsecticida)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM plagasinsecticidas WHERE idInsecticidas = "+idInsecticida+";" +
                "DELETE FROM insecticidas WHERE idInsecticidas = "+idInsecticida+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }

        public void EditarInsecticida(String Nombre, float Precio, String Plaga, int idInsecticida, String Descripcion)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE insecticidas SET nombreInsecticida = '"+Nombre+"'," +
                "precio = "+Precio+",descripcion = '"+Descripcion+"' WHERE idInsecticidas = "+idInsecticida+";" +
                "INSERT INTO plagas (nombrePlaga) SELECT '" + Plaga + "' WHERE NOT EXISTS (SELECT nombrePlaga FROM plagas WHERE nombrePlaga = '" + Plaga + "');" +
                "UPDATE plagasinsecticidas SET idPlagas = (SELECT idPlagas FROM plagas WHERE nombrePlaga = '"+Plaga+"') WHERE idInsecticidas = "+idInsecticida+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }
    }
}

