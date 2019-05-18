using Entidades;
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
            this.dgvHistorialProduccion.AutoGenerateColumns = false;
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = new Animal();

                //vpHistorialProduccion vistaPreviaHistorialProd = new vpHistorialProduccion();
                animal.Rp = Convert.ToInt32(this.dgvHistorialProduccion.CurrentRow.Cells["rp"].Value);
                vpListadoControlesPorFecha vp = new vpListadoControlesPorFecha(animal);
                vp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void HistorialProduccion_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvHistorialProduccion.Rows.Count != 0 && this.dgvHistorialProduccion.Rows != null)
                {
                    btnImprimir.Enabled = true;
                }
                else
                {
                    btnImprimir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
