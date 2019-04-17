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

        public void CargarGrilla(int idtambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.dgvAnimales.DataSource = animalNegocio.RecuperarPorTambo(idtambo);
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
            this.CargarGrilla(idtambo);
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();    
            this.dgvAnimales.DataSource = animalNegocio.FiltrarPorCaravana(this.tstxtBuscar.Text, idtambo);   
        }

        private void tbsActualizar_Click(object sender, EventArgs e)
        {
            if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
            {
                this.CargarGrilla(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value));
            }
        }

        private void tbsExportarAExcel_Click(object sender, EventArgs e)
        {
            if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
            {
                ExportarAExcel exportarAExcel = new ExportarAExcel();
                exportarAExcel.Exportar(this.dgvAnimales, ListadoAnimales.ActiveForm.Text);
            }
            else
            {
                Tambo tambo = new Tambo();
                Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                tambo = tambo_Negocio.RecuperarUno(idtambo);
                MessageBox.Show("No se encontraron animales en el tambo "+ tambo.Nombre_tambo, "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbsImpresora_Click(object sender, EventArgs e)
        {
            /*VistaPreviaListadoAnimales vistaPreviaListadoAnimales = new VistaPreviaListadoAnimales();

            ReporteListadoAnimales reporteListadoAnimales = new ReporteListadoAnimales();
            vistaPreviaListadoAnimales.crvAnimales.ReportSource = reporteListadoAnimales;
            vistaPreviaListadoAnimales.crvAnimales.Refresh();
            vistaPreviaListadoAnimales.ShowDialog();*/
            if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
            {
                vpListadoAnimales vistaPreviaListadoAnimales = new vpListadoAnimales();
                vistaPreviaListadoAnimales.idtambo = idtambo;
                vistaPreviaListadoAnimales.Show();
            }
            else
            {
                Tambo tambo = new Tambo();
                Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                tambo = tambo_Negocio.RecuperarUno(idtambo);
                MessageBox.Show("No se encontraron animales en el tambo " + tambo.Nombre_tambo, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
