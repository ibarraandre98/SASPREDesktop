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
                comando.CommandText = "MostrarPlaga";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tablaPlaga.Load(leer);
                conexion.CerrarConexion();
            return tablaPlaga;
        }

        public void AgregarPlaga(String cultivo, String Plaga,String fecha)
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "AgregarPlaga";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_Cultivo", cultivo);
                comando.Parameters.AddWithValue("_Nombre_Plaga", Plaga);
                comando.Parameters.AddWithValue("_FechaEncontrada", fecha);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
        }
    }
}
