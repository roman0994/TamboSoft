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
            Tambo_Inseminador_Negocio tamboInseminadorNegocio = new Tambo_Inseminador_Negocio();
            this.dgvInseminadores.DataSource = tamboInseminadorNegocio.RecuperarPorTambo(id_tambo);
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
            AltaPersonal altaPersonal = new AltaPersonal(idtambo);
            altaPersonal.ShowDialog();
            this.CargarGrilla(idtambo);
        }

        private void tsbExportar_Click(object sender, EventArgs e)
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

        private void tstxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Tambo_Inseminador_Negocio tamboInseminadorNegocio = new Tambo_Inseminador_Negocio();
            this.dgvInseminadores.DataSource = tamboInseminadorNegocio.FiltrarPorNombre(this.tstxtBuscar.Text,idtambo);
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            if (this.dgvInseminadores.Rows.Count != 0 && this.dgvInseminadores.Rows != null)
            {
                this.CargarGrilla(Convert.ToInt32(this.dgvInseminadores.CurrentRow.Cells["id_tambo"].Value));
            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
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
    }
}
