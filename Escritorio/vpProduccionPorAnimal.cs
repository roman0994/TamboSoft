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
    public partial class vpProduccionPorAnimal : Form
    {
        public int idtambo;
        public int opcioncombo;

        public vpProduccionPorAnimal()
        {
            InitializeComponent();
        }

        private void vpProduccionPorAnimal_Load(object sender, EventArgs e)
        {
            try
            {
                Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
                rptProduccionPorAnimal reporte = new rptProduccionPorAnimal();

                if (this.opcioncombo == -1)
                {
                    reporte.SetDataSource(controlAnimalNegocio.ProduccionPorAnimal(idtambo));
                    crvProduccion.ReportSource = reporte;
                    crvProduccion.Refresh();
                }
                else
                {
                    //Asigno el reporte según el animal recuperado
                    reporte.SetDataSource(controlAnimalNegocio.ProduccionPorFiltroAnimal(idtambo, opcioncombo));
                    crvProduccion.ReportSource = reporte;
                    crvProduccion.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
