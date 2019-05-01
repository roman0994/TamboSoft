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
        public Animal animalGlobal;

        public EdicionAnimales()
        {
            InitializeComponent();
            CargarComboEstado();
            CargarComboCategoria();
            CargarComboRaza();
        }
        public void CargarComboEstado()
        {
            cbEstado.Items.Add("Analisis");
            cbEstado.Items.Add("Celo");
            cbEstado.Items.Add("Enfermo");
            cbEstado.Items.Add("Medicado");
            cbEstado.Items.Add("Muerto");
            cbEstado.Items.Add("Parto");
            cbEstado.Items.Add("Preñada");
            cbEstado.Items.Add("Preñada dudosa");
            
            cbEstado.Items.Add("Vendido");
            cbEstado.Items.Add("Vivo");
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
            Animal_Negocio an = new Animal_Negocio();
            Validaciones validaciones = new Validaciones();
            string validar = validaciones.ValidarEdicionAnimales(cbCategoria.SelectedIndex, cbRaza.SelectedIndex,  txtNombre.Text, txtHBA.Text, txtCaravana.Text);

            if (validar == "true")
            {

                if (txtRPMadre.Text.Length <= 6 || txtRPMadre.Text == string.Empty)
                {
                    if (txtRPPadre.Text.Length <= 6 || txtRPPadre.Text == string.Empty)
                    {
                        if (txtHBAMadre.Text.Length <= 6 || txtHBAMadre.Text == string.Empty)
                        {
                            if (txtHBAPadre.Text.Length <= 6 || txtHBAPadre.Text == string.Empty)
                            {
                                if (txtCaravana.Text.Length<=5)
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
                                    MessageBox.Show("El campo Caravana no puede ser mayor a 5 (seis) dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                 MessageBox.Show("El campo HBA Padre no puede ser mayor a 6 (seis) dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo HBA Madre no puede ser mayor a 6 (seis) dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo RP Padre no puede ser mayor a 6 (seis) dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El campo RP Madre no puede ser mayor a 6 (seis) dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(validar, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //animal.Foto = txtFoto.Text;
            animal.Nombre_animal = txtNombre.Text;
            animal.Estado_animal = cbEstado.SelectedItem.ToString();
            animal.Hba = Convert.ToInt32(txtHBA.Text);
            animal.Id_Categoria = ((Categoria)cbCategoria.SelectedItem).Id_Categoria;
            //animal.Sexo = cbSexo.SelectedItem.ToString();
            animal.Rp_madre = Convert.ToInt32(txtRPMadre.Text);
            animal.Rp_padre = Convert.ToInt32(txtRPPadre.Text);
            animal.Hba_madre = Convert.ToInt32(txtHBAMadre.Text);
            animal.Hba_padre = Convert.ToInt32(txtHBAPadre.Text);
            animal.Id_tambo = tambo.Id_tambo;
            animal.Id_raza = raza.Id_raza;
            animal.Habilitado = true;
            animal.Caravana = txtCaravana.Text;

            return animal;
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
            this.Close();
        }

        private void EdicionAnimales_FormClosing(object sender, FormClosingEventArgs e)
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

        public bool HayCamposModificados()
        {
            if (txtNombre.Text == animalGlobal.Nombre_animal  && Convert.ToInt32(txtHBA.Text) == animalGlobal.Hba && Convert.ToInt32(txtHBAMadre.Text) == animalGlobal.Hba_madre && Convert.ToInt32(txtHBAPadre.Text) == animalGlobal.Hba_padre && Convert.ToInt32(txtRPMadre.Text) == animalGlobal.Rp_madre && Convert.ToInt32(txtRPPadre.Text) == animalGlobal.Rp_padre && cbEstado.SelectedItem.ToString() == animalGlobal.Estado_animal && cbCategoria.SelectedItem == animalGlobal.Categoria && Convert.ToInt32(cbRaza.SelectedValue) == animalGlobal.Id_raza && animalGlobal.Fecha_nacimiento == dtpFechaNacimiento.Value.Date)
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
