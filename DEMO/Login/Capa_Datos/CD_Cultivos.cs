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
    public class CD_Cultivos
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        MySqlDataReader leer;
        DataTable tablaCultivos = new DataTable();
        MySqlCommand comando;

        public DataTable MostrarCultivos(String cargo,String usuario)
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
            //if (cargo == "Admin")
            //{
            //    //comando.CommandText = "MostrarCultivos";
            //    comando.CommandText = "SELECT  cultivos.idCultivos,cultivos.fechaPlantado,cultivos.fechaCosechado,cultivos.cantidad,cultivos.estado,usuario.nombre,semillas.nombreSemilla " +
            //    "FROM cultivos " +
            //    "JOIN usuario ON cultivos.idUsuario = usuario.idUsuario "+
            //    "JOIN semillas ON cultivos.idSemillas = semillas.idSemillas";
            //}
            //else
            //    {
            comando.CommandText = "SELECT  cultivos.idCultivos,cultivos.fechaPlantado,cultivos.fechaCosechado,cultivos.cantidad,cultivos.estado,usuario.nombre,semillas.nombreSemilla " +
            "FROM cultivos " +
            "JOIN usuario ON cultivos.idUsuario = usuario.idUsuario " +
            "JOIN semillas ON cultivos.idSemillas = semillas.idSemillas ";
                //}
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tablaCultivos.Load(leer);
                conexion.CerrarConexion();
            return tablaCultivos;
        }
        public void AgregarCultivo(String Usuario_Cultivo,String Cultivo, String Fecha_Plantado,String Fecha_Cosecha,String Cantidad,String Estado)
        {
            MessageBox.Show(Cultivo);
            MessageBox.Show(Usuario_Cultivo);
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText =


                "INSERT into cultivos(idSemillas, idUsuario, fechaPlantado, fechaCosechado, cantidad, estado, cosechado)"+
                "VALUES"+
                "((select idsemillas from semillas where nombreSemilla = '"+Cultivo+"'),"+
                "(select idUsuario from usuario WHERE nickname = '"+Usuario_Cultivo+"'),"+
                "'"+Fecha_Plantado+"',"+
                "'"+Fecha_Cosecha+"',"+
                ""+Cantidad+","+
                "'"+Estado+"',"+
                "0"+
                ")";
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
                conexion.CerrarConexion();
        }
        public void EliminarCultivo(String IDCultivo)
        {
                int idCultivos = int.Parse(IDCultivo);

                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DELETE FROM cosechas WHERE idCultivos = '" + idCultivos + "';DELETE FROM cultivos WHERE idCultivos = '" + idCultivos + "';";
                comando.CommandType = CommandType.Text;
                comando.ExecuteReader();
                conexion.CerrarConexion();
        }

        public void EditarCultivo(String IDCultivo,String Estado)
        {
                comando = new MySqlCommand();
                comando.Connection = conexion.AbrirConexion();


            comando.CommandText = "UPDATE cultivos SET estado = "+"'"+Estado+"'"+" WHERE idCultivos = "+"'"+IDCultivo+"'"+";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteReader();
            conexion.CerrarConexion();
        }
    }
}
