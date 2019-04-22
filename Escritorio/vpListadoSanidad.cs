using Negocio;
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
    public partial class vpListadoSanidad : Form
    {
        public vpListadoSanidad()
        {
            InitializeComponent();
        }

        private void vpListadoSanidad_Load(object sender, EventArgs e)
        {
            Animal_Negocio animal_Negocio = new Animal_Negocio();
            rptListadoSanidad reporte = new rptListadoSanidad();

            reporte.SetDataSource(animal_Negocio.RecuperarDTPorTambo(Principal.Tambo.Id_tambo));
            reporte.SetDatabaseLogon("abcd", "123456");
            crv.ReportSource = reporte;
            crv.Refresh();
        }
    }
}
