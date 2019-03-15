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
    public partial class AltaPersonal : Form
    {
        Validaciones validaciones = new Validaciones();

        public AltaPersonal(int id_tambo)
        {
            InitializeComponent();
            CargarComboProvincia();
            CargarTextBoxTambo(id_tambo);
        }

        public void CargarComboProvincia()
        {
            Provincia_Negocio provinciaNegocio = new Provincia_Negocio();

            this.cbProvincia.DisplayMember = "nombre_provincia";
            this.cbProvincia.ValueMember = "id_provincia";
            this.cbProvincia.DataSource = provinciaNegocio.RecuperarTodos();
            this.cbProvincia.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();

            if (cbProvincia.SelectedIndex != -1 && cbLocalidad.SelectedIndex != -1 && txtNombre.Text != null && txtNombre.Text != string.Empty && txtDni.Text != null && txtDni.Text != string.Empty)
            {
                if (txtDni.Text.Length == 7 || txtDni.Text.Length == 8)
                {
                    if (txtTelefono.Text.Length >= 8 && txtTelefono.Text.Length <= 12)
                    {
                        //Agrego el nuevo inseminador y en el método de insertar, agrego la relacion del tambo inseminador
                        Tambo tambo = new Tambo();
                        Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                        tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
                        Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
                        Inseminador inseminador = new Inseminador();
                        inseminador = MapearAInseminador();
                        Tambo_Inseminador tamboInseminador = new Tambo_Inseminador();
                        tamboInseminador.Id_tambo = tambo.Id_tambo;
                        inseminadorNegocio.Insertar(inseminador, tamboInseminador);

                        DialogResult result = MessageBox.Show("El personal fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El campo Teléfono no es válido. Ingrese sin el 0 ni el 15 y sin espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El campo DNI debe tener entre 7 y 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            inseminador.Nombre_inseminador = txtNombre.Text;
            inseminador.Estado_inseminador = true;
            inseminador.Telefono = txtTelefono.Text;
            inseminador.Direccion = txtDireccion.Text;
            inseminador.Dni = txtDni.Text;
            inseminador.Id_localidad = localidad.Id_localidad;
            inseminador.Nombre_localidad = localidad.Nombre_localidad;

            return inseminador;
        }

        public void Limpiar()
        { 
            this.txtNombre.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtDni.Text = string.Empty;
            this.cbProvincia.SelectedIndex = -1;
            this.cbLocalidad.SelectedIndex = -1;
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

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "Nombre completo")
            {
                this.txtNombre.Text = "";
                this.txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {
                this.txtNombre.Text = "Nombre completo";
                this.txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (this.txtTelefono.Text == "Sin el 0 ni el 15 y sin espacios")
            {
                this.txtTelefono.Text = "";
                this.txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (this.txtTelefono.Text == "")
            {
                this.txtTelefono.Text = "Sin el 0 ni el 15 y sin espacios";
                this.txtTelefono.ForeColor = Color.Silver;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (this.txtDireccion.Text == "Ej: Libertad 554")
            {
                this.txtDireccion.Text = "";
                this.txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (this.txtDireccion.Text == "")
            {
                this.txtDireccion.Text = "Ej: Libertad 554";
                this.txtDireccion.ForeColor = Color.Silver;
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (this.txtDni.Text == "Debe tener entre 7 y 8 dígitos")
            {
                this.txtDni.Text = "";
                this.txtDni.ForeColor = Color.Black;
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (this.txtDni.Text == "")
            {
                this.txtDni.Text = "Debe tener entre 7 y 8 dígitos";
                this.txtDni.ForeColor = Color.Silver;
            }
        }

        private void AltaPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
