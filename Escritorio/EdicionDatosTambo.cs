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
using Negocio;
using Entidades;

namespace Escritorio
{
    public partial class EdicionDatosTambo : Form
    {
        public Tambo tamboGlobal;

        public EdicionDatosTambo()
        {
            InitializeComponent();
            CargarComboProvincia();
            CargarTolTip();
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

        public void CargarTolTip()
        {
            try
            {
                toolTipTambo.SetToolTip(this.txtSuperficie, "Formato de ingreso : XX,XX");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones validaciones = new Validaciones();
                bool validar = validaciones.ValidarEdicionTambos(cbProvincia.SelectedIndex, cbLocalidad.SelectedIndex, txtNombre.Text, txtSuperficie.Text);

                if (validar == true)
                {
                    if (validaciones.ValidarDecimalSuperficieTambo(txtSuperficie.Text) == true)
                    {
                        Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                        Tambo tambo = new Tambo();
                        tambo = MapearATambo();
                        tamboNegocio.Actualizar(tambo);
                        DialogResult result = MessageBox.Show("El tambo fue actualizado exitosamente", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("El valor de Superficie no es válido. Puede tener hasta 6 dígitos enteros y 2 decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar los campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public Tambo MapearATambo()
        {
            Localidad_Negocio localidadNegocio = new Localidad_Negocio();
            Provincia_Negocio provinciaNegocio = new Provincia_Negocio();
            Localidad localidad = localidadNegocio.RecuperarUno(Convert.ToInt32(cbLocalidad.SelectedValue));
            Provincia provincia = provinciaNegocio.RecuperarUno(Convert.ToInt32(cbProvincia.SelectedValue));
            Tambo tambo = new Tambo();

            tambo.Id_tambo = Convert.ToInt32(txtIdTambo.Text);
            tambo.Nombre_tambo = txtNombre.Text;
            tambo.Superficie = Convert.ToDecimal(txtSuperficie.Text);
            tambo.Id_localidad = localidad.Id_localidad;
            tambo.Nombre_localidad = localidad.Nombre_localidad;
            tambo.Nombre_provincia = provincia.Nombre_provincia;
            tambo.Estado_tambo = true;
            tambo.Id_usuario = Principal.Usuario.Id_usuario;

            return tambo;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar) && (e.KeyChar == (char)Keys.Back) && char.IsSeparator(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void txtSuperficie_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == "," || e.KeyChar == (char)Keys.Back)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void EdicionDatosTambo_FormClosing(object sender, FormClosingEventArgs e)
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
            Localidad_Negocio localidadNegocio = new Localidad_Negocio();
            Localidad localidad = localidadNegocio.RecuperarUno(tamboGlobal.Id_localidad);
            if (txtNombre.Text == tamboGlobal.Nombre_tambo && Convert.ToDecimal(txtSuperficie.Text) == tamboGlobal.Superficie && Convert.ToInt32(cbProvincia.SelectedValue) == localidad.Id_provincia && Convert.ToInt32(cbLocalidad.SelectedValue) == tamboGlobal.Id_localidad)
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
