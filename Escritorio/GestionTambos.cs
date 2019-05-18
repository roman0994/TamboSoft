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
using System.Text.RegularExpressions;

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
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                this.dgvTambos.AutoGenerateColumns = false;
                this.dgvTambos.DataSource = tamboNegocio.RecuperarOtrosTambos(id_tambo, Principal.Usuario.Id_usuario);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = new Tambo();
                tambo = tamboNegocio.RecuperarUno(Convert.ToInt32(this.dgvTambos.CurrentRow.Cells["id_tambo"].Value));

                EdicionOtrosTambos edicionTambo = new EdicionOtrosTambos();
                edicionTambo.txtIdTambo.Text = Convert.ToString(tambo.Id_tambo);
                edicionTambo.txtNombre.Text = tambo.Nombre_tambo;
                edicionTambo.txtSuperficie.Text = Convert.ToString(tambo.Superficie);
                edicionTambo.cbProvincia.Text = tambo.Nombre_provincia;
                edicionTambo.cbLocalidad.Text = tambo.Nombre_localidad;

                edicionTambo.tamboGlobal = MapearATambo();
                edicionTambo.Show();
                CargarGrilla(idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public Tambo MapearATambo()
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(Convert.ToInt32(this.dgvTambos.CurrentRow.Cells["id_tambo"].Value));

            tambo.Id_tambo = Convert.ToInt32(tambo.Id_tambo);
            tambo.Nombre_tambo = Convert.ToString(tambo.Nombre_tambo);
            tambo.Superficie = Convert.ToDecimal(tambo.Superficie);
            tambo.Nombre_provincia = Convert.ToString(tambo.Nombre_provincia);
            tambo.Nombre_localidad = Convert.ToString(tambo.Nombre_localidad);
            tambo.Id_usuario = Principal.Usuario.Id_usuario;
            return tambo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                int id = Convert.ToInt32(this.dgvTambos.CurrentRow.Cells["id_tambo"].Value);
                Tambo tambo = tamboNegocio.RecuperarUno(id);
                DialogResult result = MessageBox.Show("ATENCIÓN!! Al eliminar el tambo " + tambo.Nombre_tambo + ", también eliminará todo su personal, animales, controles y eventos asociados. ¿Desea continuar?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    tamboNegocio.Eliminar(id);
                    this.CargarGrilla(idtambo);
                    MessageBox.Show("El tambo " + tambo.Nombre_tambo + " fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                this.dgvTambos.DataSource = tamboNegocio.FiltrarPorNombre(this.txtBuscar.Text, idtambo, Principal.Usuario.Id_usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void GestionTambos_Activated(object sender, EventArgs e)
        {
            this.CargarGrilla(Principal.Tambo.Id_tambo);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsSeparator(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
