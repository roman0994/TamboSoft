using Entidades;
using Negocio;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Escritorio
{
    public partial class GestionAnimales : Form
    {
        public int idtambo;
        public GestionAnimales(int id_tambo)
        {
            InitializeComponent();
            CargarGrilla(id_tambo);
            CargarComboBusqueda();
            InicializarTextBox();
        }

        public void CargarGrilla(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            this.dgvAnimales.DataSource = animalNegocio.RecuperarPorTambo(id_tambo);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Raza_Negocio razaNegocio = new Raza_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Raza raza = razaNegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_raza"].Value));
            Tambo tambo = tamboNegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value));
            int id_tambo = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value);
            EdicionAnimales edicion = new EdicionAnimales();

            edicion.txtRP.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["rp"].Value);
            edicion.dtpFechaNacimiento.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["fecha_nacimiento"].Value);
            edicion.txtEdad.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["edad"].Value);
            edicion.txtNombre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["nombre_animal"].Value);
            edicion.cbEstado.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["estado_animal"].Value);
            edicion.txtHBA.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["hba"].Value);
            edicion.cbCategoria.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["categoria"].Value);
            //edicion.cbSexo.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["sexo"].Value);
            //edicion.txtFoto.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["foto"].Value);
            edicion.txtTambo.Text = tambo.Nombre_tambo;
            edicion.cbRaza.Text = raza.Nombre_raza;
            edicion.txtRPMadre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["rp_madre"].Value);
            edicion.txtHBAMadre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["hba_madre"].Value);
            edicion.txtRPPadre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["rp_padre"].Value);
            edicion.txtHBAPadre.Text = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["hba_padre"].Value);

            edicion.animalGlobal = MapearAAnimal();
            edicion.Show();
            CargarGrilla(id_tambo);

        }

        public Animal MapearAAnimal()
        {
            Raza_Negocio razaNegocio = new Raza_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Raza raza = razaNegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_raza"].Value));
            Tambo tambo = tamboNegocio.RecuperarUno(Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["id_tambo"].Value));
            Animal animal = new Animal();
            animal.Rp = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp"].Value);
            animal.Fecha_nacimiento = Convert.ToDateTime(this.dgvAnimales.CurrentRow.Cells["fecha_nacimiento"].Value);
            animal.Edad = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["edad"].Value);
            animal.Nombre_animal = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["nombre_animal"].Value);
            animal.Estado_animal = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["estado_animal"].Value);
            animal.Hba = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba"].Value);
            animal.Categoria = Convert.ToString(this.dgvAnimales.CurrentRow.Cells["categoria"].Value);
            animal.Nombre_tambo = tambo.Nombre_tambo;
            animal.Nombre_raza = raza.Nombre_raza;
            animal.Id_raza = raza.Id_raza;
            animal.Habilitado = true;
            animal.Rp_madre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp_madre"].Value);
            animal.Hba_madre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba_madre"].Value);
            animal.Rp_padre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["rp_padre"].Value);
            animal.Hba_padre = Convert.ToInt32(this.dgvAnimales.CurrentRow.Cells["hba_padre"].Value);

            return animal;
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

        public void InicializarTextBox()
        {
            if (this.cbBuscar.SelectedIndex == -1)
            {
                this.txtBuscar.Enabled = false;
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
