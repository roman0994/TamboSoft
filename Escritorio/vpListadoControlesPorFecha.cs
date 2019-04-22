using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class vpListadoControlesPorFecha : Form
    {
        public Animal Animal { get; set; }
        public vpListadoControlesPorFecha()
        {
            InitializeComponent();
        }
        public vpListadoControlesPorFecha(Animal animal)
        {
            InitializeComponent();
            Animal = new Animal();
            Animal = animal;
        }

        private void vpListadoControlesPorFecha_Load(object sender, EventArgs e)
        {
            if (Animal == null)
            {
                
                rptListadoControlesPorFechas reporte = new rptListadoControlesPorFechas();
               
                reporte.SetParameterValue("@id_tambo", Principal.Tambo.Id_tambo);
                reporte.SetDatabaseLogon("abcd", "123456");
                crv.ReportSource = reporte;

            }
            else
            {

                rptListadoControlePorAnimalUnico reporte = new rptListadoControlePorAnimalUnico();
                reporte.SetParameterValue("@id_tambo", Principal.Tambo.Id_tambo);
                reporte.SetParameterValue("@rp", Animal.Rp);
                reporte.SetDatabaseLogon("abcd", "123456");
                crv.ReportSource = reporte;
            }

        }
    }
}
