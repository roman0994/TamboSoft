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
    public partial class ReporteProduccionPorAnimal : Form
    {
        public int idtambo;

        public ReporteProduccionPorAnimal(int id_tambo)
        {
            InitializeComponent();
            CargarGrilla(id_tambo);
            CargarTextBoxTambo(id_tambo);
            CargaComboAnimal(id_tambo);
            btnBuscar.Enabled = false;
        }

        public void CargarGrilla(int id_tambo)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            this.dgvProduccionAnimal.DataSource = controlAnimalNegocio.ProduccionPorAnimal(id_tambo);
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();

            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        public void CargaComboAnimal(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error   
            this.cbAnimal.DisplayMember = "nombre_animal";
            this.cbAnimal.ValueMember = "rp";
            this.cbAnimal.DataSource = animalNegocio.RecuperarPorTambo(id_tambo);
            this.cbAnimal.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Animal animal = new Animal();
            animal = animalNegocio.RecuperarUno(Convert.ToInt32(this.cbAnimal.SelectedValue));
            this.dgvProduccionAnimal.DataSource = controlAnimalNegocio.ProduccionPorFiltroAnimal(idtambo, animal.Rp);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarGrilla(idtambo);
            this.cbAnimal.SelectedIndex = -1;
            this.btnBuscar.Enabled = false;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            vpProduccionPorAnimal vistaPreviaProduccionPorAnimal = new vpProduccionPorAnimal();
            vistaPreviaProduccionPorAnimal.idtambo = idtambo;
            if (this.cbAnimal.SelectedIndex != -1)
            {
                vistaPreviaProduccionPorAnimal.opcioncombo = Convert.ToInt32(this.cbAnimal.SelectedValue);
            }
            else
            {
                vistaPreviaProduccionPorAnimal.opcioncombo = -1;
            }
            vistaPreviaProduccionPorAnimal.Show();
        }
    }
}
