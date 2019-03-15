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
    public partial class DatosTambo : Form
    {
        public int idtambo;
        public DatosTambo(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            CargarDatosTambo(id_tambo);
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarDatosTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();

            tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);

            MapearDatos(tambo);
        }

        public void MapearDatos(Tambo tambo)
        {
            txtNombreTambo.Text = tambo.Nombre_tambo;
            txtSuperficie.Text = Convert.ToString(tambo.Superficie);
            chbEstado.Checked = tambo.Estado_tambo;
            txtLocalidad.Text = tambo.Nombre_localidad;
            txtProvincia.Text = tambo.Nombre_provincia;
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo(); 
            tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);

            EdicionDatosTambo edicionTambo = new EdicionDatosTambo();
            edicionTambo.txtIdTambo.Text = Convert.ToString(tambo.Id_tambo);
            edicionTambo.txtNombre.Text = tambo.Nombre_tambo;
            edicionTambo.txtSuperficie.Text = Convert.ToString(tambo.Superficie);
            edicionTambo.chkEstado.Checked = tambo.Estado_tambo;
            edicionTambo.cbProvincia.Text = tambo.Nombre_provincia;
            edicionTambo.cbLocalidad.Text = tambo.Nombre_localidad;

            CargarDatosTambo(tambo.Id_tambo);
            CargarTextBoxTambo(tambo.Id_tambo);

            edicionTambo.Show();
        }

        private void btnNuevoTambo_Click(object sender, EventArgs e)
        {
            AltaTambos altaTambos = new AltaTambos();
            altaTambos.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = tamboNegocio.RecuperarPorNombre(this.txtNombreTambo.Text);
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el tambo " + tambo.Nombre_tambo + "?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tamboNegocio.Eliminar(tambo.Id_tambo);
                MessageBox.Show("El tambo " + tambo.Nombre_tambo + " fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        /*private void btnEliminarTambo_Click(object sender, EventArgs e)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            int id = Convert.ToInt32(this.cbTambo.SelectedValue);
            Tambo tambo = tamboNegocio.RecuperarUno(id);
            DialogResult result = MessageBox.Show("¿Está seguro que desea dar de baja el tambo "+ tambo.Nombre_tambo +"?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tamboNegocio.Eliminar(id);
                MessageBox.Show("El tambo " + tambo.Nombre_tambo + " fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
    }
}
