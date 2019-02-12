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
    public partial class EdicionPersonal : Form
    {
        Validaciones validaciones = new Validaciones();

        public EdicionPersonal()
        {
            InitializeComponent();
            CargarComboProvincia();
        }

        public void CargarComboProvincia()
        {
            Provincia_Negocio provinciaNegocio = new Provincia_Negocio();

            this.cbProvincia.DisplayMember = "nombre_provincia";
            this.cbProvincia.ValueMember = "id_provincia";
            this.cbProvincia.DataSource = provinciaNegocio.RecuperarTodos();
            this.cbProvincia.SelectedIndex = -1;
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboLocalidad(Convert.ToInt32(this.cbProvincia.SelectedValue));
        }

        public void CargarComboLocalidad(int id_provincia)
        {
            Localidad_Negocio localidadNegocio = new Localidad_Negocio();
            this.cbLocalidad.DataSource = localidadNegocio.RecuperarPorProvincia(id_provincia);
            this.cbLocalidad.DisplayMember = "nombre_localidad";
            this.cbLocalidad.ValueMember = "id_localidad";
            this.cbLocalidad.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            
            if (cbProvincia.SelectedIndex != -1 && cbLocalidad.SelectedIndex != -1 && txtNombre.Text != null && txtNombre.Text != string.Empty && txtDni.Text != null && txtDni.Text != string.Empty)
            {
                if (txtDni.Text.Length == 8)
                {
                    Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
                    Inseminador inseminador = new Inseminador();
                    inseminador = MapearAInseminador();
                    inseminadorNegocio.Actualizar(inseminador);
                    DialogResult result = MessageBox.Show("El personal fue actualizado exitosamente", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("El campo DNI debe tener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Inseminador MapearAInseminador()
        {
            Localidad_Negocio localidadNegocio = new Localidad_Negocio();
            Localidad localidad = localidadNegocio.RecuperarUno(Convert.ToInt32(cbLocalidad.SelectedValue));
            Inseminador inseminador = new Inseminador();

            inseminador.Id_inseminador = Convert.ToInt32(txtIdPersonal.Text);
            inseminador.Nombre_inseminador = txtNombre.Text;
            inseminador.Estado_inseminador = chkEstado.Checked;
            inseminador.Telefono = txtTelefono.Text;
            inseminador.Direccion = txtDireccion.Text;
            inseminador.Dni = txtDni.Text;
            inseminador.Id_localidad = localidad.Id_localidad;
            inseminador.Nombre_localidad = localidad.Nombre_localidad;

            return inseminador;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

