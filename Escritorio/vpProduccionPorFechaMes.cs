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
    public partial class vpProduccionPorFechaMes : Form
    {
        public int idtambo;
        public int mes;
        public int año;
        public int rp;

        public vpProduccionPorFechaMes()
        {
            InitializeComponent();
        }

        public vpProduccionPorFechaMes(int Mes,int Anio)
        {
            InitializeComponent();
            mes = Mes;
            año = Anio;
        }

        private void vpProduccionPorFechaMes_Load(object sender, EventArgs e)
        {
            try
            {
                //Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
                //rptProduccionPorFechaMes reporte = new rptProduccionPorFechaMes();
                //reporte.SetDataSource(controlAnimalNegocio.ProduccionPorFiltroMesYAnimal(idtambo,mes,año, rp));
                //crvProduccionPorMes.ReportSource = reporte;
                //crvProduccionPorMes.Refresh();
                RankingProduccionMesAnio2 reporte = new RankingProduccionMesAnio2();
                reporte.SetParameterValue("@id_tambo", Principal.Tambo.Id_tambo);
                reporte.SetParameterValue("@mes", mes);
                reporte.SetParameterValue("@anio", año);
                reporte.SetDatabaseLogon("abcd", "123456");
                crvProduccionPorMes.ReportSource = reporte;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
