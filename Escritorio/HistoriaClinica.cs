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
    public partial class HistoriaClinica : Form
    {
        public HistoriaClinica()
        {
            InitializeComponent();
            if (this.dgvHistorialClinico.Rows.Count != 0 && this.dgvHistorialClinico.Rows != null)
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
            vpHistoriaClinica vistaPreviaHistoriaClinica = new vpHistoriaClinica();
            vistaPreviaHistoriaClinica.rp = Convert.ToInt32(this.dgvHistorialClinico.CurrentRow.Cells["rp"].Value); ;
            vistaPreviaHistoriaClinica.Show();
        }
    }
}
