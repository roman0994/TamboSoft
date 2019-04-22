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
    public partial class vpExistencia : Form
    {
        public vpExistencia()
        {
            InitializeComponent();
        }

        private void vpExistencia_Load(object sender, EventArgs e)
        {
            rptExistencia reporte = new rptExistencia();
            reporte.SetParameterValue("@id_tambo", Principal.Tambo.Id_tambo);
            reporte.SetDatabaseLogon("abcd", "123456");
            
            crv.ReportSource = reporte;
            
        }
    }
}
