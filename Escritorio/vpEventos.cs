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
    public partial class vpEventos : Form
    {
        public int idtambo;
        public string opcioncombo;

        public vpEventos()
        {
            InitializeComponent();
        }

        private void vpEventos_Load(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                rptEventos reporte = new rptEventos();

                if (this.opcioncombo == "Vacas en celo")
                {
                    reporte.SetDataSource(animalNegocio.RecuperarDTVacasEnCeloPorTambo(idtambo));
                    crvEventos.ReportSource = reporte;
                    crvEventos.Refresh();
                }
                else if (this.opcioncombo == "Animales enfermos")
                {
                    reporte.SetDataSource(animalNegocio.RecuperarDTAnimalesEnfermosPorTambo(idtambo));
                    crvEventos.ReportSource = reporte;
                    crvEventos.Refresh();
                }
                else if (this.opcioncombo == "Vacas con parto en los últimos 21 días")
                {
                    reporte.SetDataSource(animalNegocio.RecuperarDTVacasConPartoPorTambo(idtambo));
                    crvEventos.ReportSource = reporte;
                    crvEventos.Refresh();
                }
                else if (this.opcioncombo == "Vacas servidas en los últimos 21 días")
                {
                    reporte.SetDataSource(animalNegocio.RecuperarDTVacasServidasPorTambo(idtambo));
                    crvEventos.ReportSource = reporte;
                    crvEventos.Refresh();
                }
                else if (this.opcioncombo == "vacio")
                {
                    reporte.SetDataSource(animalNegocio.RecuperarDTPorTambo(idtambo));
                    crvEventos.ReportSource = reporte;
                    crvEventos.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
