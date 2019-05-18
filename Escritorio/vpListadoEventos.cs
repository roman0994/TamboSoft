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
    public partial class vpListadoEventos : Form
    {
        public int idtambo;
        public vpListadoEventos()
        {
            InitializeComponent();
        }

        private void vpListadoEventos_Load(object sender, EventArgs e)
        {
            try
            {
                EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
                rptListadoEventos reporte = new rptListadoEventos();
                //GrupoPrueba reporte = new GrupoPrueba();
                reporte.SetDataSource(eventoAnimalDescNegocio.RecuperarDTPorTambo(idtambo));
                crvEventos.ReportSource = reporte;
                crvEventos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
