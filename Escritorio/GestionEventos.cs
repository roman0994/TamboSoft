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
    public partial class GestionEventos : Form
    {
        public int idtambo;
        public GestionEventos(int id_tambo)
        {
            InitializeComponent();
            CargarGrilla(id_tambo);
            CargarComboBusqueda();
            InicializarTextBox();
        }

        public void CargarGrilla(int id_tambo)
        {
            EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
            this.dgvEventos.DataSource = eventoAnimalDescNegocio.RecuperarPorTambo(id_tambo);
            //gvEventos.Columns[0].HeaderText = "TextoAMostrarEnLaCabecera";
            if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
            {
                this.btnExportar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.btnExportar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }

        public void CargarComboBusqueda()
        {
            this.cbBuscar.Items.Add("Nombre animal");
            this.cbBuscar.Items.Add("Evento");
            this.cbBuscar.Items.Add("Subevento");
            this.cbBuscar.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            if (this.cbBuscar.SelectedIndex == -1)
            {
                this.txtBuscar.Enabled = false;
                //MessageBox.Show("Debe seleccionar un parámetro a buscar en el combo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.cbBuscar.SelectedItem.ToString() == "Nombre animal")
            {
                this.dgvEventos.DataSource = eventoNegocio.FiltrarPorNombreAnimal(this.txtBuscar.Text, idtambo);
            }
            else if (this.cbBuscar.SelectedItem.ToString() == "Evento")
            {
                this.dgvEventos.DataSource = eventoNegocio.FiltrarPorNombreEvento(this.txtBuscar.Text, idtambo);
            }
            else if (this.cbBuscar.SelectedItem.ToString() == "Subevento")
            {
                this.dgvEventos.DataSource = eventoNegocio.FiltrarPorNombreSubevento(this.txtBuscar.Text, idtambo);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            int id_evento = Convert.ToInt32(this.dgvEventos.CurrentRow.Cells["id_evento"].Value);
            int rp = Convert.ToInt32(this.dgvEventos.CurrentRow.Cells["rp"].Value);
            DateTime fecha_desc = Convert.ToDateTime(this.dgvEventos.CurrentRow.Cells["fecha_desc"].Value);
            bool estado_evento = false;
            int id_tambo = Convert.ToInt32(this.dgvEventos.CurrentRow.Cells["id_tambo"].Value);
            DateTime fecha = Convert.ToDateTime(this.dgvEventos.CurrentRow.Cells["fecha_desc"].Value);
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el evento?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                eventoNegocio.Eliminar(estado_evento, id_evento, rp, fecha_desc);
                this.CargarGrilla(id_tambo);
                MessageBox.Show("El evento fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            vpListadoEventos vistaPreviaListadoEventos = new vpListadoEventos();
            vistaPreviaListadoEventos.idtambo = idtambo;
            vistaPreviaListadoEventos.Show();        
        }

        public void InicializarTextBox()
        {
            if (this.cbBuscar.SelectedIndex == -1)
            {
                this.txtBuscar.Enabled = false;
            }
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarGrilla(Login.Tambo.Id_tambo);
            this.txtBuscar.Text = string.Empty;

            if (this.cbBuscar.SelectedIndex == -1)
            {
                this.txtBuscar.Enabled = false;
            }
            else
            {
                this.txtBuscar.Enabled = true;
            }
        }
    }
}
