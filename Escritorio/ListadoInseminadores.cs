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
            ExportarAExcel exportarAExcel = new ExportarAExcel();
            exportarAExcel.Exportar(this.dgvInseminadores,ListadoInseminadores.ActiveForm.Text);
        }

        private void tstxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Inseminador_Negocio inseminador_Negocio = new Inseminador_Negocio();
            this.dgvInseminadores.DataSource = inseminador_Negocio.FiltrarPorNombre(this.tstxtBuscar.Text);
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(Convert.ToInt32(this.dgvInseminadores.CurrentRow.Cells["id_tambo"].Value));
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            vpListadoInseminadores vistaPreviaListadoIns = new vpListadoInseminadores();
            vistaPreviaListadoIns.idtambo = idtambo;
            vistaPreviaListadoIns.Show();
        }
    }
}
