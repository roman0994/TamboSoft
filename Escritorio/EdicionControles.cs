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
    public partial class EdicionControles : Form
    {
        Validaciones validaciones = new Validaciones();
        public Control_Animal controlAnimalGlobal;

        public EdicionControles()
        {
            InitializeComponent();
            CargaComboAnimal();
            CargarToolTips();
        }

        public void CargaComboAnimal()
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.cbAnimal.DataSource = animalNegocio.RecuperarVacasPorTambo(Login.Tambo.Id_tambo);
            this.cbAnimal.DisplayMember = "nombre_animal";
            this.cbAnimal.ValueMember = "rp";
            this.cbAnimal.SelectedIndex = -1;
        }

        public void CargarToolTips()
        {
            tooltipControles.SetToolTip(this.txtPrimerControl, "Formato de ingreso : XX,XX");
            tooltipControles.SetToolTip(this.txtSegundoControl, "Formato de ingreso : XX,XX");
            tooltipControles.SetToolTip(this.txtGrasaPrimerControl, "Formato de ingreso : XX,XX");
            tooltipControles.SetToolTip(this.txtGrasaSegundoControl, "Formato de ingreso : XX,XX");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarEdicionControles(this.cbAnimal.SelectedIndex, this.dtpFechaControl.Value.Date);

            if (validar == true)
            {
                if (validaciones.ValidarFecha(this.dtpFechaControl.Value.Date))
                {
                    if (validaciones.ValidarDecimalControles(txtPrimerControl.Text) == true || txtPrimerControl.Text == string.Empty)
                    {
                        if (validaciones.ValidarDecimalControles(txtGrasaPrimerControl.Text) == true || txtGrasaPrimerControl.Text == string.Empty)
                        {
                            if (validaciones.ValidarDecimalControles(txtSegundoControl.Text) == true || txtSegundoControl.Text == string.Empty)
                            {
                                if (validaciones.ValidarDecimalControles(txtGrasaSegundoControl.Text) == true || txtGrasaSegundoControl.Text == string.Empty)
                                {
                                    Control_Animal_Negocio controlNegocio = new Control_Animal_Negocio();
                                    Control_Animal control = new Control_Animal();
                                    control = MapearAControlAnimal();
                                    controlNegocio.Actualizar(control);
                                    DialogResult result = MessageBox.Show("El control fue actualizado exitosamente", "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Dispose();
                                }
                                else
                                {
                                    MessageBox.Show("El campo Grasa Segundo Control no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo Segundo Control no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo Grasa Primer Control no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo Primer Control no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La fecha no puede ser mayor a hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Control_Animal MapearAControlAnimal()
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Animal animal = animalNegocio.RecuperarUno(Convert.ToInt32(cbAnimal.SelectedValue));
            Control_Animal control = new Control_Animal();

            control.Id_control = Convert.ToInt32(txtIdControl.Text);
            control.Fecha_control = dtpFechaControl.Value.Date;
            control.Primer_control = string.IsNullOrEmpty(txtPrimerControl.Text) ? 0 : Convert.ToInt32(txtPrimerControl.Text);
            control.Segundo_control = string.IsNullOrEmpty(txtSegundoControl.Text) ? 0 : Convert.ToInt32(txtSegundoControl.Text);
            control.Grasa_primercontrol = string.IsNullOrEmpty(txtPrimerControl.Text) ? 0 : Convert.ToDecimal(txtGrasaPrimerControl.Text);
            control.Grasa_segundocontrol = string.IsNullOrEmpty(txtPrimerControl.Text) ? 0 : Convert.ToDecimal(txtGrasaSegundoControl.Text);
            control.Nombre_animal = animal.Nombre_animal;
            control.Rp = animal.Rp;

            return control;
        }

        private void txtPrimerControl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSegundoControl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPorcentajeGrasa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKgGrasa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EdicionControles_FormClosing(object sender, FormClosingEventArgs e)
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
            if (Convert.ToDecimal(txtPrimerControl.Text) == controlAnimalGlobal.Primer_control && Convert.ToDecimal(txtSegundoControl.Text) == controlAnimalGlobal.Segundo_control && Convert.ToDecimal(txtGrasaPrimerControl.Text) == controlAnimalGlobal.Grasa_primercontrol && Convert.ToDecimal(txtGrasaSegundoControl.Text) == controlAnimalGlobal.Grasa_segundocontrol && Convert.ToInt32(cbAnimal.SelectedValue) == controlAnimalGlobal.Rp && controlAnimalGlobal.Fecha_control == dtpFechaControl.Value.Date)
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
