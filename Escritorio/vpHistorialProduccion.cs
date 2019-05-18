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
    public partial class vpHistorialProduccion : Form
    {
        public int rp;
        public vpHistorialProduccion()
        {
            InitializeComponent();
        }

        private void vpHistorialProduccion_Load(object sender, EventArgs e)
        {
            try
            {
                Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
                rptHistorialProduccion reporte = new rptHistorialProduccion();

                reporte.SetDataSource(controlAnimalNegocio.RecuperarDTPorTamboYAnimal(Principal.Tambo.Id_tambo, rp));
                crvHistorialProduccion.ReportSource = reporte;
                crvHistorialProduccion.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
