using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Escritorio
{
    public partial class ListadoEventos : Form
    {
        public int idtambo;

        public ListadoEventos(int idtambo)
        {
            InitializeComponent();
            CargarGrilla(idtambo);
        }
        public void CargarGrilla(int id_tambo)
        {
            EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
            this.dgvEventos.DataSource = eventoAnimalDescNegocio.RecuperarPorTambo(id_tambo);
            //gvEventos.Columns[0].HeaderText = "TextoAMostrarEnLaCabecera";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbsRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsNuevo_Click(object sender, EventArgs e)
        {
            AltaEventos altaEventos = new AltaEventos(idtambo);
            altaEventos.ShowDialog();
            this.CargarGrilla(idtambo);
        }

        private void tbsExportar_Click(object sender, EventArgs e)
        {
            if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
            {
                ExportarAExcel exportarAExcel = new ExportarAExcel();
                exportarAExcel.Exportar(this.dgvEventos, ListadoEventos.ActiveForm.Text);
            }
            else
            {
                Tambo tambo = new Tambo();
                Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                tambo = tambo_Negocio.RecuperarUno(idtambo);
                MessageBox.Show("No se encontraron eventos en el tambo " + tambo.Nombre_tambo, "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tstxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            this.dgvEventos.DataSource = eventoNegocio.FiltrarPorNombreEvento(this.tstxtBuscar.Text, idtambo);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
            {
                this.CargarGrilla(Convert.ToInt32(this.dgvEventos.CurrentRow.Cells["id_tambo"].Value));
            }
        }

        private void tbsImprimir_Click(object sender, EventArgs e)
        {
            if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
            {
                vpListadoEventos vistaPreviaListadoEventos = new vpListadoEventos();
                vistaPreviaListadoEventos.idtambo = idtambo;
                vistaPreviaListadoEventos.Show();
            }
            else
            {
                Tambo tambo = new Tambo();
                Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                tambo = tambo_Negocio.RecuperarUno(idtambo);
                MessageBox.Show("No se encontraron eventos en el tambo " + tambo.Nombre_tambo, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
