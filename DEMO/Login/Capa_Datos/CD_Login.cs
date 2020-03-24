using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Capa_Datos
{
    public class CD_Login
    {
        private CD_ConexionBD conexion = new CD_ConexionBD();
        private MySqlDataReader leer;
        MySqlCommand comando = new MySqlCommand();

        public MySqlDataReader IniciarSesion(String nickname, String contraseña)
        {
                conexion.CerrarConexion();
                comando.Parameters.Clear();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select * from usuario " +
                "join cargo on usuario.idCargo = cargo.idCargo " +
                " where nickname = '"+nickname + "' and contra = '"+contraseña+"'";
                comando.CommandType = CommandType.Text;
                
                leer = comando.ExecuteReader();

            return leer;
        }
    }
}
