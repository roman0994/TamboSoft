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
            try
            {
                //EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
                //this.dgvEventos.DataSource = eventoAnimalDescNegocio.RecuperarPorTambo(id_tambo);
                EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
                this.dgvEventos.AutoGenerateColumns = false;
                this.dgvEventos.DataSource = eventoAnimalDescNegocio.RecuperarSoloEventosPorTambo(id_tambo);
                //gvEventos.Columns[0].HeaderText = "TextoAMostrarEnLaCabecera";
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

        private void tbsRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                AltaEventos altaEventos = new AltaEventos(idtambo);
                altaEventos.ShowDialog();
                this.CargarGrilla(idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tbsExportar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tstxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
                this.dgvEventos.DataSource = eventoNegocio.FiltrarPorNombreEvento(this.tstxtBuscar.Text, idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                {
                    this.CargarGrilla(Principal.Tambo.Id_tambo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tbsImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                {
                    //vpListadoEventos vistaPreviaListadoEventos = new vpListadoEventos();
                    //vistaPreviaListadoEventos.idtambo = idtambo;
                    //vistaPreviaListadoEventos.Show();
                    vpEventos_Animal vp = new vpEventos_Animal();
                    vp.Show();
                }
                else
                {
                    Tambo tambo = new Tambo();
                    Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                    tambo = tambo_Negocio.RecuperarUno(idtambo);
                    MessageBox.Show("No se encontraron eventos en el tambo " + tambo.Nombre_tambo, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
        }

        private void tstxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsSeparator(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
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
    }
}
