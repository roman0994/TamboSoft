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
using SpreadsheetLight;

namespace Escritorio
{
    public partial class ListadoAnimales : Form
    {
        public int idtambo;
        
        public ListadoAnimales(int idtambo)
        {
            InitializeComponent();
            CargarGrilla(idtambo);
        }

        public void CargarGrilla(int idtambo)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                this.dgvAnimales.AutoGenerateColumns = false;
                this.dgvAnimales.DataSource = animalNegocio.RecuperarPorTamboDT(idtambo);

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
                AbmAnimales altaAnimales = new AbmAnimales(Principal.ModoForm.ALTA, null);
                altaAnimales.ShowDialog();
                this.CargarGrilla(idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                this.dgvAnimales.DataSource = animalNegocio.FiltrarPorCaravana(this.tstxtBuscar.Text, idtambo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tbsActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
                {
                    this.CargarGrilla(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tbsExportarAExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
                {
                    ExportarAExcel exportarAExcel = new ExportarAExcel();
                    exportarAExcel.Exportar(this.dgvAnimales, ListadoAnimales.ActiveForm.Text);
                }
                else
                {
                    Tambo tambo = new Tambo();
                    Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                    tambo = tambo_Negocio.RecuperarUno(idtambo);
                    MessageBox.Show("No se encontraron animales en el tambo " + tambo.Nombre_tambo, "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tbsImpresora_Click(object sender, EventArgs e)
        {
            /*VistaPreviaListadoAnimales vistaPreviaListadoAnimales = new VistaPreviaListadoAnimales();

            ReporteListadoAnimales reporteListadoAnimales = new ReporteListadoAnimales();
            vistaPreviaListadoAnimales.crvAnimales.ReportSource = reporteListadoAnimales;
            vistaPreviaListadoAnimales.crvAnimales.Refresh();
            vistaPreviaListadoAnimales.ShowDialog();*/
            try
            {
                if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
                {
                    vpListadoAnimales vistaPreviaListadoAnimales = new vpListadoAnimales();
                    vistaPreviaListadoAnimales.idtambo = idtambo;
                    vistaPreviaListadoAnimales.Show();
                }
                else
                {
                    Tambo tambo = new Tambo();
                    Tambo_Negocio tambo_Negocio = new Tambo_Negocio();
                    tambo = tambo_Negocio.RecuperarUno(idtambo);
                    MessageBox.Show("No se encontraron animales en el tambo " + tambo.Nombre_tambo, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tsbSanidad_Click(object sender, EventArgs e)
        {
            try
            {
                vpListadoSanidad vistaPreviaListadoAnimales = new vpListadoSanidad();

                vistaPreviaListadoAnimales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void tstxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsSeparator(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
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

        private void dgvAnimales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvAnimales.Rows)
                {
                    if (row.Cells["estado_animal"].Value.ToString() == Principal.EstadoAnimales.Muerto.ToString() || row.Cells["estado_animal"].Value.ToString() == Principal.EstadoAnimales.Vendido.ToString())
                    {

                        row.DefaultCellStyle.BackColor = Color.LightGray;

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
