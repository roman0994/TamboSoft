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
    public partial class HistorialProduccion : Form
    {
        public HistorialProduccion()
        {
            InitializeComponent();
            if (this.dgvHistorialProduccion.Rows.Count != 0 && this.dgvHistorialProduccion.Rows != null)
            {
                btnImprimir.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            vpHistorialProduccion vistaPreviaHistorialProd = new vpHistorialProduccion();
            vistaPreviaHistorialProd.rp = Convert.ToInt32(this.dgvHistorialProduccion.CurrentRow.Cells["rp"].Value); ;
            vistaPreviaHistorialProd.Show();
        }
    }
}
