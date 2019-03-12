using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Escritorio
{
    public partial class vpListadoControles : Form
    {
        public int idtambo;
        public vpListadoControles()
        {
            InitializeComponent();
        }

        private void vpListadoControles_Load(object sender, EventArgs e)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            rptListadoControles reporte = new rptListadoControles();

            reporte.SetDataSource(controlAnimalNegocio.RecuperarDTPorTambo(idtambo));
            crvControles.ReportSource = reporte;
            crvControles.Refresh();
        }
    }
}
