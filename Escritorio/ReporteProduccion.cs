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
    public partial class ReporteProduccion : Form
    {
        public DateTime fecha;
        public int mes;
        public int año;
        public int bandera = 0;
        Control_Animal_Negocio controlAnimalNegocio;

        public ReporteProduccion()
        {
            InitializeComponent();

            CargarComboAño();
            CargarComboMes();
            this.btnExportar.Enabled = false;
            controlAnimalNegocio = new Control_Animal_Negocio();
        }

        public void CargaComboAnimal()
        {
            //Animal_Negocio animalNegocio = new Animal_Negocio();
            ////Asigno primero el displaymember y el valuemember, despues el data source, sino tira error   
            //this.cbAnimal.DisplayMember = "caravana";
            //this.cbAnimal.ValueMember = "caravana";
            //this.cbAnimal.DataSource = animalNegocio.RecuperarVacasPorTambo(Principal.Tambo.Id_tambo);
            //this.cbAnimal.SelectedIndex = -1;
        }

        public void CargarComboBusqueda()
        {
            //this.cbBuscar.Items.Add("Día");
            //this.cbBuscar.Items.Add("Mes");
            //this.cbBuscar.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //this.cbBuscar.Text = "Buscar por:";
            //this.cbAño.Visible = false;
            //this.dtpDia.Visible = false;
            //this.cbMes.Visible = false;
            //this.btnBuscar.Enabled = false;
            //this.bandera = 0;
            //this.cbAnimal.SelectedIndex = -1;
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.cbBuscar.SelectedItem.ToString() == "Día")
            //{
            //    this.cbAño.Visible = false;
            //    this.cbMes.Visible = false;
            //    this.dtpDia.Visible = true;
            //    this.btnBuscar.Enabled = true;
            //    //this.dgvEventos.DataSource = animalNegocio.RecuperarVacasEnCeloPorTambo(tambo.Id_tambo);
            //}
            //else if (this.cbBuscar.SelectedItem.ToString() == "Mes")
            //{
            //    this.dtpDia.Visible = false;
            //    CargarComboAño();
            //    this.cbAño.Text = "Año:";
            //    this.cbAño.Visible = true;
            //    this.btnBuscar.Enabled = false;
            //    //this.dgvEventos.DataSource = animalNegocio.RecuperarAnimalesEnfermosPorTambo(tambo.Id_tambo);
            //}
        }

        public void CargarComboAño()
        {
            try
            {
                for (int i = 2018; i <= 2050; i++)
                {
                    this.cbAño.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboMes();
        }

        public void CargarComboMes()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //this.btnBuscar.Enabled = true;
                this.btnExportar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cbBuscar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            //int rp = Convert.ToInt32(this.cbAnimal.SelectedValue); 
            //if (this.cbBuscar.SelectedItem.ToString() == "Día")
            //{
            //    this.bandera = 1;
            //    fecha = Convert.ToDateTime(this.dtpDia.Value.ToString("dd/MM/yyyy"));
            //    this.dgvProduccion.DataSource = controlAnimalNegocio.ProduccionPorFiltroDiaYAnimal(Principal.Tambo.Id_tambo, fecha, rp);
            //    if (this.dgvProduccion.Rows.Count != 0 && this.dgvProduccion.Rows != null)
            //    {
            //        this.btnExportar.Enabled = true;
            //    }
            //    else
            //    {
            //        this.btnExportar.Enabled = false;
            //    }
            //}
            //else if (this.cbBuscar.SelectedItem.ToString() == "Mes")
            //{
            //    this.bandera = 2;

            //    año = Convert.ToInt32(this.cbAño.SelectedItem.ToString());

            //    mes = this.cbMes.SelectedIndex + 01;

            //    this.dgvProduccion.DataSource = controlAnimalNegocio.ProduccionPorFiltroMesYAnimal(Principal.Tambo.Id_tambo, mes, año, rp);
            //    if (this.dgvProduccion.Rows.Count != 0 && this.dgvProduccion.Rows != null)
            //    {
            //        this.btnExportar.Enabled = true;
            //    }
            //    else
            //    {
            //        this.btnExportar.Enabled = false;
            //    }
            //}
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                año = Convert.ToInt32(this.cbAño.SelectedItem.ToString());

                mes = this.cbMes.SelectedIndex + 01;
                if (controlAnimalNegocio.HayControlesMes(mes, año, Principal.Tambo.Id_tambo))
                {
                    vpProduccionPorFechaMes vp = new vpProduccionPorFechaMes(mes, año);
                    vp.Show();
                }
                else
                {
                    MessageBox.Show("No se encontraron controles en el intervalo de fechas ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            //Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            ////int rp = Convert.ToInt32(this.cbAnimal.SelectedValue);
            //if (this.bandera == 1)
            //{
            //    vpProduccionPorFechaDia vistaPreviaProduccionPorDia = new vpProduccionPorFechaDia();
            //    vistaPreviaProduccionPorDia.idtambo = Principal.Tambo.Id_tambo;
            //    vistaPreviaProduccionPorDia.bandera = 1;
            //    vistaPreviaProduccionPorDia.rp = rp;
            //    vistaPreviaProduccionPorDia.fecha = Convert.ToDateTime(this.dtpDia.Value.ToString("dd/MM/yyyy"));
            //    vistaPreviaProduccionPorDia.Show();
            //}
            //else if (this.bandera == 2)
            //{
            //    vpProduccionPorFechaMes vistaPreviaProduccionPorMes = new vpProduccionPorFechaMes();
            //    vistaPreviaProduccionPorMes.idtambo = Principal.Tambo.Id_tambo;
            //    vistaPreviaProduccionPorMes.mes = mes;
            //    vistaPreviaProduccionPorMes.año = año;
            //    vistaPreviaProduccionPorMes.rp = rp;
            //    vistaPreviaProduccionPorMes.Show();
            //}
        }

        private void cbAnimal_SelectionChangeCommitted(object sender, EventArgs e)
        {
        //    if (cbAnimal.SelectedIndex != -1)
        //    {
        //        Animal animal = new Animal();
        //        animal = (Animal)this.cbAnimal.SelectedItem;
        //        lbNombreAnimal.Text = animal.Nombre_animal;
        //    }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
