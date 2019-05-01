using Entidades;
using Negocio;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace Escritorio
{
    public partial class GestionAnimales : Form
    {
        public int idtambo;
        public Animal Animal { get; set; }
        Raza_Negocio razanegocio;
        Tambo_Negocio tambonegocio;
        Categoria_Negocio categorianegocio;

        public GestionAnimales(int id_tambo)
        {
            InitializeComponent();
            Animal = new Animal();
            razanegocio = new Raza_Negocio();
            tambonegocio = new Tambo_Negocio();
            categorianegocio = new Categoria_Negocio();
            CargarGrilla(id_tambo);
            CargarComboBusqueda();
            InicializarTextBox();
        }

        public void CargarGrilla(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.dgvAnimales.AutoGenerateColumns = false;
            
            this.dgvAnimales.DataSource = animalNegocio.RecuperarPorTamboDT(id_tambo);
            if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
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

        public void CargarComboBusqueda()
        {
            this.cbBuscar.Items.Add("Nombre animal");
            this.cbBuscar.Items.Add("Estado");
            this.cbBuscar.Items.Add("Caravana");
            this.cbBuscar.SelectedIndex = -1;
        }

        public void ValidarAnimales()
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            if (!animalNegocio.HayAnimales(Principal.Tambo.Id_tambo))
            {
                MessageBox.Show("El tambo no posee animales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Animal MapearAAnimal()
        {
            Raza_Negocio razaNegocio = new Raza_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Raza raza = razaNegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_raza"].Value));
            Tambo tambo = tamboNegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value));
            Animal animal = new Animal();
            Categoria categoria = new Categoria();
            animal.Rp = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp"].Value);
            animal.Fecha_nacimiento = Convert.ToDateTime(this.dgvAnimales.CurrentRow.Cells["fecha_nacimiento"].Value);
            animal.Edad = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["edad"].Value);
            animal.Nombre_animal = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["nombre_animal"].Value);
            animal.Estado_animal = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["estado_animal"].Value);
            animal.Hba = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba"].Value);
            categoria.Descripcion = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["categoria"].Value);
            //animal.Categoria.Descripcion = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["categoria"].Value);
            animal.Nombre_tambo = tambo.Nombre_tambo;
            animal.Nombre_raza = raza.Nombre_raza;
            animal.Id_raza = raza.Id_raza;
            animal.Habilitado = true;
            animal.Rp_madre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp_madre"].Value);
            animal.Hba_madre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba_madre"].Value);
            animal.Rp_padre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp_padre"].Value);
            animal.Hba_padre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba_padre"].Value);
            animal.Caravana = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["caravana"].Value);

            return animal;
        }

        public void InicializarTextBox()
        {
            if (this.cbBuscar.SelectedIndex == -1)
            {
                this.txtBuscar.Enabled = false;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Raza_Negocio razaNegocio = new Raza_Negocio();
            //Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            //Raza raza = razaNegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_raza"].Value));
            //Tambo tambo = tamboNegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value));
            //int id_tambo = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value);
            //EdicionAnimales edicion = new EdicionAnimales();

            //edicion.txtRP.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["rp"].Value);
            //edicion.dtpFechaNacimiento.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["fecha_nacimiento"].Value);
            ////edicion.txtEdad.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["edad"].Value);
            //edicion.txtNombre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["nombre_animal"].Value);
            //edicion.cbEstado.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["estado_animal"].Value);
            //edicion.txtHBA.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["hba"].Value);
            //edicion.cbCategoria.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["categoria"].Value);
            ////edicion.cbSexo.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["sexo"].Value);
            ////edicion.txtFoto.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["foto"].Value);
            //edicion.txtTambo.Text = tambo.Nombre_tambo;
            //edicion.cbRaza.Text = raza.Nombre_raza;
            //edicion.txtRPMadre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["rp_madre"].Value);
            //edicion.txtHBAMadre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["hba_madre"].Value);
            //edicion.txtRPPadre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["rp_padre"].Value);
            //edicion.txtHBAPadre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["hba_padre"].Value);
            //edicion.txtCaravana.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["caravana"].Value);

            //edicion.animalGlobal = MapearAAnimal();
            //edicion.Show();
            //CargarGrilla(id_tambo);

            Animal.Raza = new Raza();
            Animal.Raza = razanegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_raza"].Value));
            Animal.Id_raza = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_raza"].Value);
            Animal.Tambo = new Tambo();
            Animal.Tambo = Principal.Tambo;
            Animal.Id_tambo = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value);
            Animal.Categoria = new Categoria();
            Animal.Categoria = categorianegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_categoria"].Value));
            Animal.Id_Categoria = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_categoria"].Value);


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

            AbmAnimales form = new AbmAnimales(Principal.ModoForm.MODIFICACION,Animal);
            form.Show();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            int id = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp"].Value);
            Animal animal = animalNegocio.RecuperarUno(id);
            int id_tambo = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value);
            DialogResult result = MessageBox.Show("ATENCIÓN!! Al eliminar el animal " + animal.Nombre_animal + ", también eliminará sus controles y eventos asociados. ¿Desea continuar?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                animalNegocio.Eliminar(id);
                this.CargarGrilla(id_tambo);
                MessageBox.Show("El animal " + animal.Nombre_animal + " fue eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

       

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            if (this.cbBuscar.SelectedIndex == -1)
            {
                this.txtBuscar.Enabled = false;
                //MessageBox.Show("Debe seleccionar un parámetro a buscar en el combo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.cbBuscar.SelectedItem.ToString() == "Nombre animal")
            {
                this.dgvAnimales.DataSource = animalNegocio.FiltrarPorNombre(this.txtBuscar.Text, idtambo);
            }
            else if (this.cbBuscar.SelectedItem.ToString() == "Estado")
            {
                this.dgvAnimales.DataSource = animalNegocio.FiltrarPorEstado(this.txtBuscar.Text, idtambo);
            }
            else if (this.cbBuscar.SelectedItem.ToString() == "Caravana")
            {
                this.dgvAnimales.DataSource = animalNegocio.FiltrarPorCaravana(this.txtBuscar.Text, idtambo);
            }
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarGrilla(Principal.Tambo.Id_tambo);
            this.txtBuscar.Text = string.Empty;

            if (this.cbBuscar.SelectedIndex == -1)
            {
                this.txtBuscar.Enabled = false;
            }
            else
            {
                this.txtBuscar.Enabled = true;
            }
        }

        private void GestionAnimales_Activated(object sender, EventArgs e)
        {
            this.CargarGrilla(Principal.Tambo.Id_tambo);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvAnimales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 19)
            {
                if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
                {
                    int id_tambo = Principal.Tambo.Id_tambo;
                    int rp = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp"].Value);

                    HistoriaClinica historiaClinica = new HistoriaClinica();
                    EventoAnimal_DescSubevento_Negocio eventoAnimalDescNegocio = new EventoAnimal_DescSubevento_Negocio();

                    historiaClinica.dgvHistorialClinico.DataSource = eventoAnimalDescNegocio.RecuperarPorTamboYAnimal(id_tambo, rp);
                    historiaClinica.Show();
                }
            }
            else if(e.ColumnIndex == 20)
            {
                if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
                {
                    int id_tambo = Principal.Tambo.Id_tambo;
                    int rp = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp"].Value);

                    HistorialProduccion historialProd = new HistorialProduccion();
                    Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
                    historialProd.dgvHistorialProduccion.DataSource = controlAnimalNegocio.RecuperarPorTamboYAnimal(id_tambo, rp);
                    historialProd.Show();
                }
            }


            //else if (e.ColumnIndex == 1)
            //{
            //    if (this.dgvAnimales.Rows.Count != 0 && this.dgvAnimales.Rows != null)
            //    {
            //        int id_tambo = Principal.Tambo.Id_tambo;
            //        int rp = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp"].Value);

            //        HistorialProduccion historialProd = new HistorialProduccion();
            //        Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            //        historialProd.dgvHistorialProduccion.DataSource = controlAnimalNegocio.RecuperarPorTamboYAnimal(id_tambo, rp);
            //        historialProd.Show();
            //    }
            //}
        }
    }
}
