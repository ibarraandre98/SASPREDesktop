using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Reportes : Form
    {
        public DataSet DS;
        public DataSet informacion;
        public int reporte;
        ReporteFertilizantes crpt = new ReporteFertilizantes();

        public void setInformacion(DataSet informacion)
        {
            this.informacion = informacion;
        }
        public DataSet getInformacion()
        {
            return this.informacion;
        }
        public void setReporte(int reporte)
        {
            this.reporte = reporte;
        }
        public int getReporte()
        {
            return this.reporte;
        }
        public void setData(DataSet DS)
        {
            this.DS = DS;
        }
        public DataSet getDs()
        {
            return this.DS;
        }
        public Reportes()
        {
            InitializeComponent();
        }
        public void llenarReporte()
        {
            if (reporte == 1)
            {
                ReporteUsuario rptPractica61 = new ReporteUsuario();
                rptPractica61.SetDataSource(DS);
                rptPractica61.SetParameterValue("Nombre", Program.nombre.ToString());
                rptPractica61.SetParameterValue("correo", Program.correo.ToString());
                rptPractica61.SetParameterValue("cargo", Program.cargo.ToString());
                rptPractica61.SetParameterValue("apellido", Program.apellidos.ToString());
                this.crystalReportViewer1.ReportSource = rptPractica61;
                this.crystalReportViewer1.Show();
            }
            else
            {
                if (reporte == 2)
                {
                    ReporteFertilizantes crpt = new ReporteFertilizantes();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("correo", Program.correo.ToString());
                    crpt.SetParameterValue("cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();

                }
                if (reporte == 3)
                {
                    ReporteCosechas crpt = new ReporteCosechas();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("correo", Program.correo.ToString());
                    crpt.SetParameterValue("cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();
                }
                if (reporte == 4)
                {
                    ReporteCultivo crpt = new ReporteCultivo();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("correo", Program.correo.ToString());
                    crpt.SetParameterValue("cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();
                }
                if (reporte == 5)
                {
                    HistorialPlagas crpt = new HistorialPlagas();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("correo", Program.correo.ToString());
                    crpt.SetParameterValue("cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();
                }
                if (reporte == 6)
                {
                    ReporteDatosAtmosfericos crpt = new ReporteDatosAtmosfericos();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("correo", Program.correo.ToString());
                    crpt.SetParameterValue("cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();
                }
                if(reporte == 7)
                {
                    ReporteAlmacen crpt = new ReporteAlmacen();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("correo", Program.correo.ToString());
                    crpt.SetParameterValue("cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();
                }
                if(reporte == 8)
                {
                    ReporteCostos crpt = new ReporteCostos();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("correo", Program.correo.ToString());
                    crpt.SetParameterValue("cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();
                }
                if(reporte == 9){
                    ReporteCalendario crpt = new ReporteCalendario();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("correo", Program.correo.ToString());
                    crpt.SetParameterValue("cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();
                }
                if (reporte == 10)
                {
                    rpt_BitacoraAlmacen crpt = new rpt_BitacoraAlmacen();
                    crpt.SetDataSource(DS);
                    crpt.SetParameterValue("Nombre", Program.nombre.ToString());
                    crpt.SetParameterValue("Correo", Program.correo.ToString());
                    crpt.SetParameterValue("Cargo", Program.cargo.ToString());
                    crpt.SetParameterValue("Apellido", Program.apellidos.ToString());
                    this.crystalReportViewer1.ReportSource = crpt;
                    this.crystalReportViewer1.Show();
                }

            }

        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            llenarReporte();
         
        }

       
    }
}
