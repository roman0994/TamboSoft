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
            try
            {
                Provincia_Negocio provinciaNegocio = new Provincia_Negocio();

                this.cbProvincia.DisplayMember = "nombre_provincia";
                this.cbProvincia.ValueMember = "id_provincia";
                this.cbProvincia.DataSource = provinciaNegocio.RecuperarTodos();
                this.cbProvincia.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarComboLocalidad(Convert.ToInt32(this.cbProvincia.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public void CargarComboLocalidad(int id_provincia)
        {
            try
            {
                Localidad_Negocio localidadNegocio = new Localidad_Negocio();
                this.cbLocalidad.DataSource = localidadNegocio.RecuperarPorProvincia(id_provincia);
                this.cbLocalidad.DisplayMember = "nombre_localidad";
                this.cbLocalidad.ValueMember = "id_localidad";
                this.cbLocalidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = new Tambo();
                tambo = tamboNegocio.RecuperarUno(id_tambo);
                this.txtTambo.Text = tambo.Nombre_tambo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones validaciones = new Validaciones();
                bool validar = validaciones.ValidarCargaPersonal(cbLocalidad.SelectedIndex, cbProvincia.SelectedIndex, txtNombre.Text, txtDireccion.Text, txtDni.Text);

                if (validar == true)
                {
                    if (txtDni.Text.Length == 7 || txtDni.Text.Length == 8)
                    {
                        if ((txtTelefono.Text.Length >= 8 && txtTelefono.Text.Length <= 12) || txtTelefono.Text == string.Empty)
                        {
                            //Agrego el nuevo inseminador y en el método de insertar, agrego la relacion del tambo inseminador
                            Tambo tambo = new Tambo();
                            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                            tambo = Principal.Tambo;
                            Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
                            Inseminador inseminador = new Inseminador();
                            inseminador = MapearAInseminador();
                            Tambo_Inseminador tamboInseminador = new Tambo_Inseminador();
                            tamboInseminador.Id_tambo = tambo.Id_tambo;
                            inseminadorNegocio.Insertar(inseminador, tamboInseminador);

                            DialogResult result = MessageBox.Show("El personal fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Limpiar();

                            Principal.Tambo.Inseminadores = inseminadorNegocio.RecuperarPorTambo(Principal.Tambo.Id_tambo);
                        }
                        else
                        {
                            MessageBox.Show("El campo Teléfono no es válido. Debe ingresar código de área + nro de teléfono (sin el 0 ni el 15)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

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
            try
            {
                this.txtNombre.Text = string.Empty;
                this.txtTelefono.Text = string.Empty;
                this.txtDireccion.Text = string.Empty;
                this.txtDni.Text = string.Empty;
                this.cbProvincia.SelectedIndex = -1;
                this.cbLocalidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void AltaPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (HayCamposModificados())
                {
                    DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public bool HayCamposModificados()
        {
            if (txtNombre.Text == string.Empty && txtTelefono.Text == string.Empty && txtDireccion.Text == string.Empty && txtDni.Text == string.Empty && cbLocalidad.SelectedIndex == -1 && cbProvincia.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}