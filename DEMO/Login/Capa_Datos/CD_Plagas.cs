using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class CD_Plagas
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaPlaga = new DataTable();
        MySqlCommand comando;

        public DataTable MostrarPlaga()
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT historialplagas.idHistorialPlagas," +
                "semillas.nombreSemilla," +
                "plagas.nombrePlaga," +
                "historialplagas.fechaprediccion FROM historialplagas " +
                "INNER JOIN cultivos ON historialplagas.idCultivos = cultivos.idCultivos " +
                "INNER JOIN semillas ON cultivos.idSemillas = semillas.idSemillas " +
                "INNER JOIN plagas ON historialplagas.idPlagas = plagas.idPlagas;";
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tablaPlaga.Load(leer);
                conexion.CerrarConexion();
            return tablaPlaga;
        }

        public void AgregarPlaga(int IDCultivo, String Plaga,String fecha)
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO plagas (nombrePlaga) SELECT '" + Plaga + "' WHERE NOT EXISTS " +
                "(SELECT nombrePlaga FROM plagas WHERE nombrePlaga = '" + Plaga + "');" +
                "INSERT INTO historialplagas (idCultivos,idPlagas,fechaprediccion) VALUES" +
                "((SELECT idCultivos FROM cultivos WHERE idCultivos = "+IDCultivo+"),(SELECT idPlagas FROM plagas WHERE nombrePlaga = '"+Plaga+"'),'"+fecha+"')";
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
                conexion.CerrarConexion();
        }
    }
}
