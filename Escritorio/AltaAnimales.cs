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
using Util;

namespace Escritorio
{
    public partial class AltaAnimales : Form
    {
        public AltaAnimales(int id_tambo)
        {
            InitializeComponent();
            CargarComboEstado();
            CargaComboCategoria();
            CargarTextBoxTambo(id_tambo);
            CargaComboRaza();
        }

        public void CargarComboEstado()
        {
            cbEstado.Items.Add("Vendido");
            cbEstado.Items.Add("Vivo");
            cbEstado.Items.Add("Muerto");
            cbEstado.SelectedIndex = 1;
        }

        public void CargaComboCategoria()
        {
            cbCategoria.Items.Add("Vaca");
            cbCategoria.Items.Add("Toro");
            cbCategoria.SelectedIndex = -1;
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        public void CargaComboRaza()
        {
            Raza_Negocio razaNegocio = new Raza_Negocio();
            this.cbRaza.DataSource = razaNegocio.RecuperarTodos();
            this.cbRaza.DisplayMember = "nombre_raza";
            this.cbRaza.ValueMember = "id_raza";
            this.cbRaza.SelectedIndex = -1;
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbCategoria.SelectedItem.ToString() == "Vaca")
            {
                //Si elije vaca, solo puede ser hembra
                cbSexo.Items.Clear();
                cbSexo.Items.Add("Hembra");
                cbSexo.SelectedIndex = 0;
            }
            else if(this.cbCategoria.SelectedItem.ToString() == "Toro")
            {
                //Si elije toro, solo puede ser macho
                cbSexo.Items.Clear();
                cbSexo.Items.Add("Macho");
                cbSexo.SelectedIndex = 0;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarCargaAnimales(cbCategoria.SelectedIndex,cbSexo.SelectedIndex,cbRaza.SelectedIndex,txtEdad.Text,txtNombre.Text,txtHBA.Text);

            if(validar == true)
            {
                Animal_Negocio animal_Negocio = new Animal_Negocio();
                Animal animal = new Animal();
                animal = MapearAAnimal();
                animal_Negocio.Insertar(animal);
                MessageBox.Show("El animal fue dado de alta exitosamente","Alta" ,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("Debe completar los campos vacíos","Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Animal MapearAAnimal()
        {
            Raza_Negocio razaNegocio = new Raza_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Raza raza = razaNegocio.RecuperarUno(Convert.ToInt32(cbRaza.SelectedValue));
            Tambo tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
            Animal animal = new Animal();

            animal.Fecha_nacimiento = dtpFechaNacimiento.Value.Date;
            animal.Edad = Convert.ToInt32(txtEdad.Text);
            animal.Foto = txtFoto.Text;
            animal.Nombre_animal = txtNombre.Text;
            animal.Estado_animal = "Vivo";
            animal.Hba = Convert.ToInt32(txtHBA.Text);
            animal.Categoria = cbCategoria.SelectedItem.ToString();
            animal.Sexo = cbSexo.SelectedItem.ToString();
            animal.Rp_madre = Convert.ToInt32(txtRPMadre.Text);
            animal.Rp_padre = Convert.ToInt32(txtRPPadre.Text);
            animal.Hba_madre = Convert.ToInt32(txtHBAMadre.Text);
            animal.Hba_padre = Convert.ToInt32(txtHBAPadre.Text);
            animal.Id_tambo = tambo.Id_tambo;
            animal.Id_raza = raza.Id_raza;
            animal.Habilitado = chkHabilitado.Checked;

            return animal;
        }

        public void Limpiar()
        {
            this.dtpFechaNacimiento.Text = string.Empty;
            this.txtEdad.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtHBA.Text = string.Empty;
            this.txtHBAMadre.Text = string.Empty;
            this.txtHBAPadre.Text = string.Empty;
            this.txtRPMadre.Text = string.Empty;
            this.txtRPPadre.Text = string.Empty;
            this.cbSexo.Text = string.Empty;
            this.cbCategoria.Text = string.Empty;
            this.cbRaza.SelectedValue = -1;
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHBA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRPMadre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHBAMadre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRPPadre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHBAPadre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (this.txtEdad.Text == "Edad del animal")
            {
                this.txtEdad.Text = "";
                this.txtEdad.ForeColor = Color.Black;
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (this.txtEdad.Text == "")
            {
                this.txtEdad.Text = "Edad del animal";
                this.txtEdad.ForeColor = Color.Silver;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "Nombre del animal")
            {
                this.txtNombre.Text = "";
                this.txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {
                this.txtNombre.Text = "Nombre del animal";
                this.txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtHBA_Enter(object sender, EventArgs e)
        {
            if (this.txtHBA.Text == "Código numérico")
            {
                this.txtHBA.Text = "";
                this.txtHBA.ForeColor = Color.Black;
            }
        }

        private void txtHBA_Leave(object sender, EventArgs e)
        {
            if (this.txtHBA.Text == "")
            {
                this.txtHBA.Text = "Código numérico";
                this.txtHBA.ForeColor = Color.Silver;
            }
        }

        private void txtRPMadre_Enter(object sender, EventArgs e)
        {
            if (this.txtRPMadre.Text == "Código numérico")
            {
                this.txtRPMadre.Text = "";
                this.txtRPMadre.ForeColor = Color.Black;
            }
        }

        private void txtRPMadre_Leave(object sender, EventArgs e)
        {
            if (this.txtRPMadre.Text == "")
            {
                this.txtRPMadre.Text = "Código numérico";
                this.txtRPMadre.ForeColor = Color.Silver;
            }
        }

        private void txtHBAMadre_Enter(object sender, EventArgs e)
        {
            if (this.txtHBAMadre.Text == "Código numérico")
            {
                this.txtHBAMadre.Text = "";
                this.txtHBAMadre.ForeColor = Color.Black;
            }
        }

        private void txtHBAMadre_Leave(object sender, EventArgs e)
        {
            if (this.txtHBAMadre.Text == "")
            {
                this.txtHBAMadre.Text = "Código numérico";
                this.txtHBAMadre.ForeColor = Color.Silver;
            }
        }

        private void txtRPPadre_Enter(object sender, EventArgs e)
        {
            if (this.txtRPPadre.Text == "Código numérico")
            {
                this.txtRPPadre.Text = "";
                this.txtRPPadre.ForeColor = Color.Black;
            }
        }

        private void txtRPPadre_Leave(object sender, EventArgs e)
        {
            if (this.txtRPPadre.Text == "")
            {
                this.txtRPPadre.Text = "Código numérico";
                this.txtRPPadre.ForeColor = Color.Silver;
            }
        }

        private void txtHBAPadre_Enter(object sender, EventArgs e)
        {
            if (this.txtHBAPadre.Text == "Código numérico")
            {
                this.txtHBAPadre.Text = "";
                this.txtHBAPadre.ForeColor = Color.Black;
            }
        }

        private void txtHBAPadre_Leave(object sender, EventArgs e)
        {
            if (this.txtHBAPadre.Text == "")
            {
                this.txtHBAPadre.Text = "Código numérico";
                this.txtHBAPadre.ForeColor = Color.Silver;
            }
        }

        private void AltaAnimales_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
