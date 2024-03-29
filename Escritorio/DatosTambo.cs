﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Entidades;
using Negocio;

namespace Escritorio
{
    public partial class DatosTambo : Form
    {
        public int id_usuario;
        public int idtambo;
        public DatosTambo(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            CargarDatosTambo(id_tambo);
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = new Tambo();
                tambo = tamboNegocio.RecuperarUno(id_tambo);
                this.txtTambo.Text = tambo.Nombre_tambo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarDatosTambo(int id_tambo)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = new Tambo();

                tambo = tamboNegocio.RecuperarUno(Principal.Tambo.Id_tambo);

                MapearDatos(tambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public void MapearDatos(Tambo tambo)
        {
            try
            {
                txtNombreTambo.Text = Convert.ToString(tambo.Nombre_tambo);
                txtSuperficie.Text = Convert.ToString(tambo.Superficie);
                txtLocalidad.Text = Convert.ToString(tambo.Nombre_localidad);
                txtProvincia.Text = Convert.ToString(tambo.Nombre_provincia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = new Tambo();
                tambo = tamboNegocio.RecuperarUno(Principal.Tambo.Id_tambo);

                EdicionDatosTambo edicionTambo = new EdicionDatosTambo();
                edicionTambo.txtIdTambo.Text = Convert.ToString(tambo.Id_tambo);
                edicionTambo.txtNombre.Text = Convert.ToString(tambo.Nombre_tambo);
                edicionTambo.txtSuperficie.Text = Convert.ToString(tambo.Superficie);
                edicionTambo.cbProvincia.Text = Convert.ToString(tambo.Nombre_provincia);
                edicionTambo.cbLocalidad.Text = Convert.ToString(tambo.Nombre_localidad);

                CargarDatosTambo(tambo.Id_tambo);
                CargarTextBoxTambo(tambo.Id_tambo);

                edicionTambo.tamboGlobal = MapearATambo();
                edicionTambo.Show();

                CargarDatosTambo(idtambo);
                CargarTextBoxTambo(idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public Tambo MapearATambo()
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(Principal.Tambo.Id_tambo);
            tambo.Id_tambo = Convert.ToInt32(tambo.Id_tambo);
            tambo.Nombre_tambo = Convert.ToString(tambo.Nombre_tambo);
            tambo.Superficie = Convert.ToDecimal(tambo.Superficie);
            tambo.Id_usuario = Principal.Usuario.Id_usuario; 
            tambo.Nombre_provincia = Convert.ToString(tambo.Nombre_provincia);
            tambo.Nombre_localidad = Convert.ToString(tambo.Nombre_localidad);
            return tambo;
        }

        private void btnNuevoTambo_Click(object sender, EventArgs e)
        {
            try
            {
                AltaTambos altaTambos = new AltaTambos();
                altaTambos.id_usuario = id_usuario;
                altaTambos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = tamboNegocio.RecuperarPorNombre(this.txtNombreTambo.Text);
                DialogResult result = MessageBox.Show("ATENCIÓN!! Al eliminar el tambo " + tambo.Nombre_tambo + ", eliminará todo su personal, animales, controles y eventos asociados. ¿Desea continuar?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    tamboNegocio.Eliminar(tambo.Id_tambo);
                    MessageBox.Show("El tambo " + tambo.Nombre_tambo + " fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void DatosTambo_Activated(object sender, EventArgs e)
        {
            try
            {
                CargarDatosTambo(Principal.Tambo.Id_tambo);
                CargarTextBoxTambo(Principal.Tambo.Id_tambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        /*private void btnEliminarTambo_Click(object sender, EventArgs e)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            int id = Convert.ToInt32(this.cbTambo.SelectedValue);
            Tambo tambo = tamboNegocio.RecuperarUno(id);
            DialogResult result = MessageBox.Show("¿Está seguro que desea dar de baja el tambo "+ tambo.Nombre_tambo +"?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tamboNegocio.Eliminar(id);
                MessageBox.Show("El tambo " + tambo.Nombre_tambo + " fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
    }
}
