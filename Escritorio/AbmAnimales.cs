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
using static Escritorio.Principal;

namespace Escritorio
{
    public partial class AbmAnimales : Form
    {
        Animal_Negocio animalnegocio;
        Categoria_Negocio categorianegocio;
        int ultimacaravana;
        public Animal Animal { get; set; }
        ModoForm ModoForm;

        public AbmAnimales()
        {
            InitializeComponent();
            Animal = new Animal();
            animalnegocio = new Animal_Negocio();
            categorianegocio = new Categoria_Negocio();
            CargarComboEstado();
            CargaComboCategoria();
            CargarTextBoxTambo();
            CargaComboRaza();
            CargaUltimaCaravana();
        }

        public AbmAnimales(ModoForm modo,Animal animal)
        {
            InitializeComponent();
            ModoForm = modo;
            Animal = new Animal();
            animalnegocio = new Animal_Negocio();
            categorianegocio = new Categoria_Negocio();
            CargarComboEstado();
            CargaComboCategoria();
            CargarTextBoxTambo();
            CargaComboRaza();
            CargaUltimaCaravana();

            lbTituloFormulario.Text = ModoForm.ToString(); 

            if (ModoForm == ModoForm.MODIFICACION)
            {
                
                if (animal != null)
                {
                    Animal = animal;
                }
                MapearDesdeAnimal();

            }
            

           


        }

        #region Metodos

        public void MapearAAnimal()
        {


            if (dtpFechaNacimiento.Value.Date == DateTime.Now.Date)
            {
                dtpFechaNacimiento.Value.AddMilliseconds(1);
            }

            if (cbEstado.SelectedItem.ToString() == Principal.EstadoAnimales.Vivo.ToString())
            {
                Animal.Estado_animal = Principal.EstadoAnimales.Vivo.ToString();
            }

            if (cbEstado.SelectedItem.ToString() == Principal.EstadoAnimales.Muerto.ToString() || cbEstado.SelectedItem.ToString() == Principal.EstadoAnimales.Vendido.ToString())
            {
                Animal.Habilitado = false;
            }
            else
            {
                Animal.Habilitado = true;
            }


            Animal.Fecha_nacimiento = dtpFechaNacimiento.Value;

            Animal.Nombre_animal = txtNombre.Text;
            Animal.Hba = string.IsNullOrEmpty(txtHBA.Text) ? 0 : Convert.ToInt32(txtHBA.Text);


            Animal.Rp_madre = string.IsNullOrEmpty(txtRPMadre.Text) ? 0 : Convert.ToInt32(txtRPMadre.Text);
            Animal.Rp_padre = string.IsNullOrEmpty(txtRPPadre.Text) ? 0 : Convert.ToInt32(txtRPPadre.Text);
            Animal.Hba_madre = string.IsNullOrEmpty(txtHBAMadre.Text) ? 0 : Convert.ToInt32(txtHBAMadre.Text);
            Animal.Hba_padre = string.IsNullOrEmpty(txtHBAPadre.Text) ? 0 : Convert.ToInt32(txtHBAPadre.Text);
            Animal.Tambo = Principal.Tambo;
            Animal.Id_tambo = Principal.Tambo.Id_tambo;

           
            Animal.Caravana = txtCaravana.Text;


        }


        public void MapearDesdeAnimal()
        {
            try
            {

                this.dtpFechaNacimiento.Value = Animal.Fecha_nacimiento;

                this.txtNombre.Text = Animal.Nombre_animal;
                this.cbEstado.SelectedItem = Animal.Estado_animal;
                this.cbEstado.Text = Animal.Estado_animal;
                this.txtHBA.Text = Animal.Hba.ToString();
                this.cbCategoria.SelectedItem = Animal.Categoria;
                this.cbCategoria.Text = Animal.Categoria.Descripcion;
                this.cbRaza.SelectedItem = Animal.Raza;
                this.cbRaza.Text = Animal.Raza.Nombre_raza;
                this.txtRPMadre.Text = Animal.Rp_madre.ToString();
                this.txtHBAMadre.Text = Animal.Hba_madre.ToString();
                this.txtRPPadre.Text = Animal.Rp_padre.ToString();
                this.txtHBAPadre.Text = Animal.Hba_padre.ToString();
                this.txtCaravana.Text = Animal.Caravana.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar formulario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }


        public void Limpiar()
        {
            this.dtpFechaNacimiento.Text = string.Empty;

            this.txtNombre.Text = string.Empty;
            this.txtHBA.Text = string.Empty;
            this.txtHBAMadre.Text = string.Empty;
            this.txtHBAPadre.Text = string.Empty;
            this.txtRPMadre.Text = string.Empty;
            this.txtRPPadre.Text = string.Empty;
            this.cbCategoria.SelectedIndex = -1;
            this.cbRaza.SelectedIndex = -1;
            this.cbEstado.SelectedItem = Principal.EstadoAnimales.Vivo;
            CargaUltimaCaravana();
        }



        private bool ValidarCargaAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el animal ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            if (Animal.Categoria == null)
            {
                MessageBox.Show("Debe seleccionar una categoria para el animal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbCategoria.Focus();
                return false;
            }

            if (cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado para el animal ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbEstado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCaravana.Text))
            {

                MessageBox.Show("Debe ingresar un número de caravana ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCaravana.Focus();
                return false;
            }

            if (ModoForm == ModoForm.ALTA || ModoForm == ModoForm.CRIA)
            {

                if (animalnegocio.ExisteLaCaravana(Principal.Tambo.Id_tambo, txtCaravana.Text))
                {
                    MessageBox.Show("La caravana ingresada ya existe ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCaravana.Focus();
                    return false;
                }
            }
            else if (Animal.Caravana != txtCaravana.Text)
            {
                MessageBox.Show("La caravana ingresada ya existe ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCaravana.Focus();
                return false;
            }
            
            if (Animal.Raza == null)
            {
                MessageBox.Show("Debe seleccionar una raza para el animal ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbRaza.Focus();
                return false;

            }

            return true;
        }

        public bool HayCamposModificados()
        {
            if (txtNombre.Text == string.Empty && txtHBA.Text == string.Empty && txtRPMadre.Text == string.Empty && txtRPPadre.Text == string.Empty && txtHBAMadre.Text == string.Empty && txtHBAPadre.Text == string.Empty && cbCategoria.SelectedIndex == -1 && cbRaza.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void CargaUltimaCaravana()
        {
            ultimacaravana = animalnegocio.ObtenerUltimaCaravana(Principal.Tambo.Id_tambo);
            
            lbUltCaravana.Text = "La ultima caravana utilizada en el tambo es: " + ultimacaravana;
            if (ModoForm == ModoForm.ALTA)
            {
                txtCaravana.Text = (ultimacaravana + 1).ToString();
            }
           
            
        }

        public void CargarComboEstado()
        {

            this.cbEstado.DataSource = Enum.GetValues(typeof(Principal.EstadoAnimales));
            this.cbEstado.SelectedItem = Principal.EstadoAnimales.Vivo;

        }

        public void CargaComboCategoria()
        {
            try
            {
                cbCategoria.DataSource = categorianegocio.RecuperarTodos();
                cbCategoria.DisplayMember = "descripcion";
                cbCategoria.ValueMember = "id_categoria";
                cbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CargarTextBoxTambo()
        {
            this.txtTambo.Text = Principal.Tambo.Nombre_tambo;
        }

        public void CargaComboRaza()
        {
            Raza_Negocio razaNegocio = new Raza_Negocio();
            this.cbRaza.DataSource = razaNegocio.RecuperarTodos();
            this.cbRaza.DisplayMember = "nombre_raza";
            this.cbRaza.ValueMember = "id_raza";
            this.cbRaza.SelectedIndex = -1;
        }
        #endregion

        #region Eventos



        private void AltaAnimales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HayCamposModificados())
            {
                DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.Dispose();
                }
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Validaciones validaciones = new Validaciones();
            //bool validar = validaciones.ValidarCargaAnimales(cbCategoria.SelectedIndex,cbRaza.SelectedIndex,txtNombre.Text,txtHBA.Text,txtCaravana.Text);

            try
            {
                if (ValidarCargaAnimal(Animal))
                {


                    MapearAAnimal();

                    if (ModoForm == ModoForm.MODIFICACION)
                    {
                        animalnegocio.Actualizar(Animal);
                        MessageBox.Show("El animal fue modificado exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Dispose();
                    }
                    else if (ModoForm == ModoForm.ALTA)
                    {
                        animalnegocio.Insertar(Animal);
                        MessageBox.Show("El animal fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (ModoForm == ModoForm.CRIA)
                    {
                        animalnegocio.Insertar(Animal);
                        MessageBox.Show("La cría fue dada de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Dispose();
                    }
                    this.Limpiar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al dar de alta el animal", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbEstado.SelectedIndex > -1)
                {
                    var estado = cbEstado.SelectedItem;
                    Animal.Estado_animal = estado.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbCategoria.SelectedIndex > -1)
                {
                    Animal.Categoria = new Categoria();
                    Animal.Categoria = (Categoria)cbCategoria.SelectedItem;
                    Animal.Id_Categoria = ((Categoria)cbCategoria.SelectedItem).Id_Categoria;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbRaza_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbRaza.SelectedIndex > -1)
                {
                    Animal.Raza = new Raza();
                    Animal.Raza = (Raza)cbRaza.SelectedItem;
                    Animal.Id_raza = ((Raza)cbRaza.SelectedItem).Id_raza;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region EventosKeyPress


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (e.KeyChar == (char)Keys.Back) && char.IsSeparator(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtHBA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRPMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtHBAMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRPPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtHBAPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }





        #endregion

        #endregion
    }
}
