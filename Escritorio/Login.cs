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
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            this.cbTambo.DataSource = tamboNegocio.RecuperarTodos(Usuario.Id_usuario);
            this.cbTambo.DisplayMember = "nombre_tambo";
            this.cbTambo.ValueMember = "id_tambo";
            this.cbTambo.SelectedIndex = -1;
        }

        public void InicializarbtnIngresar()
        {
            this.btnIngresar.Enabled = false;
        }

        private void cbTambo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnIngresar.Enabled = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            int id_tambo = Convert.ToInt32(this.cbTambo.SelectedValue);
            Tambo.Id_tambo = id_tambo;
            Principal principal = new Principal(id_tambo);
            principal.id_tambo = id_tambo;
            principal.id_usuario =id_usuario;
            principal.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevoTambo_Click(object sender, EventArgs e)
        {
            LoginAltaTambos loginAlta = new LoginAltaTambos();
            loginAlta.Show();
            this.Hide();
        }

        private void lnkRegresarLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.UsuarioSesion = null;
            LoginUsuario login = new LoginUsuario();
            login.Show();
            this.Hide();
        }
    }
}
