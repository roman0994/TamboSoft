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
    public partial class vpHistoriaClinica : Form
    {
        public int rp;
        public vpHistoriaClinica()
        {
            InitializeComponent();
        }

        private void vpHistoriaClinica_Load(object sender, EventArgs e)
        {
            EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            rptHistoriaClinica reporte = new rptHistoriaClinica();

            reporte.SetDataSource(eventoNegocio.RecuperarDTPorTamboYAnimal(Principal.Tambo.Id_tambo,rp));
            crvHistoriaClinica.ReportSource = reporte;
            crvHistoriaClinica.Refresh();
        }
    }
}
