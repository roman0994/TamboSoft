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

        public EdicionControles()
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
            tooltipControles.SetToolTip(this.txtPorcentajeGrasa, "Formato de ingreso : XX,XX");
            tooltipControles.SetToolTip(this.txtKgGrasa, "Formato de ingreso : XX,XX");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarEdicionControles(this.cbAnimal.SelectedIndex, this.dtpFechaControl.Value.Date, this.txtPrimerControl.Text, this.txtSegundoControl.Text, this.txtPorcentajeGrasa.Text, this.txtKgGrasa.Text);

            if (validar == true)
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
            control.Primer_control = Convert.ToInt32(txtPrimerControl.Text);
            control.Segundo_control = Convert.ToInt32(txtSegundoControl.Text);
            control.Porcentaje_grasa = Convert.ToDecimal(txtPorcentajeGrasa.Text);
            control.Kg_grasa = Convert.ToDecimal(txtKgGrasa.Text);
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
            DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /*private void EdicionControles_FormClosing(object sender, FormClosingEventArgs e)
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
