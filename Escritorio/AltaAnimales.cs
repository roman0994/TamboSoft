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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarCargaAnimales(cbCategoria.SelectedIndex,cbRaza.SelectedIndex,txtEdad.Text,txtNombre.Text,txtHBA.Text);

            if(validar == true) 
            {
                if (txtEdad.Text.Length <= 3)
                {
                    if (txtHBA.Text.Length <= 6)
                    {
                        if (txtRPMadre.Text.Length<=6 || txtRPMadre.Text == string.Empty)
                        {
                            if (txtRPPadre.Text.Length <= 6 || txtRPPadre.Text == string.Empty)
                            {
                                if (txtHBAMadre.Text.Length <= 6 || txtHBAMadre.Text == string.Empty)
                                {
                                    if (txtHBAPadre.Text.Length <= 6 || txtHBAPadre.Text == string.Empty)
                                    {
                                        Animal_Negocio animal_Negocio = new Animal_Negocio();
                                        Animal animal = new Animal();
                                        animal = MapearAAnimal();
                                        animal_Negocio.Insertar(animal);
                                        MessageBox.Show("El animal fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        this.Limpiar();
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
                        MessageBox.Show("El campo HBA no puede ser mayor a 6 (seis) dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El valor del campo Edad no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            //animal.Foto = txtFoto.Text;
            animal.Nombre_animal = txtNombre.Text;
            animal.Estado_animal = "Vivo";
            animal.Hba = Convert.ToInt32(txtHBA.Text);
            animal.Categoria = cbCategoria.SelectedItem.ToString();
            //animal.Sexo = cbSexo.SelectedItem.ToString();
            animal.Rp_madre = string.IsNullOrEmpty(txtRPMadre.Text) ? 0 : Convert.ToInt32(txtRPMadre.Text);
            animal.Rp_padre = string.IsNullOrEmpty(txtRPPadre.Text) ? 0 : Convert.ToInt32(txtRPPadre.Text);
            animal.Hba_madre = string.IsNullOrEmpty(txtHBAMadre.Text) ? 0 : Convert.ToInt32(txtHBAMadre.Text);
            animal.Hba_padre = string.IsNullOrEmpty(txtHBAPadre.Text) ? 0 : Convert.ToInt32(txtHBAPadre.Text);
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
            this.cbCategoria.SelectedIndex = -1;
            this.cbRaza.SelectedIndex = -1;
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

        private void AltaAnimales_FormClosing(object sender, FormClosingEventArgs e)
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
            if (txtNombre.Text == string.Empty && txtEdad.Text == string.Empty && txtHBA.Text == string.Empty && txtRPMadre.Text == string.Empty && txtRPPadre.Text == string.Empty && txtHBAMadre.Text == string.Empty && txtHBAPadre.Text == string.Empty && cbCategoria.SelectedIndex == -1 && cbRaza.SelectedIndex == -1)
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
