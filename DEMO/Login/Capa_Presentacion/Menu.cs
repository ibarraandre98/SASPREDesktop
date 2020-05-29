using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO.Compression;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Globalization;
using Capa_Negocio;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Capa_Presentacion
{
   
    public partial class Menu : Form
    {
        ThreadStart delegado;
        Thread hilo;

        double climaActual;

        WebBrowser navegador = new WebBrowser();

        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        Label[] labelsDia, labelsFecha;

        private const String MON = "Monday";
        private const String TUE = "Tuesday";
        private const String WED = "Wednesday";
        private const String THU = "Thursday";
        private const String FRI = "Friday";
        private const String SAT = "Saturday";
        private const String SUN = "Sunday";

        private const String LUN = "Lunes";
        private const String MAR = "Martes";
        private const String MIE = "Miercoles";
        private const String JUE = "Jueves";
        private const String VIE = "Viernes";
        private const String SAB = "Sabado";
        private const String DOM = "Domingo";


        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public void cerrar()
        {
            AbrirFormEnPanel<Insecticidas>();
        }

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ExStyle |= 0x02000000;
                cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            try
            {
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                    return (enabled == 1) ? true : false;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    case WM_NCPAINT:
                        if (m_aeroEnabled)
                        {
                            var v = 2;
                            DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                            MARGINS margins = new MARGINS()
                            {
                                bottomHeight = 1,
                                leftWidth = 0,
                                rightWidth = 0,
                                topHeight = 0
                            }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                        }
                        break;
                    default: break;
                }
                base.WndProc(ref m);
                if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }


        DateTime fecha_hora;
        public Menu()
        {
            InitializeComponent();
            m_aeroEnabled = false;
            fecha_hora = DateTime.Now;
            labelsDia = new Label[] { labelDiaHoyNombre, labelDia1, labelDia2, labelDia3, labelDia4 };
            labelsFecha = new Label[] { labelHoy, labelFecha1, labelFecha2, labelFecha3, labelFecha4 };
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        public void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if(btnDatAtmos == true)
                {
                    panelDerecho.Visible = false;
                    btnDatAtmos = false;
                }
                else
                {
                    panelDerecho.Visible = true;
                }
                Form formulario;
                formulario = myPanel1.Controls.OfType<Forms>().FirstOrDefault();

                //si el formulario/instancia no existe, creamos nueva instancia y mostramos
                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    myPanel1.Controls.Add(formulario);
                    myPanel1.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                    formulario.Opacity = .5;
                    //  formulario.FormClosed += new FormClosedEventHandler(CloseForms);
                }
                else
                {

                    //si la Formulario/instancia existe, lo traemos a frente
                    formulario.BringToFront();

                    //Si la instancia esta minimizada mostramos
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }

                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void CerrarFormEnPanel<Forms>() where Forms : Form, new()
        {
            try
            {
                Form formulario = new Forms();
                formulario = myPanel1.Controls.OfType<Forms>().FirstOrDefault();

                if (!(formulario == null))
                {

                    formulario.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        CN_DatosClimaMes _DatosClimaMes = new CN_DatosClimaMes();

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                if (HayInternet() == true)
                {

                    panelDerecho.BackColor = Color.Transparent;
                    PrivilegioUsuario();
                    panelDerecho.BackColor = Color.FromArgb(0, 0, 0, 0);
                    labelFechaCompletaHoy.Text = DateTime.Now.ToLongDateString();
                    AgregarDias();
                    MostrarClima();
                    _DatosClimaMes.AgregarDiario(DateTime.Now.ToString("yy-MM-dd")); // Esto tira una excepcion y se tilda el programa, no poner nada debajo de esto, solo funciona 1 vez al día
                    bunifuFlatButton1_Click(null, e);
                    //navegador.ScriptErrorsSuppressed = true;
                    //navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.datos_cargados);
                    //navegador.Navigate("https://www.google.com/search?q=clima+ciudad+mante&rlz=1C1NHXL_esMX696MX697&oq=clima+ciudad+mante&aqs=chrome..69i57j69i60l2j0l3.4208j1j7&sourceid=chrome&ie=UTF-8");
                    //timerClima.Start();
                    //MostrarInformacionClima(); Es el metodo anterior

                }
                else
                {
                    MessageBox.Show("Compruebe su conexion a internet, no tendrá todas las funcionalidades");
                }

            }
            catch (MySqlException ex)
            {
                
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Reinicie el sistema no ha cargado el internet correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error" + a, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void AgregarDias()
        {
            // Hago el ciclo para agregar hasta 7 días
            for (int i = 1; i <= 5; i++)
            {
                // Este metodo solo pone en los labels el día que está en fecha_hora
                if (i != 1)
                    SetDateTime(labelsDia[i - 1], fecha_hora);
                PonerFechas(labelsFecha[i - 1], fecha_hora);
                // Cambia el DateTime fecha_hora a un día después.
                fecha_hora = fecha_hora.AddDays(1);
            }
        }
        private void MostrarClima()
        {
            obtenerDatosClimaHoy();
            obtenerDatosClima5Dias();
        }
        private void obtenerDatosClimaHoy()
        {
            ScrapperClima scrapper = new ScrapperClima();
            scrapper.obtenerDatosClimaHoy();

            List<String> nombre = new List<String>();
            List<String> temperatura = new List<String>();
            List<String> humedad = new List<String>();
            List<String> sensacion = new List<String>();
            List<String> climaToday = new List<String>();

            nombre = scrapper.nombre_ahora();
            //viento.Text = nombre.ElementAt(0);
            //visibilidad.Text = nombre.ElementAt(4);

            temperatura = scrapper.datos_ahora();
            //condensacion.Text = temperatura.ElementAt(2);
            //presion.Text = temperatura.ElementAt(3);

            humedad = scrapper.condensacion_nom();
            lblEstado.Text = humedad.ElementAt(1) + "%";

            sensacion = scrapper.sensacion_ahora();
            //sensacion.Text = sensacio.ElementAt(0);

            climaToday = scrapper.hoy_ahora();
            labelClimaHoy.Text = climaToday.ElementAt(0) + "° C";
            lblCentigrados.Text = climaToday.ElementAt(0) + "° Centigrados";
        }

        private void obtenerDatosClima5Dias()
        {
            ScrapperClima scrapper = new ScrapperClima();
            scrapper.obtenerDatosClima5dias();
            List<String> descripcion = new List<String>();
            List<String> temperatura = new List<String>();
            List<String> precipitacion = new List<String>();
            List<String> humedad = new List<String>();
            List<String> viento = new List<String>();
            List<String> sensacion = new List<String>();


            descripcion = scrapper.datos_descripcion();
            temperatura = scrapper.datos_temperatura();
            precipitacion = scrapper.datos_precipitacion();
            humedad = scrapper.datos_humedad();
            //viento = scrapper.datos_viento();

            this.picClimaHoy.Image = picClimaActual.Image = ObtenerImagenDesdeCodigo(descripcion.ElementAt(1), 1);
            
            this.picClima1.Image = ObtenerImagenDesdeCodigo(descripcion.ElementAt(2), 2);
            this.picClima2.Image = ObtenerImagenDesdeCodigo(descripcion.ElementAt(3), 3);
            this.picClima3.Image = ObtenerImagenDesdeCodigo(descripcion.ElementAt(4), 4);
            this.picClima4.Image = ObtenerImagenDesdeCodigo(descripcion.ElementAt(5), 5);
            lblDescripcion.Text = descripcion.ElementAt(1);
            descripcionDia1 = lblDescripcion.Text;
            descripcionDia2 = descripcion.ElementAt(2);
            descripcionDia3 = descripcion.ElementAt(3);
            descripcionDia4 = descripcion.ElementAt(4);
            descripcionDia5 = descripcion.ElementAt(5);
            //
            labelHoyMax.Text = temperatura.ElementAt(1).Split('/').ElementAt(0)+" C";
            labelHoyMin.Text = temperatura.ElementAt(1).Split('/').ElementAt(1) + " C";
            labelMax1.Text = temperatura.ElementAt(2).Split('/').ElementAt(0) + " C";
            labelMin1.Text = temperatura.ElementAt(2).Split('/').ElementAt(1) + " C";
            labelMax2.Text = temperatura.ElementAt(3).Split('/').ElementAt(0) + " C";
            labelMin2.Text = temperatura.ElementAt(3).Split('/').ElementAt(1) + " C";
            labelMax3.Text = temperatura.ElementAt(4).Split('/').ElementAt(0) + " C";
            labelMin3.Text = temperatura.ElementAt(4).Split('/').ElementAt(1) + " C";
            labelMax4.Text = temperatura.ElementAt(5).Split('/').ElementAt(0) + " C";
            labelMin4.Text = temperatura.ElementAt(5).Split('/').ElementAt(1) + " C";
            //
            labelPrecipitacionHoy.Text = precipitacion.ElementAt(1)+"%";
            lblPrecipitacionmm.Text = precipitacion.ElementAt(1) + "%";
            labelPrecipitacion1.Text = precipitacion.ElementAt(2) + "%";
            labelPrecipitacion2.Text = precipitacion.ElementAt(3) + "%";
            labelPrecipitacion3.Text = precipitacion.ElementAt(4) + "%";
            labelPrecipitacion4.Text = precipitacion.ElementAt(5) + "%";
            //
            //viento1.Text = viento2.ElementAt(2);
            //viento22.Text = viento2.ElementAt(3);
            //viento3.Text = viento2.ElementAt(4);
            //viento4.Text = viento2.ElementAt(5);
            //viento5.Text = viento2.ElementAt(6);
            //
            //humedad1.Text = humedad2.ElementAt(2);
            //humedad22.Text = humedad2.ElementAt(3);
            //humedad3.Text = humedad2.ElementAt(4);
            //humedad4.Text = humedad2.ElementAt(5);
            //humedad5.Text = humedad2.ElementAt(6);
        }

        private void MostrarInformacionClima()
        {
            MostrarTemperaturaMaxima();
            MostrarTemperaturaMinima();
            MostrarPrecipitaciones();
            MostrarDescripcionDia();
            MostrarInformacionHoy();
        }
        private const int TEMPERATURA_MINIMA_PERMITIDA = 5;
        private const int TEMPERATURA_MAXIMA_PERMITIDA = 40;

        private const string MAX_TEMP_WARNING = "Alerta: Temperatura mayor a 40 grados";
        private const string MIN_TEMP_WARNING = "Alerta: Temperatura menor a 5 grados";
        
        //DICE EL OSCAR QUE AUI SE SACAN LOS DATOS CLIMATOLOGICOS
        private void datos_cargados(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(navegador.Document.GetElementById("wob_tm").InnerText, out int grados);

                lblCentigrados.Text = grados + "° Centigrados";

                labelClimaHoy.Text = grados + "° C";

                if (grados >= TEMPERATURA_MAXIMA_PERMITIDA)
                {
                    lblAdvertencia.Text = MAX_TEMP_WARNING;
                }

                if (grados <= TEMPERATURA_MINIMA_PERMITIDA)
                {
                    lblAdvertencia.Text = MIN_TEMP_WARNING;
                }

                //foreach (HtmlElement etiqueta in navegador.Document.All)
                //{
                //    if (etiqueta.GetAttribute("Classname").Contains("vk_gy vk_sh wob-dtl"))
                //    {

                //        ktf.Kuto scrapper = new ktf.Kuto(etiqueta.InnerText);
                //        //precipitaciones: 
                //        //lblPrecipitacionmm.Text = scrapper.Extract("precipitaciones: ", "Humedad:").ToString();
                //        //lblEstado.Text = scrapper.Extract("Humedad: ", ".").ToString();

                //    }
                //}
            }
            catch (Exception)
            {
            }
            
        }
        private void MostrarInformacionHoy()
        {
            /*var temperaturaHoy = ScrapperCN.GetTemperaturaHoy();
            //MessageBox.Show(temperaturaHoy.ToString());
            var precipitacion = ScrapperCN.GetPrecipitation()["dia1"];
            var humedad = GetHumedad(precipitacion);
            var valorPrecipitacion = GetPrecipitacion(precipitacion);

            lblCentigrados.Text = temperaturaHoy.ToString() + "° Centigrados";
            lblPrecipitacionmm.Text = valorPrecipitacion;
            lblEstado.Text = humedad;*/

        }

        private void MostrarTemperaturaMaxima()
        {
            var maxTemperature = ScrapperCN.GetMaxTemperature();

            //Aqui truena cuando intento implementar el codigo----------------------------------
            labelHoyMax.Text = maxTemperature["dia1"] + "°C"; //Exactamente aqui
            labelMax1.Text = maxTemperature["dia2"] + "°C";
            labelMax2.Text = maxTemperature["dia3"] + "°C";
            labelMax3.Text = maxTemperature["dia4"] + "°C";
            labelMax4.Text = maxTemperature["dia5"] + "°C";
        }

        private void MostrarTemperaturaMinima()
        {
            var minTemperature = ScrapperCN.GetMinTemperature();

            labelHoyMin.Text = minTemperature["dia1"] + "°C";
            labelMin1.Text = minTemperature["dia2"] + "°C";
            labelMin2.Text = minTemperature["dia3"] + "°C";
            labelMin3.Text = minTemperature["dia4"] + "°C";
            labelMin4.Text = minTemperature["dia5"] + "°C";
        }

        private void MostrarPrecipitaciones()
        {
            var cero = "   0%\n0.0 mm";
            
            labelPrecipitacionHoy.Text = GetPrecipitationDayString(1);
            if (String.IsNullOrWhiteSpace(labelPrecipitacionHoy.Text)) labelPrecipitacionHoy.Text = cero;

            labelPrecipitacion1.Text = GetPrecipitationDayString(2);
            if (String.IsNullOrWhiteSpace(labelPrecipitacion1.Text)) labelPrecipitacion1.Text = cero;

            labelPrecipitacion2.Text = GetPrecipitationDayString(3);
            if (String.IsNullOrWhiteSpace(labelPrecipitacion2.Text)) labelPrecipitacion2.Text = cero;

            labelPrecipitacion3.Text = GetPrecipitationDayString(4);
            if (String.IsNullOrWhiteSpace(labelPrecipitacion3.Text)) labelPrecipitacion3.Text = cero;

            labelPrecipitacion4.Text = GetPrecipitationDayString(5);
            if (String.IsNullOrWhiteSpace(labelPrecipitacion4.Text)) labelPrecipitacion4.Text = cero;
        }

        private string GetPrecipitationDayString(int day)
        {
            string result = "";
            var gap = "   ";

            var precipitationsInformation = ScrapperCN.GetPrecipitation();

            var precipitationDay = precipitationsInformation[$"dia{day}"];

            if (precipitationDay.Contains('%'))
            {
                var precipitationDayInformation = precipitationDay.Split(' ');

                var precipitationPercentageDay = precipitationDayInformation[0];
                if (String.IsNullOrEmpty(precipitationPercentageDay)) precipitationPercentageDay = "0%";

                var precipitationMmDay = precipitationDayInformation[1];
                if (String.IsNullOrWhiteSpace(precipitationMmDay)) precipitationMmDay = "0.0 mm";

                result += gap + precipitationPercentageDay + "\n\r" + precipitationMmDay + " mm";

                if(day == 1)
                {
                    lblPrecipitacionmm.Text = precipitationMmDay + " mm";
                    lblEstado.Text = precipitationPercentageDay;
                }
                    

                return result;
            }

            result += precipitationDay;

            return result;
        }

        private string GetHumedad(string precipitacion)
        {
            if (precipitacion.Contains('%'))
            {
                var precipitationDayInformation = precipitacion.Split(' ');

                var humedad = precipitationDayInformation[0].ToString();

                var result = humedad;

                return result;
            }

            return "";
        }

        private string GetPrecipitacion(string precipitacion)
        {

            if (precipitacion.Contains('%'))
            {
                var precipitationDayInformation = precipitacion.Split(' ');

                var valorPrecipitacion = precipitationDayInformation[1];

                var result = valorPrecipitacion + " mm";

                return result;
            }
            return "";
        }

        private string descripcionDia1;
        private string descripcionDia2;
        private string descripcionDia3;
        private string descripcionDia4;
        private string descripcionDia5;

        private void MostrarDescripcionDia()
        {
            var descriptions = ScrapperCN.GetDescription();

            var infoDay1 = descriptions["dia1"].Split(':');
            var infoDay2 = descriptions["dia2"].Split(':');
            var infoDay3 = descriptions["dia3"].Split(':');
            var infoDay4 = descriptions["dia4"].Split(':');
            var infoDay5 = descriptions["dia5"].Split(':');

            this.picClimaHoy.Image = picClimaActual.Image =  ObtenerImagenDesdeCodigo(infoDay1[0], 1);
            this.picClima1.Image = ObtenerImagenDesdeCodigo(infoDay2[0], 2);
            this.picClima2.Image = ObtenerImagenDesdeCodigo(infoDay3[0], 3);
            this.picClima3.Image = ObtenerImagenDesdeCodigo(infoDay4[0], 4);
            this.picClima4.Image = ObtenerImagenDesdeCodigo(infoDay5[0], 5);

            descripcionDia1 = lblDescripcion.Text = infoDay1[1];
            descripcionDia2 = infoDay2[1];
            descripcionDia3 = infoDay3[1];
            descripcionDia4 = infoDay4[1];
            descripcionDia5 = infoDay5[1];

        }

        private void PonerFechas(Label lbl, DateTime datetime)
        {
            try
            {
                lbl.Text = datetime.ToString("M");
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void SetDateTime(Label lbl, DateTime datetime)
        {
            try
            {
                lbl.Text = TranslateDay(datetime.DayOfWeek.ToString());
                //lbl.Text = "Fecha: " + datetime.ToShortDateString() + ", Hora: " + datetime.ToLongTimeString();
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private String TranslateDay(String day)
        {
            try
            {

                if (day.Equals(MON)) return LUN;
                if (day.Equals(TUE)) return MAR;
                if (day.Equals(WED)) return MIE;
                if (day.Equals(THU)) return JUE;
                if (day.Equals(FRI)) return VIE;
                if (day.Equals(SAT)) return SAB;
                if (day.Equals(SUN)) return DOM;
                if (day.Equals(MON)) return LUN;
                if (day.Equals(MON)) return LUN;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return $"{day} NOT A DAY";

        }

        bool mnuExpanded = false;
        private void MouseDetect_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                //if (!bunifuTransition1.IsCompleted) return;
                if (myPanel2.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                {
                    if (!mnuExpanded)
                    {
                        mnuExpanded = true;
                        myPanel2.Width = 250;
                    }
                }
                else
                {
                    if (mnuExpanded)
                    {
                        mnuExpanded = false;
                        //   myPanel2.Visible = false;
                        myPanel2.Width = 45;
                        myPanel2.Visible = true;
                        // bunifuTransition1.ShowSync(myPanel2);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        Thread th;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                panelDerecho.BackColor = Color.Transparent;
                Cursor.Current = Cursors.WaitCursor;
                Login log = new Login();
                log.Show();
                Cursor.Current = Cursors.Default;
                this.Hide();
            }

                
        }
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<HistorialDePlagas>();

            panelClima.Visible = false;
            lblTemp.Visible = true;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
        }
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            panelClima.Visible = false;
            lblTemp.Visible = true;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
        }
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Cultivos>();
            panelClima.Visible = false;
            lblTemp.Visible = true;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
        }
        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            lblTemp.Visible = true;
            panelClima.Visible = false;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
        }
        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            lblTemp.Visible = true;
            panelClima.Visible = false;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
        }
        private void panelDerecho_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblEstado_Click(object sender, EventArgs e)
        {

        }
        public void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            panelDerecho.BackColor = Color.Transparent;
            CerrarFormEnPanel<Cultivos>();
            CerrarFormEnPanel<HistorialDePlagas>();
            CerrarFormEnPanel<FromUsuarioABC>();
            CerrarFormEnPanel<Fertilizantes>();
            CerrarFormEnPanel<Datos_Atmosfericos>();
            CerrarFormEnPanel<Cosechas>();
            CerrarFormEnPanel<Ventas>();
            CerrarFormEnPanel<Almacen>();
            CerrarFormEnPanel<Gastos>();
            CerrarFormEnPanel<Alarmas>();
            CerrarFormEnPanel<Insecticidas>();
            CerrarFormEnPanel<Gráficos>();

            panelDerecho.Visible = true;
            panelClima.Visible = true;
            lblTemp.Visible = false;
            lblCentigrados.Visible = false;
            lblHumedad.Visible = false;
            lblEstado.Visible = false;
            lblPrecipitacion.Visible = false;
            lblPrecipitacionmm.Visible = false;
            //ActivarAlarmas();



            //ActivarAlarmas(); Arreglar este
            Cursor.Current = Cursors.Default;
        }
        private void myPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PrivilegioUsuario()
        {
            if (Program.cargo != "Admin")
            {
                btnAdministrarUsuarios.Visible = false;
            }
        }
        private void bunifuFlatButton10_Load(object sender, EventArgs e)
        {

        }
        async void GetRequestHora()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                String url = "https://smn.cna.gob.mx/webservices/index.php?method=3";
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(url)) //obtener una variable con la info del url
                using (var content = await response.Content.ReadAsStreamAsync()) //obtener la info del archivo
                using (var descomprimido = new GZipStream(content, CompressionMode.Decompress)) //descomprimir el archivo
                {
                    if (response.IsSuccessStatusCode)
                    {
                        StreamReader reader = new StreamReader(descomprimido);
                        String data = reader.ReadLine();
                        var listInfo = JsonConvert.DeserializeObject<List<Ciudad>>(data);
                        foreach (var info in listInfo)
                        {
                            if (info.CityId.Equals("MXTS2043") && info.HourNumber == 0)
                            {
                                labelClimaHoy.Text = info.TempC.ToString() + "° C";
                            }
                        }
                    }
                }
                Cursor = Cursors.Default;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        async void GetRequestDia()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                String url = "https://smn.cna.gob.mx/webservices/index.php?method=1";
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(url)) //obtener una variable con la info del url
                using (var content = await response.Content.ReadAsStreamAsync()) //obtener la info del archivo
                using (var descomprimido = new GZipStream(content, CompressionMode.Decompress)) //descomprimir el archivo
                {
                    if (response.IsSuccessStatusCode)
                    {
                        StreamReader reader = new StreamReader(descomprimido);
                        String data = reader.ReadLine();
                        var listInfo = JsonConvert.DeserializeObject<List<CiudadDia>>(data);
                        var iteracion = 0;
                        var diasSiguientes = false;
                        foreach (var info in listInfo)
                        {
                            if (info.CityId.Equals("MXTS2043") && DateTime.ParseExact(info.LocalValidDate.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToLongDateString().Equals(DateTime.Now.ToLongDateString()))
                            {
                                if (iteracion == 0)
                                {
                                    labelFechaCompletaHoy.Text = DateTime.ParseExact(info.LocalValidDate.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToLongDateString();
                                    labelHoy.Text = DateTime.Now.ToString("m");
                                    ktf.Kuto scrap = new ktf.Kuto(DateTime.Now.ToString("m"));
                                    string mes = scrap.Extract("de ", "").ToString();
                                    labelHoy.Text = mes;
                                    //MessageBox.Show(mes+" lol");
                                    labelHoyMax.Text = info.HiTempC + "°";
                                    labelHoyMin.Text = info.LowTempC + "°";
                                    labelPrecipitacionHoy.Text = info.ProbabilityOfPrecip + "%";
                                    picClimaHoy.Image = vectorClima(info.SkyText, 0);
                                    iteracion++;
                                    diasSiguientes = true;
                                }
                            }
                            else if (info.CityId.Equals("MXTS2043") && diasSiguientes == true)
                            {
                                if (iteracion == 1)
                                {
                                    labelFecha1.Text = DateTime.Now.ToString("m");
                                    //labelFecha1Max.Text = info.HiTempC + "°";
                                    //labelFecha1Min.Text = info.LowTempC + "°";
                                    labelPrecipitacion1.Text = info.ProbabilityOfPrecip + "%";
                                    picClima1.Image = vectorClima(info.SkyText, 0);
                                    iteracion++;
                                }
                                else if (iteracion == 2)
                                {
                                    labelFecha2.Text = DateTime.Now.ToString("m");
                                    labelFecha2Max.Text = info.HiTempC + "°";
                                    labelFecha2Min.Text = info.LowTempC + "°";
                                    labelPrecipitacion2.Text = info.ProbabilityOfPrecip + "%";
                                    picClima2.Image = vectorClima(info.SkyText, 0);
                                    iteracion++;
                                }
                                else if (iteracion == 3)
                                {
                                    labelFecha3.Text = DateTime.Now.ToString("m");
                                    labelMax3.Text = info.HiTempC + "°";
                                    labelMin3.Text = info.LowTempC + "°";
                                    labelPrecipitacion3.Text = info.ProbabilityOfPrecip + "%";
                                    picClima3.Image = vectorClima(info.SkyText, 0);
                                    iteracion++;
                                }
                                else if (iteracion == 4)
                                {
                                    labelFecha4.Text = DateTime.Now.ToString("m");
                                    labelFecha4Max.Text = info.HiTempC + "°";
                                    labelFecha4Min.Text = info.LowTempC + "°";
                                    labelPrecipitacion4.Text = info.ProbabilityOfPrecip + "%";
                                    picClima4.Image = vectorClima(info.SkyText, 0);
                                    iteracion++;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void ObtenerDias()
        {


        }
        //Actualiza el clima cada hora
        private void timerClima_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DateTime.Now.Minute.ToString()) == 00 && Convert.ToInt32(DateTime.Now.Second.ToString()) == 0)
            {
                MostrarClima();
                //AlarmaPorHora(); Arreglar
            }
            //navegador.Navigate("https://www.google.com/search?q=clima+ciudad+mante&rlz=1C1NHXL_esMX696MX697&oq=clima+ciudad+mante&aqs=chrome..69i57j69i60l2j0l3.4208j1j7&sourceid=chrome&ie=UTF-8");
        }

        public Image vectorClima(String texto, int panel)
        {
            try
            {
                // Nublado -> d400
                if (texto.Equals("d400") && panel == 0)
                {
                    return Vectores.Images[11];
                }
                else if (texto.Equals("Parcialmente nublado / Viento") && panel == 0)
                {
                    return Vectores.Images[15];
                }
                // Parcialmente nublado --> d200
                else if (texto.Equals("d200") && panel == 0)
                {
                    return Vectores.Images[15];
                }
                else if (texto.Equals("Aguaceros en la mañana") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                // Soleado -> d000
                else if (texto.Equals("d000") && panel == 0)
                {
                    return Vectores.Images[17];
                }
                else if (texto.Equals("Nubes por la mañana / Sol por la tarde") && panel == 0)
                {
                    return Vectores.Images[15];
                }
                else if (texto.Equals("Lluvia en la mañana") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                // Mayormente soleado / Viento --> d100
                else if (texto.Equals("d100") && panel == 0)
                {
                    return Vectores.Images[17];
                }
                else if (texto.Equals("Tormentas por la tarde") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Tormentas aisladas") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Tormentas dispersas") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Tormentas") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Tormentas en la mañana") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                // Aguaceros por la tarde --> d210
                else if (texto.Equals("d210") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Aguaceros") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Algunos aguaceros") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Lluvia débil por la tarde") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Lluvia por la tarde") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                // Aguaceros y tormentas por la tarde --> d240
                else if (texto.Equals("d240") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Soleado / Viento") && panel == 0)
                {
                    return Vectores.Images[17];
                }
                else if (texto.Equals("Aguaceros y tormentas") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Lluvia") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else if (texto.Equals("Nublado / Viento") && panel == 0)
                {
                    return Vectores.Images[11];
                }
                // Mayormente nublado / viento -> d300
                else if (texto.Equals("d300") && panel == 0)
                {
                    return Vectores.Images[11];
                }
                else if (texto.Equals("Nubes por la mañana / Sol por la tarde / Viento") && panel == 0)
                {
                    return Vectores.Images[15];
                }
                else if (texto.Equals("Tormentas aisladas / Viento") && panel == 0)
                {
                    return Vectores.Images[2];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            /*         
            Nublado
            Parcialmente nublado / Viento
            Parcialmente nublado
            Aguaceros en la mañana
            Soleado
            Nubes por la mañana / Sol por la tarde
            Lluvia en la mañana
            Mayormente soleado / Viento
            Tormentas por la tarde
            Tormentas aisladas
            Tormentas dispersas
            Tormentas
            Tormentas en la mañana
            Aguaceros por la tarde
            Aguaceros
            Algunos aguaceros
            Lluvia débil por la tarde
            Lluvia por la tarde
            Aguaceros y tormentas por la tarde
            Soleado / Viento
            Aguaceros y tormentas
            Lluvia
            Nublado / Viento
            Mayormente nublado/ Viento
            Nubes por la mañana / Sol por la tarde / Viento
            Tormentas aisladas / Viento
            */
        }

        public Image ObtenerImagenDesdeCodigo(String texto, int dayPictureBox)
        {
            try
            {
                // case 1 = Primer panel, este debe ser blanco de perefencia, sino color.
                // case 2 y 3 = Segundo y tercer panel, estos deben ser negros.
                // case 4 y 5 = Cuarto y quinto panel, estos a color de preferencia, sino blanco.
                switch (dayPictureBox)
                {
                    case 1:
                        // Parcialmente nuboso, posibilidad de tormentas y lluvia | Tormentas
                        if (texto.Equals("Tormentas") || texto.Equals("Tormentas") || texto.Contains("Lluvia") || texto.Contains("lluvia") || texto.Equals("Tormentas matinales"))  return Vectores.Images[18];
                        else if (texto.Equals("Tormentas en la madrugada") || texto.Equals("Tormentas por la tarde")) return Vectores.Images[18];

                        // Algunas nubes | Algunas nubes
                        else if (texto.Equals("Parcialmente nublado") || texto.Equals("Nubes por la mañana / Sol por la tarde")) return Vectores.Images[14];
                        else if (texto.Equals("d200") || texto.Equals("n200")) return Vectores.Images[14];

                        // Parcialmente nublado, lluvia ligera
                        if (texto.Equals("") || texto.Equals("n210")) return Vectores.Images[0];
                        else if (texto.Equals("d220") || texto.Equals("n220")) return Vectores.Images[0];

                        // Nublado
                        else if (texto.Equals("Nublado") || texto.Equals("Mayormente nublado")) return Vectores.Images[9];

                        // Despejado
                        else if (texto.Equals("Mayormente soleado") || texto.Equals("Soleado") || texto.Contains("Despejado") || texto.Contains("despejado")) return Vectores.Images[16];

                        // Nublado, lluvia ligera
                        if (texto.Equals("Tormentas dispersas") || texto.Equals("Tormentas aisladas") || texto.Equals("Chubascos por la tarde") || texto.Equals("Chubascos por la mañana") || texto.Equals("Chubascos por la noche") || texto.Equals("Chubascos") || texto.Equals("Chubascos matinales") || texto.Contains("Chubascos")) return Vectores.Images[3];
                        else if (texto.Equals("d320") || texto.Equals("3220")) return Vectores.Images[3];

                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        // Parcialmente nuboso, posibilidad de tormentas y lluvia | Tormentas
                        if (texto.Equals("Tormentas") || texto.Equals("n240") || texto.Contains("Lluvia") || texto.Contains("lluvia") || texto.Equals("Tormentas matinales")) return Vectores.Images[20];
                        else if (texto.Equals("Tormentas en la madrugada") || texto.Equals("Tormentas por la tarde")) return Vectores.Images[20];

                        // Algunas nubes | Algunas nubes
                        else if (texto.Equals("Parcialmente nublado") || texto.Equals("Nubes por la mañana / Sol por la tarde")) return Vectores.Images[15];
                        else if (texto.Equals("d200") || texto.Equals("n200")) return Vectores.Images[15];

                        // Parcialmente nublado, lluvia ligera
                        if (texto.Equals("") || texto.Equals("n210")) return Vectores.Images[2];
                        else if (texto.Equals("d220") || texto.Equals("n220")) return Vectores.Images[2];

                        // Nublado
                        else if (texto.Equals("Nublado") || texto.Equals("Mayormente nublado")) return Vectores.Images[11];

                        // Despejado
                        else if (texto.Equals("Mayormente soleado") || texto.Equals("Soleado") || texto.Contains("Despejado") || texto.Contains("despejado")) return Vectores.Images[17];

                        // Nublado, lluvia ligera
                        if (texto.Equals("Tormentas dispersas") || texto.Equals("Tormentas aisladas") || texto.Equals("Chubascos por la tarde") || texto.Equals("Chubascos por la mañana") || texto.Equals("Chubascos por la noche") || texto.Equals("Chubascos") || texto.Equals("Chubascos matinales") || texto.Contains("Chubascos")) return Vectores.Images[5];
                        else if (texto.Equals("d320") || texto.Equals("3220")) return Vectores.Images[5];

                        break;
                }
                
            }
            catch(Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            return null;
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel<FromUsuarioABC>();


                lblTemp.Visible = true;
                panelClima.Visible = false;
                lblCentigrados.Visible = true;
                lblHumedad.Visible = true;
                lblEstado.Visible = true;
                lblPrecipitacion.Visible = true;
                lblPrecipitacionmm.Visible = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void btnAdministrarCosechas_Click(object sender, EventArgs e)
        {
            panelDerecho.Visible = true;
            AbrirFormEnPanel<Cosechas>();


            panelClima.Visible = false;
            lblTemp.Visible = true;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
        }
        bool btnDatAtmos;

        private void btnFertilizantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Fertilizantes>();

            panelClima.Visible = false;
            lblTemp.Visible = true;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
        }

        private void picClimaHoy_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(picClimaHoy, descripcionDia1);
        }

        private void picClima1_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(picClima1, descripcionDia2);
        }

        private void picClima2_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(picClima2, descripcionDia3);
        }

        private void picClima3_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(picClima3, descripcionDia4);
        }

        private void picClima4_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(picClima4, descripcionDia5);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //btnDatAtmos = true;
            AbrirFormEnPanel<Datos_Atmosfericos>();
            panelClima.Visible = false;

            lblTemp.Visible = true;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
            //Datos_Atmosfericos datos = new Datos_Atmosfericos();
            //datos.Visible = true;

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Fertilizaciones>();
            lblTemp.Visible = true;
            panelClima.Visible = false;
            lblCentigrados.Visible = true;
            lblHumedad.Visible = true;
            lblEstado.Visible = true;
            lblPrecipitacion.Visible = true;
            lblPrecipitacionmm.Visible = true;
           
            }

        private void panelClima_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                panelDerecho.BackColor = Color.Transparent;
                Cursor.Current = Cursors.WaitCursor;
                Login log = new Login();
                log.Show();
                Cursor.Current = Cursors.Default;
                this.Hide();
            }

            
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRest.Visible = true;
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMax.Visible = true;
        }

        private void picClimaActual_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(picClimaActual, descripcionDia1);
        }

        private void BunifuFlatButtonAlmacen_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel<Almacen>();

                lblTemp.Visible = true;
                panelClima.Visible = false;
                lblCentigrados.Visible = true;
                lblHumedad.Visible = true;
                lblEstado.Visible = true;
                lblPrecipitacion.Visible = true;
                lblPrecipitacionmm.Visible = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BunifuFlatButtonGastos_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel<Gastos>();


                lblTemp.Visible = true;
                panelClima.Visible = false;
                lblCentigrados.Visible = true;
                lblHumedad.Visible = true;
                lblEstado.Visible = true;
                lblPrecipitacion.Visible = true;
                lblPrecipitacionmm.Visible = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BunifuFlatButtonVentas_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel<Ventas>();


                lblTemp.Visible = true;
                panelClima.Visible = false;
                lblCentigrados.Visible = true;
                lblHumedad.Visible = true;
                lblEstado.Visible = true;
                lblPrecipitacion.Visible = true;
                lblPrecipitacionmm.Visible = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Ha ocurrido un error " + a.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Gráficos>();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<CalendarioAct>();
        }

        private void btnAlarmas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Alarmas>();

        }

        private bool HayInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnCostos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Costos>();
        }

        private void AlarmaPorHora()
        {
            if (climaActual >= TEMPERATURA_MAXIMA_PERMITIDA)
            {
                //MessageBox.Show("La temperatura actual ha " + "\nrebasado el limite maximo ");
                alert.Show("La temperatura actual ha " + "\nrebasado el limite maximo: " + TEMPERATURA_MAXIMA_PERMITIDA, Alertype.info);
            }
            if (climaActual <= TEMPERATURA_MINIMA_PERMITIDA)
            {
                alert.Show("La temperatura actual ha " + "\nrebasado el limite maximo: " + TEMPERATURA_MINIMA_PERMITIDA, Alertype.info);
            }
        }


        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            AbrirFormEnPanel < Insecticidas>();
        }

        private void ActivarAlarmas()
        {
            CN_DatosClimaMes _DatosClimaMes = new CN_DatosClimaMes();
            CN_Alarmas _Alarmas = new CN_Alarmas();

            DataTable tablaDatosClima = new DataTable();
            DataTable tablaAlarmas = new DataTable();

            String fechaInicial = "", fechaFinal = "";

            int horas = 24;
            String nombreAlarma, fecha1, fecha2;
            int contadorDias;
            int dias;
            int limiteHoras;
            int recorrerDias;
            double temperaturaMax, temperaturaMin;
            double limiteTemperaturaMax, limiteTemperaturaMin;
            tablaDatosClima = _DatosClimaMes.MostrarAlarmaClima();
            tablaAlarmas = _Alarmas.MostrarAlarmas();


            //El foreach busca en los registros de las alarmas la temperatura max de cada alarma y el lapso de dias
            foreach (DataRow row in tablaAlarmas.Rows)
            {
                contadorDias = 0;
                limiteHoras = 0;

                //Dias es el lapso de dias que conteiene la alarma
                dias = Convert.ToInt32(row["lapsoDias"]);

                limiteTemperaturaMax = Convert.ToDouble(row["tempMaxAlarma"]);
                limiteTemperaturaMin = Convert.ToDouble(row["tempMinAlarma"]);

                nombreAlarma = row["nombreAlarma"].ToString();

                //Cada dia tiene 24 registros por ende la cantidad de dias que tenga la alrma sera multiplicada por 24
                recorrerDias = dias * horas;

                /*
                 * El for recorre todos los registros de temperaturas registrada en datos de clima
                 * para evaluar la temperatura limite de la alrma y la cantidad de dias de la alarma
                 */
                for (int i = 0; i < recorrerDias; i++)
                {
                    //Obtiene la temperatura registrada por registro
                    temperaturaMax = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);


                    //Cuando se inicialice por primera vez el limite de horas sera 24 dando referencia al primer dia a evaluar
                    if (limiteHoras == 0)
                    {
                        limiteHoras = 24;
                    }


                    if (i < limiteHoras)
                    {
                        if (temperaturaMax >= limiteTemperaturaMax)
                        {
                            contadorDias++;
                            i += limiteHoras - i;
                            limiteHoras += 24;

                            if (contadorDias == dias)
                            {

                                alert.Show("La temperautra maxima ha sido" + "\nrebasada " + limiteTemperaturaMax + " C" + "\npara la alarma: " + "\n" + nombreAlarma + " " + temperaturaMax, Alertype.error);
                                fechaFinal = Convert.ToString(tablaDatosClima.Rows[i += -limiteHoras + i]["Fecha_Local"]);
                                fechaInicial = Convert.ToString(tablaDatosClima.Rows[i = 1]["Fecha_Local"]);

                                i = recorrerDias;

                                String alarmaActivada = "Sobrepaso la temperatura maxima";
                                String fechaActivada = DateTime.Now.ToString("dd/MM/yy");

                                //Arreglar estoInsertarReportesAlarmas(nombreAlarma, limiteTemperaturaMax, limiteTemperaturaMin, fechaInicial, fechaFinal, fechaActivada, alarmaActivada);
                            }
                        }
                    }
                    else
                    {
                        limiteHoras += 24;
                    }
                }

                contadorDias = 0;
                limiteHoras = 0;
                //Este for es para encontrar la temperatura minima
                for (int i = 0; i < recorrerDias; i++)
                {
                    //Obtiene la temperatura registrada por registro
                    temperaturaMin = Convert.ToDouble(tablaDatosClima.Rows[i]["Temperatura"]);


                    //Cuando se inicialice por primera vez el limite de horas sera 24 dando referencia al primer dia a evaluar
                    if (limiteHoras == 0)
                    {
                        limiteHoras = 24;
                    }


                    if (i < limiteHoras)
                    {
                        if (temperaturaMin <= limiteTemperaturaMax)
                        {
                            contadorDias++;
                            i += limiteHoras - i;
                            limiteHoras += 24;

                            if (contadorDias == dias)
                            {

                                alert.Show("La temperatura ha disminuido por"+ "\ndebajo del limite establecido " +"\n"+limiteTemperaturaMin + " C" + "\npara la alarma: " + "\n" + nombreAlarma + " " + temperaturaMin, Alertype.info);
                                fechaFinal = Convert.ToString(tablaDatosClima.Rows[i += -limiteHoras + i]["Fecha_Local"]);
                                fechaInicial = Convert.ToString(tablaDatosClima.Rows[i = 1]["Fecha_Local"]);
                                i = recorrerDias;

                                String alarmaActivada = "Disminuyo la temperatura limite";
                                String fechaActivada = DateTime.Now.ToString("dd/MM/yy");

                                //Arreglar esto InsertarReportesAlarmas(nombreAlarma, limiteTemperaturaMax, limiteTemperaturaMin, fechaInicial, fechaFinal, fechaActivada, alarmaActivada);
                            }
                        }
                    }
                    else
                    {
                        limiteHoras += 24;
                    }
                }
            }
        }

        private void InsertarReportesAlarmas(String nombreAlarma, double temperaturaMaxima, double temperaturaMinima, String fechaInicio, String fechaFin, String fechaActivada, String alarmaActivada)
        {

            CN_Alarmas _Alarmas = new CN_Alarmas();
            //MessageBox.Show("Funciona?");
            DataTable tablaReportesAlarmas = new DataTable();
            tablaReportesAlarmas = _Alarmas.MostrarReportesAlarmas(); //Aqui deja de funcionar el sistema
            String fecha, nombre;
            int contador = 0;

            if (Evaluar(nombreAlarma, fechaActivada) == true)
            {
                _Alarmas.InsertarReportesAlarmas(nombreAlarma, temperaturaMaxima, temperaturaMinima, fechaInicio, fechaFin, fechaActivada, alarmaActivada);
            }
            /*
            foreach (DataRow row in tablaReportesAlarmas.Rows)
            {
                fecha = row["fechaActivada"].ToString();
                nombre = row["nombreAlarma"].ToString();

                if (fecha != fechaActivada ||  nombre!=nombreAlarma)
                {
                    _Alarmas.InsertarReportesAlarmas(nombreAlarma, temperaturaMaxima, temperaturaMinima, fechaInicio, fechaFin, fechaActivada, alarmaActivada);
                }
                else
                {

                }
                contador = 1;
            }
            */
            /*
            if (contador == 0)
            {
                
                _Alarmas.InsertarReportesAlarmas(nombreAlarma, temperaturaMaxima, temperaturaMinima, fechaInicio, fechaFin, fechaActivada, alarmaActivada);
            }
            */
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            Calculadora objCal = new Calculadora();
            objCal.Show();
        }

        private Boolean Evaluar(String nombreAlarma, String fechaActivada)
        {
            String nombre, fecha;
            CN_Alarmas _Alarmas = new CN_Alarmas();
            //MessageBox.Show("Funciona?");
            DataTable tablaReportesAlarmas = new DataTable();
            tablaReportesAlarmas = _Alarmas.MostrarReportesAlarmas();

            foreach (DataRow row in tablaReportesAlarmas.Rows)
            {
                nombre = row["nombreAlarma"].ToString();
                fecha = row["fechaActivada"].ToString();
                if (nombre == nombreAlarma && fecha == fechaActivada)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
