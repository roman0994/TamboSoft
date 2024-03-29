﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Escritorio
{
    public partial class ListadoControles : Form
    {
        public int idtambo;
        public ListadoControles(int id_tambo)
        {
            InitializeComponent();
            CargarGrilla(id_tambo);

        }

        public void CargarGrilla(int id_tambo)
        {
            try
            {
                Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
                this.dgvControles.AutoGenerateColumns = false;
                this.dgvControles.DataSource = controlAnimalNegocio.RecuperarPorTambo(id_tambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbsRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                AltaControles altaControles = new AltaControles(idtambo);
                altaControles.ShowDialog();
                this.CargarGrilla(idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tbsExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvControles.Rows.Count != 0 && this.dgvControles.Rows != null)
                {
                    ExportarAExcel exportarAExcel = new ExportarAExcel();
                    exportarAExcel.Exportar(this.dgvControles, ListadoControles.ActiveForm.Text);
                }
                else
                {
                    Tambo tambo = new Tambo();
                    Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                    tambo = tambo_Negocio.RecuperarUno(idtambo);
                    MessageBox.Show("No se encontraron controles en el tambo " + tambo.Nombre_tambo, "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tstxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Control_Animal_Negocio controlNegocio = new Control_Animal_Negocio();
                this.dgvControles.DataSource = controlNegocio.FiltrarPorNombre(this.tstxtBuscar.Text, idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvControles.Rows.Count != 0 && this.dgvControles.Rows != null)
                {
                    this.CargarGrilla(Convert.ToInt32(idtambo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvControles.Rows.Count != 0 && this.dgvControles.Rows != null)
                {
                    //vpListadoControles vistaPreviaListadoControles = new vpListadoControles();
                    //vistaPreviaListadoControles.idtambo = idtambo;
                    //vistaPreviaListadoControles.Show();
                    vpListadoControlesPorFecha vp = new vpListadoControlesPorFecha();
                    vp.Show();
                }
                else
                {
                    Tambo tambo = new Tambo();
                    Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                    tambo = tambo_Negocio.RecuperarUno(idtambo);
                    MessageBox.Show("No se encontraron controles en el tambo " + tambo.Nombre_tambo, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
