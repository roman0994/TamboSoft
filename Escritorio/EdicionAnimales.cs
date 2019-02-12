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
    public partial class EdicionAnimales : Form
    {
        public EdicionAnimales()
        {
            InitializeComponent();
            CargarComboEstado();
            CargarComboCategoria();
            CargarComboRaza();
        }
        public void CargarComboEstado()
        {
            cbEstado.Items.Add("Vendido");
            cbEstado.Items.Add("Vivo");
            cbEstado.Items.Add("Muerto");
        }
        public void CargarComboCategoria()
        {
            cbCategoria.Items.Add("Vaca");
            cbCategoria.Items.Add("Toro");
        }

        public void CargarComboRaza()
        {
            Raza_Negocio razaNegocio = new Raza_Negocio();
            this.cbRaza.DataSource = razaNegocio.RecuperarTodos();
            this.cbRaza.DisplayMember = "nombre_raza";
            this.cbRaza.ValueMember = "id_raza";
            this.cbRaza.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarEdicionAnimales(cbCategoria.SelectedIndex, cbSexo.SelectedIndex, cbRaza.SelectedIndex, txtEdad.Text, txtNombre.Text, txtHBA.Text);

            if (validar == true)
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                Animal animal = new Animal();
                animal = MapearAAnimal();
                animalNegocio.Actualizar(animal);
                DialogResult result = MessageBox.Show("El animal fue actualizado exitosamente", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Animal MapearAAnimal()
        {
            Raza_Negocio razaNegocio = new Raza_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Raza raza = razaNegocio.RecuperarUno(Convert.ToInt32(cbRaza.SelectedValue));
            Tambo tambo = tamboNegocio.RecuperarPorNombre(txtTambo.Text);
            Animal animal = new Animal();

            animal.Rp = Convert.ToInt32(txtRP.Text);
            animal.Fecha_nacimiento = dtpFechaNacimiento.Value.Date;
            animal.Edad = Convert.ToInt32(txtEdad.Text);
            animal.Foto = txtFoto.Text;
            animal.Nombre_animal = txtNombre.Text;
            animal.Estado_animal = cbEstado.SelectedItem.ToString();
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

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbCategoria.SelectedItem.ToString() == "Vaca")
            {
                //Si elije vaca, solo puede ser hembra
                cbSexo.Items.Clear();
                cbSexo.Items.Add("Hembra");
                cbSexo.SelectedIndex = 0;
            }
            else if (this.cbCategoria.SelectedItem.ToString() == "Toro")
            {
                //Si elije toro, solo puede ser macho
                cbSexo.Items.Clear();
                cbSexo.Items.Add("Macho");
                cbSexo.SelectedIndex = 0;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /*private void EdicionAnimales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
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
        }*/
    }
}
