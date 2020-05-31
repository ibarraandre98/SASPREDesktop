using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Fertilizaciones
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        MySqlCommand comando;
        DataTable tablaFertilizaciones = new DataTable();
        public DataTable MostrarFertilizaciones()
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT fertilizaciones.idFertilizaciones, " +
                "semillas.nombreSemilla," +
                "fertilizantes.nombreFertilizante, " +
                "usuario.nickname, " + 
                "fertilizaciones.fecha " +
                "FROM fertilizaciones " +
                "INNER JOIN cultivos ON fertilizaciones.idCultivos = cultivos.idCultivos " +
                "INNER JOIN semillas ON cultivos.idSemillas = semillas.idSemillas " +
                "INNER JOIN fertilizantes ON fertilizaciones.idFertilizantes = fertilizantes.idFertilizantes " +
                "INNER JOIN usuario ON fertilizaciones.idUsuario = usuario.idUsuario";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaFertilizaciones.Load(leer);
            conexion.CerrarConexion();
            return tablaFertilizaciones;
        }

        public void AgregarFertilizaciones(String cultivo, String necesitaNPK, String tieneNPK, String diaCalculado)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarFertilizaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_cultivo", cultivo);
            comando.Parameters.AddWithValue("_necesitaNPK", necesitaNPK);
            comando.Parameters.AddWithValue("_tieneNPK", tieneNPK);
            comando.Parameters.AddWithValue("_diaCalculado", diaCalculado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
