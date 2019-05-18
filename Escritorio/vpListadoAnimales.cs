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
    public partial class vpListadoAnimales : Form
    {
        public int idtambo;

        public vpListadoAnimales()
        {
            InitializeComponent();
        }

        private void vpListadoAnimales_Load(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animal_Negocio = new Animal_Negocio();
                rptListadoAnimales reporte = new rptListadoAnimales();

                reporte.SetDataSource(animal_Negocio.RecuperarDTPorTambo(idtambo));
                crvAnimales.ReportSource = reporte;
                crvAnimales.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
