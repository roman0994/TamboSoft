using Entidades;
using Negocio;
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
    public partial class vpEventos_Animal : Form
    {
        public Animal Animal { get; set; }
        public vpEventos_Animal()
        {
            InitializeComponent();
        }


        public vpEventos_Animal(Animal animal)
        {
            InitializeComponent();
            Animal = new Animal();
            Animal = animal;
        }


        private void vpEventos_Animal_Load(object sender, EventArgs e)
        {
            if (Animal == null)
            {
                EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
                rptEvento_Animal reporte = new rptEvento_Animal();
                reporte.SetParameterValue("@id_tambo", Principal.Tambo.Id_tambo);
                reporte.SetDatabaseLogon("abcd", "123456");
                crvEvento_Animal.ReportSource = reporte;
            }
            else
            {
                EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();
                rptEventoXAnimal reporte = new rptEventoXAnimal();
                reporte.SetParameterValue("@id_tambo", Principal.Tambo.Id_tambo);
                reporte.SetParameterValue("@rp", Animal.Rp);
                reporte.SetDatabaseLogon("abcd", "123456");
                crvEvento_Animal.ReportSource = reporte;
            }


        }
    }
}
