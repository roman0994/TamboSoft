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
    public partial class AltaTambos : Form
    {
        public AltaTambos()
        {
            InitializeComponent();
            CargarComboProvincia();
            CargarToolTip();
        }

        public void CargarComboProvincia()
        {
            Provincia_Negocio provinciaNegocio = new Provincia_Negocio();

            this.cbProvincia.DisplayMember = "nombre_provincia";
            this.cbProvincia.ValueMember = "id_provincia";
            this.cbProvincia.DataSource = provinciaNegocio.RecuperarTodos();
            this.cbProvincia.SelectedIndex = -1;
        }

        public void CargarToolTip()
        {
            toolTipTambo.SetToolTip(this.txtSuperficie, "Formato de ingreso : XX,XX");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarCargaTambos(cbProvincia.SelectedIndex, cbLocalidad.SelectedIndex, txtNombre.Text, txtSuperficie.Text);

            if (validar == true)
            {
                if (validaciones.ValidarDecimalSuperficieTambo(txtSuperficie.Text) == true)
                {
                    Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                    Tambo tambo = new Tambo();
                    tambo = MapearATambo();
                    tamboNegocio.Insertar(tambo);
                    DialogResult result = MessageBox.Show("El tambo fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("El valor de Superficie no es válido. Puede tener hasta 6 dígitos enteros y 2 decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Tambo MapearATambo()
        {
            Localidad_Negocio localidadNegocio = new Localidad_Negocio();
            Provincia_Negocio provinciaNegocio = new Provincia_Negocio();
            Localidad localidad = localidadNegocio.RecuperarUno(Convert.ToInt32(cbLocalidad.SelectedValue));
            Provincia provincia = provinciaNegocio.RecuperarUno(Convert.ToInt32(cbProvincia.SelectedValue));
            Tambo tambo = new Tambo();
           
            tambo.Nombre_tambo = txtNombre.Text;
            tambo.Superficie = Convert.ToDecimal(txtSuperficie.Text);
            tambo.Estado_tambo = true;
            tambo.Id_localidad = localidad.Id_localidad;
            tambo.Nombre_localidad = localidad.Nombre_localidad;
            tambo.Nombre_provincia = provincia.Nombre_provincia;

            return tambo;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSuperficie_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AltaTambos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && sender.Equals(btnGuardar) == false)
            {
                if (HayCamposModificados())
                {
                    DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
        }

        public bool HayCamposModificados()
        {
            if(txtNombre.Text == string.Empty && txtSuperficie.Text == string.Empty && cbLocalidad.SelectedIndex == -1 && cbProvincia.SelectedIndex == -1)
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
