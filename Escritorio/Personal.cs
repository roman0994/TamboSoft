using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Entidades;
using Negocio;

namespace Escritorio
{
    public partial class Personal : Form
    {
        public int idtambo;

        public Personal(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            CargarGrilla(id_tambo);
            InicializarBotones();
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void CargarGrilla(int id_tambo)
        {
            Tambo_Inseminador_Negocio tamboInseminadorNegocio = new Tambo_Inseminador_Negocio();
            this.dgvPersonal.DataSource = tamboInseminadorNegocio.RecuperarPorTambo(id_tambo);
        }

        private void InicializarBotones()
        {
            if(this.dgvPersonal.SelectedRows != null)
            {
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Localidad_Negocio localidadNegocio = new Localidad_Negocio();
            Localidad localidad = localidadNegocio.RecuperarUno(Convert.ToInt32(this.dgvPersonal.CurrentRow.Cells["id_localidad"].Value));
            
            EdicionPersonal edicion = new EdicionPersonal();

            edicion.txtIdPersonal.Text = Convert.ToString(this.dgvPersonal.CurrentRow.Cells["id_inseminador"].Value);
            edicion.txtIdTambo.Text = Convert.ToString(this.dgvPersonal.CurrentRow.Cells["id_tambo"].Value);
            edicion.txtTambo.Text = Convert.ToString(this.dgvPersonal.CurrentRow.Cells["nombre_tambo"].Value);
            edicion.txtNombre.Text = Convert.ToString(this.dgvPersonal.CurrentRow.Cells["nombre_inseminador"].Value);
            edicion.chkEstado.Checked = Convert.ToBoolean(this.dgvPersonal.CurrentRow.Cells["estado_inseminador"].Value);
            edicion.txtTelefono.Text = Convert.ToString(this.dgvPersonal.CurrentRow.Cells["telefono"].Value);
            edicion.txtDireccion.Text = Convert.ToString(this.dgvPersonal.CurrentRow.Cells["direccion"].Value);
            edicion.txtDni.Text = Convert.ToString(this.dgvPersonal.CurrentRow.Cells["dni"].Value);
            edicion.cbProvincia.Text = localidad.Nombre_provincia;
            edicion.cbLocalidad.Text = Convert.ToString(this.dgvPersonal.CurrentRow.Cells["nombre_localidad"].Value);

            edicion.ShowDialog();
            CargarGrilla(Convert.ToInt32(this.dgvPersonal.CurrentRow.Cells["id_tambo"].Value));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Busco el tambo inseminador
            Tambo_Inseminador_Negocio tamboInseminadorNegocio = new Tambo_Inseminador_Negocio();
            int id_tambo = Convert.ToInt32(this.dgvPersonal.CurrentRow.Cells["id_tambo"].Value);
            int id_inseminador = Convert.ToInt32(this.dgvPersonal.CurrentRow.Cells["id_inseminador"].Value);

            //Busco el inseminador individual y el tambo
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(idtambo);

            Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
            Inseminador inseminador = inseminadorNegocio.RecuperarUno(id_inseminador);

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el personal "+ inseminador.Nombre_inseminador +" del tambo "+ tambo.Nombre_tambo +"?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tamboInseminadorNegocio.Eliminar(id_inseminador);
                MessageBox.Show("El personal "+ inseminador.Nombre_inseminador + " fue eliminado del tambo "+tambo.Nombre_tambo, "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CargarGrilla(id_tambo);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Tambo tambo = new Tambo();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
            AltaPersonal altaPersonal = new AltaPersonal(tambo.Id_tambo);
            altaPersonal.ShowDialog();
            //CargarGrilla(Convert.ToInt32(this.dgvPersonal.CurrentRow.Cells["id_tambo"].Value));
        }
    }
}
