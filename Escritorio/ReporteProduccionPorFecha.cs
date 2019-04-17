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
    public partial class ReporteProduccionPorFecha : Form
    {
        public int idtambo;
        public DateTime fecha;
        public int mes;
        public int año;
        public int bandera = 0;

        public ReporteProduccionPorFecha(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            CargarComboBusqueda();
            CargarGrilla(id_tambo);
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
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            this.dgvControles.DataSource = controlAnimalNegocio.ProduccionPorFecha(id_tambo);
            if (this.dgvControles.Rows.Count != 0 && this.dgvControles.Rows != null)
            {
                this.btnExportar.Enabled = true;
            }
            else
            {
                this.btnExportar.Enabled = false;
            }
        }

        public void CargarComboBusqueda()
        {
            this.cbBuscar.Items.Add("Día");
            this.cbBuscar.Items.Add("Mes");
            //this.cbBuscar.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(idtambo);
            this.cbBuscar.Text = "Buscar por:";
            this.cbAño.Visible = false;
            this.dtpDia.Visible = false;
            this.cbMes.Visible = false;
            this.btnBuscar.Enabled = false;
            this.bandera = 0;
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbBuscar.SelectedItem.ToString() == "Día")
            {
                this.cbAño.Visible = false;
                this.cbMes.Visible = false;
                this.dtpDia.Visible = true;
                this.btnBuscar.Enabled = true;
                //this.dgvEventos.DataSource = animalNegocio.RecuperarVacasEnCeloPorTambo(tambo.Id_tambo);
            }
            else if (this.cbBuscar.SelectedItem.ToString() == "Mes")
            {
                this.dtpDia.Visible = false;
                CargarComboAño();
                this.cbAño.Text = "Año:";
                this.cbAño.Visible = true;
                this.btnBuscar.Enabled = false;
                //this.dgvEventos.DataSource = animalNegocio.RecuperarAnimalesEnfermosPorTambo(tambo.Id_tambo);
            }
        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboMes();
        }

        public void CargarComboAño()
        {
            for(int i=2019; i<=2050 ; i++)
            {
                this.cbAño.Items.Add(i);
            }
        }

        public void CargarComboMes()
        {
            this.cbMes.Text = "Mes:";
            this.cbMes.Visible = true;
            this.cbMes.Items.Add("Enero");
            this.cbMes.Items.Add("Febrero");
            this.cbMes.Items.Add("Marzo");
            this.cbMes.Items.Add("Abril");
            this.cbMes.Items.Add("Mayo");
            this.cbMes.Items.Add("Junio");
            this.cbMes.Items.Add("Julio");
            this.cbMes.Items.Add("Agosto");
            this.cbMes.Items.Add("Septiembre");
            this.cbMes.Items.Add("Octubre");
            this.cbMes.Items.Add("Noviembre");
            this.cbMes.Items.Add("Diciembre");
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnBuscar.Enabled = true;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            
            if (this.cbBuscar.SelectedItem.ToString() == "Día")
            {
                this.bandera = 1;
                fecha = Convert.ToDateTime(this.dtpDia.Value.ToString("dd/MM/yyyy"));             
                this.dgvControles.DataSource = controlAnimalNegocio.ProduccionPorFiltroDia(idtambo,fecha);
                if (this.dgvControles.Rows.Count != 0 && this.dgvControles.Rows != null)
                {
                    this.btnExportar.Enabled = true;
                }
                else
                {
                    this.btnExportar.Enabled = false;
                }
            }
            else if (this.cbBuscar.SelectedItem.ToString() == "Mes")
            {
                this.bandera = 2;

                año = Convert.ToInt32(this.cbAño.SelectedItem.ToString());

                mes = this.cbMes.SelectedIndex + 01;

                this.dgvControles.DataSource = controlAnimalNegocio.ProduccionPorFiltroMes(idtambo, mes, año);
                if (this.dgvControles.Rows.Count != 0 && this.dgvControles.Rows != null)
                {
                    this.btnExportar.Enabled = true;
                }
                else
                {
                    this.btnExportar.Enabled = false;
                }
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            if (this.bandera == 0)
            {
                vpProduccionPorFechaDia vistaPreviaProduccionPorDia = new vpProduccionPorFechaDia();
                vistaPreviaProduccionPorDia.idtambo = idtambo;
                vistaPreviaProduccionPorDia.bandera = 0;
                vistaPreviaProduccionPorDia.Show();
            }
            else if(this.bandera == 1)
            {
                vpProduccionPorFechaDia vistaPreviaProduccionPorDia = new vpProduccionPorFechaDia();
                vistaPreviaProduccionPorDia.idtambo = idtambo;
                vistaPreviaProduccionPorDia.bandera = 1;
                vistaPreviaProduccionPorDia.fecha = Convert.ToDateTime(this.dtpDia.Value.ToString("dd/MM/yyyy"));
                vistaPreviaProduccionPorDia.Show();
            }
            else if(this.bandera == 2)
            {
                vpProduccionPorFechaMes vistaPreviaProduccionPorMes = new vpProduccionPorFechaMes();
                vistaPreviaProduccionPorMes.idtambo = idtambo;
                vistaPreviaProduccionPorMes.mes = mes;
                vistaPreviaProduccionPorMes.año = año;
                vistaPreviaProduccionPorMes.Show();
            }
        }
    }
}
