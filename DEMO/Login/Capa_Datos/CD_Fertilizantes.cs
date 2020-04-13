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
    public class CD_Fertilizantes
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaCultivos = new DataTable();
        MySqlCommand comando;
        public DataTable MostrarFertilizantes()
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT fertilizantes.idFertilizantes," +
                "semillas.nombreSemilla," +
                "plagas.nombrePlaga," +
                "insecticidas.nombreInsecticida," +
                "insecticidas.descripcion," +
                "fertilizantes.nombreFertilizante," +
                "fertilizantes.dosis," +
                "fertilizantes.descripcionAplicacion FROM fertilizantes " +
                "INNER JOIN semillasfertilizantes ON fertilizantes.idFertilizantes = semillasfertilizantes.idFertilizantes " +
                "INNER JOIN semillas ON semillasfertilizantes.idSemillas = semillas.idSemillas " +
                "INNER JOIN plagasfertilizantes ON fertilizantes.idFertilizantes = plagasfertilizantes.idFertilizantes " +
                "INNER JOIN plagas ON plagasfertilizantes.idPlagas = plagas.idPlagas " +
                "INNER JOIN plagasinsecticidas ON plagas.idPlagas = plagasinsecticidas.idPlagas " +
                "INNER JOIN insecticidas ON plagasinsecticidas.idInsecticidas = insecticidas.idInsecticidas;";
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tablaCultivos.Load(leer);
                conexion.CerrarConexion();
            return tablaCultivos;
        }
    }
}
