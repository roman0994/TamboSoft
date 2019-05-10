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
    public partial class AltaControles : Form
    {
        public Animal Animal { get; set; }

        public AltaControles(int id_tambo)
        {
            InitializeComponent();

            CargaComboAnimal(id_tambo);
            CargarToolTips();

        }

        public void CargaComboAnimal(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.cbAnimal.DataSource = animalNegocio.RecuperarVacasPorTambo(id_tambo);
            this.cbAnimal.DisplayMember = "caravana";
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarCargaControles(this.cbAnimal.SelectedIndex, this.dtpFechaControl.Value.Date);

            if (validar == true)
            {
                if (validaciones.ValidarFecha(this.dtpFechaControl.Value.Date))
                {
                    if (validaciones.ValidarDecimalControles(txtPrimerControl.Text)==true || txtPrimerControl.Text == string.Empty)
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
                                    controlNegocio.Insertar(control);
                                    MessageBox.Show("El control fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("El valor de Grasa Segundo Control no es válido. Puede tener hasta 2 dígitos enteros y 2 decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El valor de Segundo Control no es válido. Puede tener hasta 2 dígitos enteros y 2 decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El valor de Grasa Primer Control no es válido. Puede tener hasta 2 dígitos enteros y 2 decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor de Primer Control no es válido. Puede tener hasta 2 dígitos enteros y 2 decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            Animal animal = (Animal)cbAnimal.SelectedItem;
            
            Control_Animal control = new Control_Animal();

            control.Fecha_control = dtpFechaControl.Value.Date;
            control.Primer_control = string.IsNullOrEmpty(txtPrimerControl.Text) ? 0 : Convert.ToDecimal(txtPrimerControl.Text);
            control.Segundo_control = string.IsNullOrEmpty(txtSegundoControl.Text) ? 0 : Convert.ToDecimal(txtSegundoControl.Text);
            control.Grasa_primercontrol = string.IsNullOrEmpty(txtGrasaPrimerControl.Text) ? 0 : Convert.ToDecimal(txtGrasaPrimerControl.Text);
            control.Grasa_segundocontrol = string.IsNullOrEmpty(txtGrasaSegundoControl.Text) ? 0 : Convert.ToDecimal(txtGrasaSegundoControl.Text);
            control.Nombre_animal = animal.Nombre_animal;
            control.Rp = animal.Rp;

            return control;
        }

        public void Limpiar()
        {
            this.cbAnimal.SelectedIndex = -1;
            this.txtPrimerControl.Text = string.Empty;
            this.txtSegundoControl.Text = string.Empty;
            this.txtGrasaPrimerControl.Text = string.Empty;
            this.txtGrasaSegundoControl.Text = string.Empty;
            this.dtpFechaControl.Text = string.Empty;

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

        private void AltaControles_FormClosing(object sender, FormClosingEventArgs e)
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
            if (txtPrimerControl.Text == string.Empty && txtSegundoControl.Text == string.Empty && txtGrasaPrimerControl.Text == string.Empty && txtGrasaSegundoControl.Text == string.Empty && cbAnimal.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cbAnimal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbAnimal.SelectedIndex > -1)
            {
                Animal animal = (Animal)cbAnimal.SelectedItem;
                lbNombreAnimal.Text = "Nombre: " + animal.Nombre_animal;
            }
        }
    }
}
