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
    public partial class vpListadoInseminadores : Form
    {
        public int idtambo;
        public vpListadoInseminadores()
        {
            InitializeComponent();
        }

        private void crvInseminadores_Load(object sender, EventArgs e)
        {
            try
            {
                Tambo_Inseminador_Negocio inseminadorNegocio = new Tambo_Inseminador_Negocio();
                rptListadoInseminadores reporte = new rptListadoInseminadores();

                reporte.SetDataSource(inseminadorNegocio.RecuperarDTPorTambo(idtambo));
                crvInseminadores.ReportSource = reporte;
                crvInseminadores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
