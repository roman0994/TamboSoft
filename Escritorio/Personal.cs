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
            if (this.dgvPersonal.Rows.Count != 0 && this.dgvPersonal.Rows != null)
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
            Tambo_Inseminador_Negocio tamboNegocio = new Tambo_Inseminador_Negocio();
            Tambo_Inseminador tamboIns = tamboNegocio.RecuperarUno(idtambo, Convert.ToInt32(this.dgvPersonal.CurrentRow.Cells["id_inseminador"].Value));

            EdicionPersonal edicion = new EdicionPersonal(tamboIns);
            edicion.tamboInseminador = tamboIns;
            edicion.Show();
            CargarGrilla(idtambo);
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
                this.CargarGrilla(id_tambo);
                MessageBox.Show("El personal "+ inseminador.Nombre_inseminador + " fue eliminado del tambo "+tambo.Nombre_tambo, "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Tambo tambo = new Tambo();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
            AltaPersonal altaPersonal = new AltaPersonal(tambo.Id_tambo);
            altaPersonal.ShowDialog();
            CargarGrilla(idtambo);
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(Login.Tambo.Id_tambo);
        }

        private void Personal_Activated(object sender, EventArgs e)
        {
            this.CargarGrilla(Login.Tambo.Id_tambo);
        }
    }
}
