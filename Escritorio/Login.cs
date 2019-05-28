using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Escritorio
{
    public partial class Login : Form
    {
        public static Tambo Tambo { get; set; }
        public int id_usuario;
        public static Usuario Usuario { get; set; }

        public Login()
        {
            InitializeComponent();
            
            Tambo = new Tambo();
            Usuario = new Usuario();
            Usuario = Program.UsuarioSesion;
            CargaComboTambo();
            InicializarbtnIngresar();
        }

        public void CargaComboTambo()
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                this.cbTambo.DataSource = tamboNegocio.RecuperarTodos(Usuario.Id_usuario);
                this.cbTambo.DisplayMember = "nombre_tambo";
                this.cbTambo.ValueMember = "id_tambo";
                this.cbTambo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public void InicializarbtnIngresar()
        {
            try
            {
                this.btnIngresar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void cbTambo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnIngresar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_tambo = Convert.ToInt32(this.cbTambo.SelectedValue);
                Tambo.Id_tambo = id_tambo;
                Principal principal = new Principal(id_tambo);
                principal.id_tambo = id_tambo;
                principal.id_usuario = id_usuario;
                principal.Show();
                this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevoTambo_Click(object sender, EventArgs e)
        {
            try
            {
                LoginAltaTambos loginAlta = new LoginAltaTambos();
                loginAlta.id_usuario = id_usuario;
                loginAlta.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void lnkRegresarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Program.UsuarioSesion = null;
                LoginUsuario login = new LoginUsuario();
                login.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
