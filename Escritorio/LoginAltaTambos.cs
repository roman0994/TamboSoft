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
using Datos;
using static Escritorio.Principal;

namespace Escritorio
{
    public partial class LoginAltaTambos : Form
    {
        public int id_usuario;
        public static Usuario Usuario { get; set; }

        public LoginAltaTambos()
        {
            InitializeComponent();
            CargarComboProvincia();
            CargarToolTip();
            Usuario = new Usuario();
            Usuario.Id_usuario = id_usuario;
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

        public void CargarToolTip()
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones validaciones = new Validaciones();
                bool validar = validaciones.ValidarCargaTambos(cbProvincia.SelectedIndex, cbLocalidad.SelectedIndex, txtNombre.Text, txtSuperficie.Text);

                if (validar == true)
                {
                    if (validaciones.ValidarDecimalSuperficieTambo(txtSuperficie.Text) == true)
                    {
                        Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                        Tambo tambo = new Tambo();
                        int id_tambo;

                        tambo = MapearATambo();
                        id_tambo = tamboNegocio.InsertarDevolviendoID(tambo);
                        DialogResult result = MessageBox.Show("El tambo fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Principal principal = new Principal(id_tambo);
                        principal.id_tambo = id_tambo;
                        principal.id_usuario = id_usuario;
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El valor de Superficie no es válido. Puede tener hasta 6 caracteres enteros y 2 decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tambo.Id_usuario = id_usuario;

            return tambo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                if (tamboNegocio.HayTambos(Program.UsuarioSesion.Id_usuario))
                {
                    CargarTablas cargarTablas = new CargarTablas();
                    cargarTablas.CargaTablasData();
                    Login login = new Login();
                    //login.id_usuario = Program.UsuarioSesion.Id_usuario;
                    login.Show();
                    this.Hide();
                }
                else
                {
                    Program.UsuarioSesion = null;
                    LoginUsuario login = new LoginUsuario();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
