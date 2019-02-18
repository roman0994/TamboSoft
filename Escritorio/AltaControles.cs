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
        public AltaControles()
        {
            InitializeComponent();
            CargaComboAnimal();
            CargarToolTips();
        }

        public void CargaComboAnimal()
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.cbAnimal.DataSource = animalNegocio.RecuperarTodos();
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
                Control_Animal_Negocio controlNegocio = new Control_Animal_Negocio();
                Control_Animal control = new Control_Animal();
                control = MapearAControlAnimal();
                controlNegocio.Insertar(control);
                MessageBox.Show("El control fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (this.cbAnimal.SelectedIndex == -1) { this.cbAnimal.Focus(); }
                //if (this.dtpFechaControl.Value.Date == null) { this.dtpFechaControl.Focus(); }
                //if (this.txtPrimerControl.Text == "Litros del primer ordeñe. Formato: XX,XX") { this.txtPrimerControl.Focus(); }
                //if (this.txtSegundoControl.Text == "Litros del segundo ordeñe. Formato: XX,XX") { this.txtSegundoControl.Focus(); }
                //if (this.txtPorcentajeGrasa.Text == "Formato: XX,XX") { this.txtPorcentajeGrasa.Focus(); }
                //if (this.txtKgGrasa.Text == "Formato: XX,XX") { this.txtKgGrasa.Focus(); }
            }
        }

        public Control_Animal MapearAControlAnimal()
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Animal animal = animalNegocio.RecuperarUno(Convert.ToInt32(cbAnimal.SelectedValue));
            Control_Animal control = new Control_Animal();

            control.Fecha_control = dtpFechaControl.Value.Date;
            control.Primer_control = string.IsNullOrEmpty(txtPrimerControl.Text) ? 0 : Convert.ToDecimal(txtPrimerControl.Text);
            control.Segundo_control = string.IsNullOrEmpty(txtPrimerControl.Text) ? 0 : Convert.ToDecimal(txtSegundoControl.Text);
            control.Grasa_primercontrol = string.IsNullOrEmpty(txtPrimerControl.Text) ? 0 : Convert.ToDecimal(txtGrasaPrimerControl.Text);
            control.Grasa_segundocontrol = string.IsNullOrEmpty(txtPrimerControl.Text) ? 0 : Convert.ToDecimal(txtGrasaSegundoControl.Text);
            control.Nombre_animal = animal.Nombre_animal;
            control.Rp = animal.Rp;

            return control;
        }

        public void Limpiar()
        {
            this.cbAnimal.Text = string.Empty;
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

        private void txtPrimerControl_Enter(object sender, EventArgs e)
        {
            if (this.txtPrimerControl.Text == "Lts del 1er ordeñe. Formato: XX,XX")
            {
                this.txtPrimerControl.Text = "";
                this.txtPrimerControl.ForeColor = Color.Black;
            }
        }

        private void txtPrimerControl_Leave(object sender, EventArgs e)
        {
            if (this.txtPrimerControl.Text == "")
            {
                this.txtPrimerControl.Text = "Lts del 1er ordeñe. Formato: XX,XX";
                this.txtPrimerControl.ForeColor = Color.Silver;
            }
        }

        private void txtSegundoControl_Enter(object sender, EventArgs e)
        {
            if (this.txtSegundoControl.Text == "Lts del 2do ordeñe. Formato: XX,XX")
            {
                this.txtSegundoControl.Text = "";
                this.txtSegundoControl.ForeColor = Color.Black;
            }
        }

        private void txtSegundoControl_Leave(object sender, EventArgs e)
        {
            if (this.txtSegundoControl.Text == "")
            {
                this.txtSegundoControl.Text = "Lts del 2do ordeñe. Formato: XX,XX";
                this.txtSegundoControl.ForeColor = Color.Silver;
            }
        }

        private void txtPorcentajeGrasa_Enter(object sender, EventArgs e)
        {
            if (this.txtGrasaPrimerControl.Text == "Formato: XX,XX")
            {
                this.txtGrasaPrimerControl.Text = "";
                this.txtGrasaPrimerControl.ForeColor = Color.Black;
            }
        }

        private void txtPorcentajeGrasa_Leave(object sender, EventArgs e)
        {
            if (this.txtGrasaPrimerControl.Text == "")
            {
                this.txtGrasaPrimerControl.Text = "Formato: XX,XX";
                this.txtGrasaPrimerControl.ForeColor = Color.Silver;
            }
        }

        private void txtKgGrasa_Enter(object sender, EventArgs e)
        {
            if (this.txtGrasaSegundoControl.Text == "Formato: XX,XX")
            {
                this.txtGrasaSegundoControl.Text = "";
                this.txtGrasaSegundoControl.ForeColor = Color.Black;
            }
        }

        private void txtKgGrasa_Leave(object sender, EventArgs e)
        {
            if (this.txtGrasaSegundoControl.Text == "")
            {
                this.txtGrasaSegundoControl.Text = "Formato: XX,XX";
                this.txtGrasaSegundoControl.ForeColor = Color.Silver;
            }
        }

        private void AltaControles_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
