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
    public partial class vpReproduccion : Form
    {
        public int idtambo;
        public vpReproduccion()
        {
            InitializeComponent();
        }

        private void vpReproduccion_Load(object sender, EventArgs e)
        {
            EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
            rptReproduccion reporte = new rptReproduccion();
            dsTamboSoft ds = new dsTamboSoft();
            
            reporte.SetDataSource(eventoAnimalDescNegocio.ReporteReproduccion(idtambo));
            crvReproduccion.ReportSource = reporte;
            crvReproduccion.Refresh();
        }
    }
}
