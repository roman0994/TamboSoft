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
    public partial class GestionTambos : Form
    {
        public int idtambo;
        public GestionTambos(int id_tambo)
        {
            InitializeComponent();
            CargarGrilla(id_tambo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void CargarGrilla(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            this.dgvTambos.DataSource = tamboNegocio.RecuperarOtrosTambos(id_tambo);
            if (this.dgvTambos.Rows.Count != 0 && this.dgvTambos.Rows != null)
            {
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(Convert.ToInt32(this.dgvTambos.CurrentRow.Cells["id_tambo"].Value));

            EdicionOtrosTambos edicionTambo = new EdicionOtrosTambos();
            edicionTambo.txtIdTambo.Text = Convert.ToString(tambo.Id_tambo);
            edicionTambo.txtNombre.Text = tambo.Nombre_tambo;
            edicionTambo.txtSuperficie.Text = Convert.ToString(tambo.Superficie);
            edicionTambo.chkEstado.Checked = tambo.Estado_tambo;
            edicionTambo.cbProvincia.Text = tambo.Nombre_provincia;
            edicionTambo.cbLocalidad.Text = tambo.Nombre_localidad;

            edicionTambo.ShowDialog();
            CargarGrilla(idtambo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            int id = Convert.ToInt32(this.dgvTambos.CurrentRow.Cells["id_tambo"].Value);
            Tambo tambo = tamboNegocio.RecuperarUno(id);
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el tambo " + tambo.Nombre_tambo + "?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tamboNegocio.Eliminar(id);
                MessageBox.Show("El tambo " + tambo.Nombre_tambo + " fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CargarGrilla(idtambo);
            }
        }
    }
}
