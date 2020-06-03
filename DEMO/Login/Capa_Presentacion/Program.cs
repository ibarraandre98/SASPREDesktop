using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    static class Program
    {

        //Privilegios
        public static int IDADMINPRINCIPAL = 1;
        public static String cargo = null;
        public static String nickname = null;
        public static String contraseña = null;
        public static String nombre = null;
        public static String apellidos = null;
        public static String correo = null;
        public static String idusuario = null;


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new CalendarioAct());
            
        }
    }
}
