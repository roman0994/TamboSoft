﻿using System;
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
using System.Text.RegularExpressions;

namespace Escritorio
{
    public partial class GestionEventos : Form
    {
        public int idtambo;
        public GestionEventos(int id_tambo)
        {
            InitializeComponent();
            this.dgvEventos.AutoGenerateColumns = false;

            CargarGrilla();
            CargarComboBusqueda();
            InicializarTextBox();
        }

        public void CargarGrilla()
        {
            try
            {
                EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();


                this.dgvEventos.DataSource = eventoAnimalDescNegocio.RecuperarSoloEventosPorTambo(Principal.Tambo.Id_tambo);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public void CargarComboBusqueda()
        {
            try
            {
                this.cbBuscar.Items.Add("Nombre animal");
                this.cbBuscar.Items.Add("Evento");
                this.cbBuscar.Items.Add("Caravana");
                this.cbBuscar.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
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
                else if (this.cbBuscar.SelectedItem.ToString() == "Caravana")
                {
                    this.dgvEventos.DataSource = eventoNegocio.FiltrarPorCaravana(this.txtBuscar.Text, idtambo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
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
                    this.CargarGrilla();
                    MessageBox.Show("El evento fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //vpListadoEventos vistaPreviaListadoEventos = new vpListadoEventos();
            //vistaPreviaListadoEventos.idtambo = idtambo;
            //vistaPreviaListadoEventos.Show();        
            vpEventos_Animal vp = new vpEventos_Animal();
            vp.Show();
        }

        public void InicializarTextBox()
        {
            try
            {
                if (this.cbBuscar.SelectedIndex == -1)
                {
                    this.txtBuscar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.CargarGrilla();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsSeparator(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //{
            try
            {
                if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                {
                    int id_tambo = Principal.Tambo.Id_tambo;
                    int rp = Convert.ToInt32(this.dgvEventos.CurrentRow.Cells["rp"].Value);
                    int id_evento = Convert.ToInt32(this.dgvEventos.CurrentRow.Cells["id_evento"].Value);
                    DateTime fecha = Convert.ToDateTime(this.dgvEventos.CurrentRow.Cells["fecha_desc"].Value);

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
            //}
        }
    }
}
