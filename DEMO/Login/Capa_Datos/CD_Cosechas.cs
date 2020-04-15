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

                    comando.CommandText = "SELECT cultivos.idCultivos,usuario.nombre,semillas.nombreSemilla,cultivos.fechaPlantado,cultivos.fechaCosechado,cultivos.cantidad FROM cosechas " +
                    "JOIN cultivos ON cosechas.idCultivos = cultivos.idCultivos " +
                    "JOIN semillas ON cultivos.idSemillas = semillas.idSemillas " +
                    "JOIN usuario ON cultivos.idUsuario = usuario.idUsuario " +
                    "WHERE cultivos.idUsuario = (SELECT idUsuario FROM usuario WHERE nickname = '" + usuario + "');";

                }
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tablaCosechas.Load(leer);
                conexion.CerrarConexion();
            return tablaCosechas;
        }

        public void AgregarCosechas(int idCultivo, float cantidad)
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO cosechas (idCultivos) VALUES('"+idCultivo+"');";
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
                conexion.CerrarConexion();

                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE cultivos SET cosechado = " + "'" + cantidad + "'" + " WHERE idCultivos = " + "'" + idCultivo + "'" + ";";
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
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
