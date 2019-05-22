using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class ListaSeleccionAnimal : Form
    {
        Animal_Negocio animalnegocio;
        Raza_Negocio razanegocio;
        Categoria_Negocio categorianegocio;
        public Animal Animal;
        string modoGlobal;

        public ListaSeleccionAnimal(string modo)
        {
            InitializeComponent();
            modoGlobal = modo;
            animalnegocio = new Animal_Negocio();
            razanegocio = new Raza_Negocio();
            categorianegocio = new Categoria_Negocio();
            Animal = new Animal();
            CargarGrilla(modo);
            
        }

        public void CargarGrilla(string modo)
        {
            try
            {
                this.dgvAnimales.AutoGenerateColumns = false;
                if (modo == "Evento")
                {
                    this.dgvAnimales.DataSource = animalnegocio.RecuperarPorTamboDT(Principal.Tambo.Id_tambo);
                }
                else if(modo == "Control")
                {
                    this.dgvAnimales.DataSource = animalnegocio.RecuperarVacasPorTamboDT(Principal.Tambo.Id_tambo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }

        }

        private void MapearAdatos()
        {

            try
            {
                Animal.Raza = new Raza();
                Animal.Raza = razanegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_raza"].Value));
                Animal.Id_raza = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_raza"].Value);
                Animal.Tambo = new Tambo();
                Animal.Tambo = Principal.Tambo;
                Animal.Id_tambo = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value);
                Animal.Categoria = new Categoria();
                Animal.Categoria = categorianegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_categoria"].Value));
                Animal.Id_Categoria = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_categoria"].Value);
                Animal.Habilitado = Convert.ToBoolean(this.dgvAnimales.CurrentRow.Cells["habilitado"].Value);

                Animal.Rp = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp"].Value);
                Animal.Fecha_nacimiento = Convert.ToDateTime(this.dgvAnimales.CurrentRow.Cells["fecha_nacimiento"].Value);

                Animal.Nombre_animal = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["nombre_animal"].Value);
                Animal.Estado_animal = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["estado_animal"].Value);
                Animal.Hba = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba"].Value);
                Animal.Caravana = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["caravana"].Value);


                Animal.Rp_madre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp_madre"].Value);
                Animal.Hba_madre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba_madre"].Value);
                Animal.Rp_padre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp_padre"].Value);
                Animal.Hba_padre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba_padre"].Value);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void tbsActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
                {
                    this.CargarGrilla(modoGlobal);
                }
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



        private void dgvAnimales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    var estado = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["estado_animal"].Value);

                    if (estado == Principal.EstadoAnimales.Muerto.ToString() || estado == Principal.EstadoAnimales.Vendido.ToString())
                    {
                        Animal = null;
                        MessageBox.Show("Debe seleccionar un animal que no haya sido vendido o que esté muerto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MapearAdatos();
                        this.Dispose();
                    }
                }
                else
                {
                    Animal = null;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void ListaSeleccionAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cerrar el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }
    }
}
