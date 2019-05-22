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

            
            CargarToolTips();

        }

        public void CargarToolTips()
        {
            try
            {
                tooltipControles.SetToolTip(this.txtPrimerControl, "Formato de ingreso : XX,XX");
                tooltipControles.SetToolTip(this.txtSegundoControl, "Formato de ingreso : XX,XX");
                tooltipControles.SetToolTip(this.txtGrasaPrimerControl, "Formato de ingreso : XX,XX");
                tooltipControles.SetToolTip(this.txtGrasaSegundoControl, "Formato de ingreso : XX,XX");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones validaciones = new Validaciones();
                bool validar = validaciones.ValidarCargaControles(Animal, this.dtpFechaControl.Value.Date);

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
                    MessageBox.Show("Debe seleccionar el animal", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public Control_Animal MapearAControlAnimal()
        {

            Animal_Negocio animalNegocio = new Animal_Negocio();

            Animal animal = Animal;
            
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
            try
            {
                lbError.Text = "";
                lbCaravana.Text = "";
                lbNombreAnimal.Text = "";
                Animal = null;
                this.txtPrimerControl.Text = string.Empty;
                this.txtSegundoControl.Text = string.Empty;
                this.txtGrasaPrimerControl.Text = string.Empty;
                this.txtGrasaSegundoControl.Text = string.Empty;
                this.dtpFechaControl.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void txtPrimerControl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSegundoControl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPorcentajeGrasa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKgGrasa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AltaControles_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public bool HayCamposModificados()
        {

            if (txtPrimerControl.Text == string.Empty && txtSegundoControl.Text == string.Empty && txtGrasaPrimerControl.Text == string.Empty && txtGrasaSegundoControl.Text == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                ListaSeleccionAnimal form = new ListaSeleccionAnimal("Control");
                form.ShowDialog();

                if (form.Animal.Rp != 0)
                {
                    Animal = form.Animal;
                    lbError.Text = "";
                    lbCaravana.Text = "Caravana: " + Animal.Caravana;
                    lbNombreAnimal.Text = "Nombre: " + Animal.Nombre_animal;

                }
                else
                {
                    lbNombreAnimal.Text = "";
                    lbCaravana.Text = "";
                    lbError.Text = "Vuelva a seleccionar un animal";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al buscar el animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
