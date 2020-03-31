using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class CD_Cosechas
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaCosechas = new DataTable();
        MySqlCommand comando;
        
        public DataTable MostrarCosechas(String cargo,String usuario)
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                if (cargo == "Admin")
                {
                    //comando.CommandText = "MostrarCosechas";
                    comando.CommandText = "SELECT cultivos.idCultivos,cultivos.fechaPlantado,cultivos.fechaCosechado,cultivos.cantidad,semillas.nombreSemilla, usuario.nombre FROM cosechas "+
                    "JOIN cultivos ON cosechas.idCultivos = cultivos.idCultivos "+
                    "JOIN semillas ON cultivos.idSemillas = semillas.idSemillas " +
                    "JOIN usuario ON cultivos.idUsuario = usuario.idUsuario ";
                }
                else
                {
                    //Aqui falta  como buscar el usuario y pasarlo a su id y despues buscarlo en la tabla cultivos

                    //comando.CommandText = "MostrarCosechasUsuario";
                    //comando.Parameters.AddWithValue("_Usuario_Cultivo", usuario);
                    comando.CommandText = "SELECT cultivos.idCultivos,cultivos.idUsuario,cultivos.fechaPlantado,cultivos.fechaCosechado,cultivos.cantidad,semillas.nombreSemilla FROM cosechas "+
                    "JOIN cultivos ON cosechas.idCultivos = cultivos.idCultivos "+
                    "JOIN semillas ON cultivos.idSemillas = semillas.idSemillas "+
                    "WHERE cultivos.idUsuario = "+ usuario;
                    
                }
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tablaCosechas.Load(leer);
                conexion.CerrarConexion();
            return tablaCosechas;
        }

        public void AgregarCosechas(String Usuario_Cultivo, String Cultivo, String Fecha_Plantado, String Fecha_Cosecha, String Cantidad, String Estado)
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "AgregarCosechas";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_Usuario_Cultivo", Usuario_Cultivo);
                comando.Parameters.AddWithValue("_Cultivo", Cultivo);
                comando.Parameters.AddWithValue("_Fecha_Plantado", Fecha_Plantado);
                comando.Parameters.AddWithValue("_Fecha_Cosecha", Fecha_Cosecha);
                comando.Parameters.AddWithValue("_Cantidad", Cantidad);
                comando.Parameters.AddWithValue("_Estado", Estado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
        }

        public void EditarCosechas(String id,String Estado)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCosechas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_IDCultivo", id);
            comando.Parameters.AddWithValue("_Estado", Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
