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
using Entidades;

namespace Escritorio
{
    public partial class ListadoInseminadores : Form
    {
        public int idtambo;

        public ListadoInseminadores(int idtambo)
        {
            InitializeComponent();
            CargarGrilla(idtambo);

        }

        public void CargarGrilla(int id_tambo)
        {
            try
            {
                Tambo_Inseminador_Negocio tamboInseminadorNegocio = new Tambo_Inseminador_Negocio();
                this.dgvInseminadores.DataSource = tamboInseminadorNegocio.RecuperarPorTambo(id_tambo);
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

        private void tsbRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                AltaPersonal altaPersonal = new AltaPersonal(idtambo);
                altaPersonal.ShowDialog();
                this.CargarGrilla(idtambo);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tsbExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvInseminadores.Rows.Count != 0 && this.dgvInseminadores.Rows != null)
                {
                    ExportarAExcel exportarAExcel = new ExportarAExcel();
                    exportarAExcel.Exportar(this.dgvInseminadores, ListadoInseminadores.ActiveForm.Text);
                }
                else
                {
                    Tambo tambo = new Tambo();
                    Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                    tambo = tambo_Negocio.RecuperarUno(idtambo);
                    MessageBox.Show("No se encontraron inseminadores en el tambo " + tambo.Nombre_tambo, "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Tambo_Inseminador_Negocio tamboInseminadorNegocio = new Tambo_Inseminador_Negocio();
                this.dgvInseminadores.DataSource = tamboInseminadorNegocio.FiltrarPorNombre(this.tstxtBuscar.Text, idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvInseminadores.Rows.Count != 0 && this.dgvInseminadores.Rows != null)
                {
                    this.CargarGrilla(Convert.ToInt32(this.dgvInseminadores.CurrentRow.Cells["id_tambo"].Value));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvInseminadores.Rows.Count != 0 && this.dgvInseminadores.Rows != null)
                {
                    vpListadoInseminadores vistaPreviaListadoIns = new vpListadoInseminadores();
                    vistaPreviaListadoIns.idtambo = idtambo;
                    vistaPreviaListadoIns.Show();
                }
                else
                {
                    Tambo tambo = new Tambo();
                    Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                    tambo = tambo_Negocio.RecuperarUno(idtambo);
                    MessageBox.Show("No se encontraron inseminadores en el tambo " + tambo.Nombre_tambo, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
