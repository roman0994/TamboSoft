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
        public Login()
        {
            InitializeComponent();
            CargaComboTambo();
            InicializarbtnIngresar();
            Tambo = new Tambo();
        }

        public void CargaComboTambo()
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            this.cbTambo.DataSource = tamboNegocio.RecuperarTodos();
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
            principal.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
