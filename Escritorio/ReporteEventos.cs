using System;
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
    public partial class ReporteEventos : Form
    {
        public int idtambo;
        public ReporteEventos(int id_tambo)
        {
            InitializeComponent();
            this.dgvEventos.AutoGenerateColumns = false;
            CargarTextBoxTambo(id_tambo);
            CargarComboBoxFiltro();
            CargarGrilla(id_tambo);            
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

        public void CargarComboBoxFiltro()
        {
            try
            {
                this.cbFiltro.Items.Add("Vacas en celo");
                this.cbFiltro.Items.Add("Animales enfermos");
                this.cbFiltro.Items.Add("Vacas con parto en los últimos 21 días");
                this.cbFiltro.Items.Add("Vacas servidas en los últimos 21 días");
                this.cbFiltro.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        public void CargarGrilla(int id_tambo)
        {
            try
            {
                if (this.cbFiltro.SelectedIndex == -1)
                {
                    Animal_Negocio animalNegocio = new Animal_Negocio();
                    this.dgvEventos.DataSource = animalNegocio.RecuperarParaReportePorTambo(id_tambo);
                    if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                    {
                        this.btnExportar.Enabled = true;
                    }
                    else
                    {
                        this.btnExportar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo tambo = new Tambo();

                tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
                if (this.cbFiltro.SelectedIndex == -1)
                {
                    this.dgvEventos.DataSource = animalNegocio.RecuperarPorTambo(Principal.Tambo.Id_tambo);
                    if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                    {
                        this.btnExportar.Enabled = true;
                    }
                    else
                    {
                        this.btnExportar.Enabled = false;
                    }
                }
                else if (this.cbFiltro.SelectedItem.ToString() == "Vacas en celo")
                {
                    this.dgvEventos.DataSource = animalNegocio.RecuperarVacasEnCeloPorTambo(tambo.Id_tambo);
                    if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                    {
                        this.btnExportar.Enabled = true;
                    }
                    else
                    {
                        this.btnExportar.Enabled = false;
                    }
                }
                else if (this.cbFiltro.SelectedItem.ToString() == "Animales enfermos")
                {
                    this.dgvEventos.DataSource = animalNegocio.RecuperarAnimalesEnfermosPorTambo(tambo.Id_tambo);
                    if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                    {
                        this.btnExportar.Enabled = true;
                    }
                    else
                    {
                        this.btnExportar.Enabled = false;
                    }
                }
                else if (this.cbFiltro.SelectedItem.ToString() == "Vacas con parto en los últimos 21 días")
                {
                    this.dgvEventos.DataSource = animalNegocio.RecuperarVacasConPartoPorTambo(tambo.Id_tambo);
                    if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                    {
                        this.btnExportar.Enabled = true;
                    }
                    else
                    {
                        this.btnExportar.Enabled = false;
                    }
                }
                else if (this.cbFiltro.SelectedItem.ToString() == "Vacas servidas en los últimos 21 días")
                {
                    this.dgvEventos.DataSource = animalNegocio.RecuperarVacasServidasPorTambo(tambo.Id_tambo);
                    if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                    {
                        this.btnExportar.Enabled = true;
                    }
                    else
                    {
                        this.btnExportar.Enabled = false;
                    }
                }
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                vpEventos vistaPreviaEventos = new vpEventos();
                vistaPreviaEventos.idtambo = idtambo;
                if (this.cbFiltro.SelectedIndex != -1)
                {
                    vistaPreviaEventos.opcioncombo = this.cbFiltro.SelectedItem.ToString();
                }
                else
                {
                    vistaPreviaEventos.opcioncombo = "vacio";
                }
                vistaPreviaEventos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                this.cbFiltro.SelectedIndex = -1;
                this.CargarGrilla(Principal.Tambo.Id_tambo);
                if (this.dgvEventos.Rows.Count != 0 && this.dgvEventos.Rows != null)
                {
                    this.btnExportar.Enabled = true;
                }
                else
                {
                    this.btnExportar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vpExistencia vp = new vpExistencia();
                vp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }


        /*public void CargarGrillas(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.dgvVacasServidas.DataSource = animalNegocio.RecuperarVacasServidasPorTambo(id_tambo);
            this.dgvVacasParto.DataSource = animalNegocio.RecuperarVacasConPartoPorTambo(id_tambo);
            this.dgvVacasCelo.DataSource = animalNegocio.RecuperarVacasEnCeloPorTambo(id_tambo);
            this.dgvAnimalesEnfermos.DataSource = animalNegocio.RecuperarAnimalesEnfermosPorTambo(id_tambo);
            this.dgvCriasHembra.DataSource = animalNegocio.CantidadCriasHembra(id_tambo);
            this.dgvCriasMacho.DataSource = animalNegocio.CantidadCriasMacho(id_tambo);
            this.dgvCriasMuertas.DataSource = animalNegocio.CantidadCriasMuertas(id_tambo);
        }*/
    }
}
