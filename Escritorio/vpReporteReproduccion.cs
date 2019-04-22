using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class vpReporteReproduccion : Form
    {

        DateTime Fecha_Desde;
        DateTime Fecha_Hasta;
        public vpReporteReproduccion()
        {
            InitializeComponent();
        }

        public vpReporteReproduccion(DateTime fecha_desde,DateTime fecha_hasta)
        {
            InitializeComponent();
            Fecha_Desde = fecha_desde;
            Fecha_Hasta = fecha_hasta;
        }

        private void vpReporteReproduccion_Load(object sender, EventArgs e)
        {
            rptReporteReproduccionPorFechas reporte = new rptReporteReproduccionPorFechas();
            
            reporte.SetParameterValue("@id_tambo", Principal.Tambo.Id_tambo);
            reporte.SetParameterValue("@FechaDesde", Fecha_Desde);
            reporte.SetParameterValue("@FechaHasta", Fecha_Hasta);
            reporte.SetDatabaseLogon("abcd", "123456");
            crv.ReportSource = reporte;
        }
    }
}
