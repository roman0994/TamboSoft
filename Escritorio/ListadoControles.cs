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
    public partial class ListadoControles : Form
    {
        public int idtambo;
        public ListadoControles(int id_tambo)
        {
            InitializeComponent();
            CargarGrilla(id_tambo);
        }

        public void CargarGrilla(int id_tambo)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            this.dgvControles.DataSource = controlAnimalNegocio.RecuperarPorTambo(id_tambo);
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
            AltaControles altaControles = new AltaControles(idtambo);
            altaControles.ShowDialog();
        }

        private void tbsExportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel exportarAExcel = new ExportarAExcel();
            exportarAExcel.Exportar(this.dgvControles,ListadoControles.ActiveForm.Text);
        }

        private void tstxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Control_Animal_Negocio controlNegocio = new Control_Animal_Negocio();
            this.dgvControles.DataSource = controlNegocio.FiltrarPorNombre(this.tstxtBuscar.Text);
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(Convert.ToInt32(idtambo));
        }
    }
}
