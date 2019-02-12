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
        }

        private void tbsExportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel exportarAExcel = new ExportarAExcel();
            exportarAExcel.Exportar(this.dgvEventos,ListadoEventos.ActiveForm.Text);
        }

        private void tstxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            this.dgvEventos.DataSource = eventoNegocio.FiltrarPorNombreEvento(this.tstxtBuscar.Text, idtambo);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(Convert.ToInt32(this.dgvEventos.CurrentRow.Cells["id_tambo"].Value));
        }
    }
}
