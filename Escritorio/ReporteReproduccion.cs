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
        EventoAnimal_DescSubevento_Negocio eventoNegocio;

        public ReporteReproduccion(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            //CargarGrilla(id_tambo);
            //CargarCantidadCrias(id_tambo);
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = new Tambo();

                tambo = tamboNegocio.RecuperarUno(id_tambo);
                this.txtTambo.Text = tambo.Nombre_tambo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public void CargarGrilla(int id_tambo)
        {
            //EventoAnimal_DescSubevento_Negocio eventoAnimalDescSubeventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            //this.dgvPartos.AutoGenerateColumns = false;
            //this.dgvPartos.DataSource = eventoAnimalDescSubeventoNegocio.RecuperarPartosPorTambo(id_tambo);
            //if (this.dgvPartos.Rows.Count != 0 && this.dgvPartos.Rows != null)
            //{
            //    this.btnExportar.Enabled = true;
            //}
            //else
            //{
            //    this.btnExportar.Enabled = false;
            //}
        }

        public void CargarCantidadCrias(int id_tambo)
        {
            ////Cantidad crias hembra
            //Animal_Negocio animalNegocio = new Animal_Negocio();
            //this.txtCriasHembra.Text = animalNegocio.CantidadCriasHembra(id_tambo).ToString();
            ////Cantidad crias macho
            //this.txtCriasMacho.Text = animalNegocio.CantidadCriasMacho(id_tambo).ToString();
            ////Cantidad crias muertas
            //this.txtCriasMuertas.Text = animalNegocio.CantidadCriasMuertas(id_tambo).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //DateTime fechaDesde = this.dateTimePicker1.Value;
            //DateTime fechaHasta = this.dateTimePicker2.Value;
            ////Cargar partos
            //EventoAnimal_DescSubevento_Negocio eventoAnimalDescSubeventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            //this.dgvPartos.DataSource = eventoAnimalDescSubeventoNegocio.RecuperarPartosPorTamboPorFecha(idtambo, fechaDesde, fechaHasta);
            //if (this.dgvPartos.Rows.Count != 0 && this.dgvPartos.Rows != null)
            //{
            //    this.btnExportar.Enabled = true;
            //}
            //else
            //{
            //    this.btnExportar.Enabled = false;
            //}
            ////Crías hembra
            //Animal_Negocio animalNegocio = new Animal_Negocio();
            //this.txtCriasHembra.Text = animalNegocio.CantidadCriasHembraPorFecha(idtambo, fechaDesde, fechaHasta).ToString();
            ////Crías macho
            //this.txtCriasMacho.Text = animalNegocio.CantidadCriasMachoPorFecha(idtambo, fechaDesde, fechaHasta).ToString();
            ////Crías muertas
            //this.txtCriasMuertas.Text = animalNegocio.CantidadCriasMuertasPorFecha(idtambo, fechaDesde, fechaHasta).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        //    this.CargarGrilla(idtambo);
        //    this.CargarCantidadCrias(idtambo);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = this.dateTimePicker1.Value;
                DateTime fechaHasta = this.dateTimePicker2.Value;
  
                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("La primer fecha no puede ser superior a la segunda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (eventoNegocio.HayPartos(fechaDesde,fechaHasta,Principal.Tambo.Id_tambo))
                {
                    vpReporteReproduccion vp = new vpReporteReproduccion(fechaDesde, fechaHasta);
                    vp.Show();
                }
                else
                {
                    MessageBox.Show("No se encontraron partos en el intervalo de fechas ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //vpReproduccion vistaPreviaReproduccion = new vpReproduccion();
            //vistaPreviaReproduccion.idtambo = idtambo;
            //vistaPreviaReproduccion.Show();
        }

        private void ReporteReproduccion_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now ;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
