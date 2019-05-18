using Entidades;
using Negocio;
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
            this.dgvHistorialClinico.AutoGenerateColumns = false;
           
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = new Animal();
                animal.Rp = Convert.ToInt32(this.dgvHistorialClinico.CurrentRow.Cells["rp"].Value);
                vpEventos_Animal vp = new vpEventos_Animal(animal);
                vp.Show();
                //vpHistoriaClinica vistaPreviaHistoriaClinica = new vpHistoriaClinica();
                //vistaPreviaHistoriaClinica.rp = Convert.ToInt32(this.dgvHistorialClinico.CurrentRow.Cells["rp"].Value); ;
                //vistaPreviaHistoriaClinica.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void dgvHistorialClinico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvHistorialClinico.Rows.Count != 0 && this.dgvHistorialClinico.Rows != null)
                {
                    int id_tambo = Principal.Tambo.Id_tambo;
                    int rp = Convert.ToInt32(this.dgvHistorialClinico.CurrentRow.Cells["rp"].Value);
                    int id_evento = Convert.ToInt32(this.dgvHistorialClinico.CurrentRow.Cells["id_evento"].Value);
                    DateTime fecha = Convert.ToDateTime(this.dgvHistorialClinico.CurrentRow.Cells["fecha_desc"].Value);

                    DetalleEventos detalle = new DetalleEventos();
                    EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
                    detalle.dgvDetalles.DataSource = eventoAnimalDescNegocio.RecuperarDescripcionesPorEvento(id_tambo, rp, id_evento, fecha);
                    detalle.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void HistoriaClinica_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvHistorialClinico.Rows.Count != 0 && this.dgvHistorialClinico.Rows != null)
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
