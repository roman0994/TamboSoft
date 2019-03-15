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
    public partial class vpProduccionPorFechaMes : Form
    {
        public int idtambo;
        public int mes;
        public int año;

        public vpProduccionPorFechaMes()
        {
            InitializeComponent();
        }

        private void vpProduccionPorFechaMes_Load(object sender, EventArgs e)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            rptProduccionPorFechaMes reporte = new rptProduccionPorFechaMes();
            reporte.SetDataSource(controlAnimalNegocio.ProduccionPorFiltroMes(idtambo,mes,año));
            crvProduccionPorMes.ReportSource = reporte;
            crvProduccionPorMes.Refresh();
        }
    }
}
