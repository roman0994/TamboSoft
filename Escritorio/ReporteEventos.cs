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
    public partial class ReporteEventos : Form
    {
        public int idtambo;
        public ReporteEventos(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            CargarGrillas(id_tambo);
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();

            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        public void CargarGrillas(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.dgvVacasServidas.DataSource = animalNegocio.RecuperarVacasServidasPorTambo(id_tambo);
            this.dgvVacasParto.DataSource = animalNegocio.RecuperarVacasConPartoPorTambo(id_tambo);
            this.dgvVacasCelo.DataSource = animalNegocio.RecuperarVacasEnCeloPorTambo(id_tambo);
            this.dgvAnimalesEnfermos.DataSource = animalNegocio.RecuperarAnimalesEnfermosPorTambo(id_tambo);
            this.dgvCriasHembra.DataSource = animalNegocio.CantidadCriasHembra(id_tambo);
            this.dgvCriasMacho.DataSource = animalNegocio.CantidadCriasMacho(id_tambo);
            this.dgvCriasMuertas.DataSource = animalNegocio.CantidadCriasMuertas(id_tambo);
        }
    }
}
