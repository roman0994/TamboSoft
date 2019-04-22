﻿using System;
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
using System.Text.RegularExpressions;

namespace Escritorio
{
    public partial class GestionControles : Form
    {
        public int idtambo;
        public GestionControles(int id_tambo)
        {
            InitializeComponent();
            CargarGrilla(id_tambo);
        }

        public void CargarGrilla(int id_tambo)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            this.dgvControles.AutoGenerateColumns = false;
            this.dgvControles.DataSource = controlAnimalNegocio.RecuperarPorTambo(id_tambo);
            if (this.dgvControles.Rows.Count != 0 && this.dgvControles.Rows != null)
            {
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Control_Animal_Negocio controlNegocio = new Control_Animal_Negocio();
            this.dgvControles.DataSource = controlNegocio.FiltrarPorNombre(this.txtBuscar.Text,idtambo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();

            DateTime fecha_control = Convert.ToDateTime(this.dgvControles.CurrentRow.Cells["fecha_control"].Value);
            int id_control = Convert.ToInt32(this.dgvControles.CurrentRow.Cells["id_control"].Value);
            int rp = Convert.ToInt32(this.dgvControles.CurrentRow.Cells["rp"].Value);
            
            int id_tambo = Convert.ToInt32(this.dgvControles.CurrentRow.Cells["id_tambo"].Value);
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el control del animal?","Verificación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                controlAnimalNegocio.Eliminar(fecha_control,id_control,rp);
                this.CargarGrilla(id_tambo);
                MessageBox.Show("El control fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Animal animal = animalNegocio.RecuperarUno(Convert.ToInt32(this.dgvControles.CurrentRow.Cells["rp"].Value));
            int id_tambo = Convert.ToInt32(this.dgvControles.CurrentRow.Cells["id_tambo"].Value);

            EdicionControles edicion = new EdicionControles();
            edicion.Animal = animal;
            edicion.txtIdControl.Text = Convert.ToString(this.dgvControles.CurrentRow.Cells["id_control"].Value);
            edicion.dtpFechaControl.Text = Convert.ToString(this.dgvControles.CurrentRow.Cells["fecha_control"].Value);
            edicion.txtPrimerControl.Text = Convert.ToString(this.dgvControles.CurrentRow.Cells["primer_control"].Value);
            edicion.txtSegundoControl.Text = Convert.ToString(this.dgvControles.CurrentRow.Cells["segundo_control"].Value);
            edicion.txtGrasaPrimerControl.Text = Convert.ToString(this.dgvControles.CurrentRow.Cells["grasa_primercontrol"].Value);
            edicion.txtGrasaSegundoControl.Text = Convert.ToString(this.dgvControles.CurrentRow.Cells["grasa_segundocontrol"].Value);
            //edicion.cbAnimal.Text = animal.Nombre_animal;
            edicion.txtCaravana.Text = animal.Caravana;
            edicion.txtNombreAnimal.Text = animal.Nombre_animal;
            edicion.controlAnimalGlobal = MapearAControlAnimal();
            edicion.Show();
            CargarGrilla(id_tambo);

        }

        public Control_Animal MapearAControlAnimal()
        {
            Control_Animal controlAnimal = new Control_Animal();
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Animal animal = animalNegocio.RecuperarUno(Convert.ToInt32(this.dgvControles.CurrentRow.Cells["rp"].Value));

            controlAnimal.Rp = Convert.ToInt32(this.dgvControles.CurrentRow.Cells["rp"].Value);
            controlAnimal.Id_control = Convert.ToInt32(this.dgvControles.CurrentRow.Cells["id_control"].Value);
            controlAnimal.Fecha_control = Convert.ToDateTime(this.dgvControles.CurrentRow.Cells["fecha_control"].Value);
            controlAnimal.Primer_control = Convert.ToDecimal(this.dgvControles.CurrentRow.Cells["primer_control"].Value);
            controlAnimal.Segundo_control = Convert.ToDecimal(this.dgvControles.CurrentRow.Cells["segundo_control"].Value);
            controlAnimal.Grasa_primercontrol = Convert.ToDecimal(this.dgvControles.CurrentRow.Cells["grasa_primercontrol"].Value);
            controlAnimal.Grasa_segundocontrol = Convert.ToDecimal(this.dgvControles.CurrentRow.Cells["grasa_segundocontrol"].Value);
            controlAnimal.Nombre_animal = animal.Nombre_animal;
            return controlAnimal;
        }

        private void GestionControles_Activated(object sender, EventArgs e)
        {
            this.CargarGrilla(Principal.Tambo.Id_tambo);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsSeparator(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
