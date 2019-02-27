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
using SpreadsheetLight;

namespace Escritorio
{
    public partial class ListadoAnimales : Form
    {
        public int idtambo;
        
        public ListadoAnimales(int idtambo)
        {
            InitializeComponent();
            CargarGrilla(idtambo);
        }

        public void CargarGrilla(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.dgvAnimales.DataSource = animalNegocio.RecuperarPorTambo(id_tambo);
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
            AltaAnimales altaAnimales = new AltaAnimales(idtambo);
            altaAnimales.ShowDialog();
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();    
            this.dgvAnimales.DataSource = animalNegocio.FiltrarPorNombre(this.tstxtBuscar.Text);   
        }

        private void tbsActualizar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value));
        }

        private void tbsImpresora_Click(object sender, EventArgs e)
        {
            VistaPreviaListadoAnimales vistaPreviaListadoAnimales = new VistaPreviaListadoAnimales();
            
            ReporteListadoAnimales reporteListadoAnimales = new ReporteListadoAnimales();
            //Animal_Negocio animal_Negocio = new Animal_Negocio();
            //reporteListadoAnimales.SetDataSource(animal_Negocio.RecuperarPorTambo(idtambo));

            vistaPreviaListadoAnimales.crvAnimales.ReportSource = reporteListadoAnimales;
            vistaPreviaListadoAnimales.crvAnimales.Refresh();
            vistaPreviaListadoAnimales.ShowDialog();
        }

        private void tbsExportarAExcel_Click(object sender, EventArgs e)
        {
            ExportarAExcel exportarAExcel = new ExportarAExcel();
            exportarAExcel.Exportar(this.dgvAnimales,ListadoAnimales.ActiveForm.Text);
        }
    }
}
