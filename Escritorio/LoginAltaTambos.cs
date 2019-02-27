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
    public partial class LoginAltaTambos : Form
    {
        public LoginAltaTambos()
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

        public void CargarComboLocalidad(int id_provincia)
        {
            Localidad_Negocio localidadNegocio = new Localidad_Negocio();
            this.cbLocalidad.DataSource = localidadNegocio.RecuperarPorProvincia(id_provincia);
            this.cbLocalidad.DisplayMember = "nombre_localidad";
            this.cbLocalidad.ValueMember = "id_localidad";
            this.cbLocalidad.SelectedIndex = -1;
        }

        public void CargarToolTip()
        {
            toolTipTambo.SetToolTip(this.txtSuperficie, "Formato de ingreso : XX,XX");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarCargaTambos(cbProvincia.SelectedIndex, cbLocalidad.SelectedIndex, txtNombre.Text, txtSuperficie.Text);

            if (validar == true)
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = new Tambo();
                tambo = MapearATambo();
                tamboNegocio.Insertar(tambo);
                DialogResult result = MessageBox.Show("El tambo fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Login login = new Login();
                login.ShowDialog();
                this.Hide();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboLocalidad(Convert.ToInt32(this.cbProvincia.SelectedValue));
        }
    }
}
