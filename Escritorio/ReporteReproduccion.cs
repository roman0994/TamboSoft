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
    public partial class ReporteReproduccion : Form
    {
        public int idtambo;
        public ReporteReproduccion(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            CargarGrilla(id_tambo);
            CargarCantidadCrias(id_tambo);
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();

            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        public void CargarGrilla(int id_tambo)
        {
            EventoAnimal_DescSubevento_Negocio eventoAnimalDescSubeventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            this.dgvPartos.DataSource = eventoAnimalDescSubeventoNegocio.RecuperarPartosPorTambo(id_tambo);
        }

        public void CargarCantidadCrias(int id_tambo)
        {
            //Cantidad crias hembra
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.txtCriasHembra.Text = animalNegocio.CantidadCriasHembra(id_tambo).ToString();
            //Cantidad crias macho
            this.txtCriasMacho.Text = animalNegocio.CantidadCriasMacho(id_tambo).ToString();
            //Cantidad crias muertas
            this.txtCriasMuertas.Text = animalNegocio.CantidadCriasMuertas(id_tambo).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = this.dateTimePicker1.Value;
            DateTime fechaHasta = this.dateTimePicker2.Value;
            //Cargar partos
            EventoAnimal_DescSubevento_Negocio eventoAnimalDescSubeventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            this.dgvPartos.DataSource = eventoAnimalDescSubeventoNegocio.RecuperarPartosPorTamboPorFecha(idtambo, fechaDesde, fechaHasta);
            //Crías hembra
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.txtCriasHembra.Text = animalNegocio.CantidadCriasHembraPorFecha(idtambo, fechaDesde, fechaHasta).ToString();
            //Crías macho
            this.txtCriasMacho.Text = animalNegocio.CantidadCriasMachoPorFecha(idtambo, fechaDesde, fechaHasta).ToString();
            //Crías muertas
            this.txtCriasMuertas.Text = animalNegocio.CantidadCriasMuertasPorFecha(idtambo, fechaDesde, fechaHasta).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(idtambo);
            this.CargarCantidadCrias(idtambo);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            vpReproduccion vistaPreviaReproduccion = new vpReproduccion();
            vistaPreviaReproduccion.idtambo = idtambo;
            vistaPreviaReproduccion.Show();
        }
    }
}
