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
using Util;

namespace Escritorio
{
    public partial class AltaEventos : Form
    {
        EventoAnimal_Negocio eventoanimal_negocio;
        Animal_Negocio animalnegocio;
        Evento_Negocio eventonegocio;
        Animal Animal;
        Evento Evento;
        public Animal Cria { get; set; }
        public Animal Cria2 { get; set; }

        public AltaEventos(int id_tambo)
        {
            
            InitializeComponent();
            eventoanimal_negocio = new EventoAnimal_Negocio();
            animalnegocio = new Animal_Negocio();
            eventonegocio = new Evento_Negocio();
            Animal = new Animal();
            Evento = new Evento();
            Cria = new Animal();
            Cria2 = new Animal();
            CargarTextBoxTambo(id_tambo);
            
            btnCria.Visible = false;
            btnCria2.Visible = false;

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

        public void CargarListaEventos(Animal animal)
        {
            try
            {
                Evento_Negocio eventoNegocio = new Evento_Negocio();
                if (animal.Categoria.Descripcion == "Vaca")
                {
                    //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error
                    this.lbEventos.DisplayMember = "nombre_evento";
                    this.lbEventos.ValueMember = "id_evento";
                    this.lbEventos.DataSource = eventoNegocio.RecuperarTodos();
                    this.lbEventos.SelectedIndex = -1;
                    //this.cbAnimal.Enabled = false;
                }
                else if (animal.Categoria.Descripcion == "Toro")
                {
                    //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error
                    this.lbEventos.DisplayMember = "nombre_evento";
                    this.lbEventos.ValueMember = "id_evento";
                    this.lbEventos.DataSource = eventoNegocio.RecuperarEventosParaToros();
                    this.lbEventos.SelectedIndex = -1;
                    //this.cbAnimal.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCria.Visible = false;
            btnCria2.Visible = false;

            Animal_Negocio animalNegocio = new Animal_Negocio();

            if (Animal.Categoria.Descripcion == "Vaca")
            {
                if (this.lbEventos.SelectedIndex == -1)
                {
                    this.label1.Visible = false;
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = false;
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    //this.cbAnimal.Enabled = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 0)
                {
                    //CargaComboAnimalSoloVacas(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Sexo cría:";
                    this.label2.Visible = true;
                    this.label2.Text = "Tipo parto:";
                    this.label3.Visible = true;
                    this.label3.Text = "Estado cría:";
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarCombo1Parto();
                    this.comboBox2.Visible = true;
                    CargarCombo2Parto();
                    this.comboBox3.Visible = true;
                    CargarCombo3Parto();
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 1)
                {
                    if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                    {
                        //CargaComboAnimalSoloVacas(Principal.Tambo.Id_tambo);
                        this.label1.Visible = true;
                        this.label1.Text = "Causa aborto:";
                        this.label2.Visible = false;
                        this.label3.Visible = false;
                        this.label4.Visible = false;
                        this.comboBox1.Visible = true;
                        CargarComboAborto();
                        this.comboBox2.Visible = false;
                        this.comboBox3.Visible = false;
                        this.comboBox4.Visible = false;
                        this.btnLimpiar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No se pueden registrar abortos debido a que no existen vacas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.lbEventos.SelectedIndex = -1;
                    }
                }
                else if (this.lbEventos.SelectedIndex == 2)
                {
                    if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                    {
                        //CargaComboAnimalSoloVacas(Principal.Tambo.Id_tambo);
                        this.label1.Visible = true;
                        this.label1.Text = "Causa de no inseminar:";
                        this.label2.Visible = true;
                        this.label2.Text = "Medicación genital:";
                        this.label3.Visible = true;
                        this.label3.Text = "Vía de aplicación:";
                        this.label4.Visible = false;
                        this.comboBox1.Visible = true;
                        CargarCombo1Celo();
                        this.comboBox2.Visible = true;
                        CargarCombo2Celo();
                        this.comboBox3.Visible = true;
                        CargarCombo3Celo();
                        this.comboBox4.Visible = false;
                        this.btnLimpiar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No se pueden registrar eventos de celo debido a que no existen vacas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.lbEventos.SelectedIndex = -1;
                    }
                }
                else if (this.lbEventos.SelectedIndex == 3)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Especificación:";
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarComboVenta();
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 4)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Especificación:";
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarComboMuerte();
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 5)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Tipo enfermedad:";
                    this.label2.Visible = true;
                    this.label2.Text = "Medicamento:";
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarCombo1Enfermedad();
                    this.comboBox2.Visible = true;
                    CargarCombo2Enfermedad();
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 6)
                {
                    if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                    {
                        //CargaComboAnimalSoloVacas(Principal.Tambo.Id_tambo);
                        this.label1.Visible = true;
                        this.label1.Text = "Diagnóstico útero:";
                        this.label2.Visible = true;
                        this.label2.Text = "Enfermedad útero:";
                        this.label3.Visible = true;
                        this.label3.Text = "Enfermedad ovario:";
                        this.label4.Visible = true;
                        this.label4.Text = "Medicación genital:";
                        this.comboBox1.Visible = true;
                        CargarCombo1TactoRectal();
                        this.comboBox2.Visible = true;
                        CargarCombo2TactoRectal();
                        this.comboBox3.Visible = true;
                        CargarCombo3TactoRectal();
                        this.comboBox4.Visible = true;
                        CargarCombo4TactoRectal();
                        this.btnLimpiar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de alta este evento debido a que no existen vacas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.lbEventos.SelectedIndex = -1;
                    }
                }
                else if (this.lbEventos.SelectedIndex == 7)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Medicamento:";
                    this.label2.Visible = true;
                    this.label2.Text = "Vía de aplicación:";
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarCombo1Medicacion();
                    this.comboBox2.Visible = true;
                    CargarCombo2Medicacion();
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 8)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Causa rechazo:";
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarComboRechazo();
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 9)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Tipo análisis:";
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarComboAnalisis();
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 10)
                {
                    if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                    {
                        Tambo_Inseminador_Negocio insNegocio = new Tambo_Inseminador_Negocio();
                        if (insNegocio.HayInseminadores(Principal.Tambo.Id_tambo))
                        {
                            //CargaComboAnimalSoloVacas(Principal.Tambo.Id_tambo);
                            this.label1.Visible = true;
                            this.label1.Text = "Inseminador:";
                            this.label2.Visible = false;
                            this.label3.Visible = false;
                            this.label4.Visible = false;
                            this.comboBox1.Visible = true;
                            CargarComboInseminador();
                            this.comboBox2.Visible = false;
                            this.comboBox3.Visible = false;
                            this.comboBox4.Visible = false;
                            this.btnLimpiar.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe registrar inseminadores para dar de alta el servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.lbEventos.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de alta este evento debido a que no existen vacas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.lbEventos.SelectedIndex = -1;
                    }
                }
            }


            else if (Animal.Categoria.Descripcion == "Toro")
            {
                if (this.lbEventos.SelectedIndex == -1)
                {
                    this.label1.Visible = false;
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = false;
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    //this.cbAnimal.Enabled = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 0)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Especificación:";
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarComboVenta();
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 1)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Especificación:";
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarComboMuerte();
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 2)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Tipo enfermedad:";
                    this.label2.Visible = true;
                    this.label2.Text = "Medicamento:";
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarCombo1Enfermedad();
                    this.comboBox2.Visible = true;
                    CargarCombo2Enfermedad();
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 3)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Medicamento:";
                    this.label2.Visible = true;
                    this.label2.Text = "Vía de aplicación:";
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarCombo1Medicacion();
                    this.comboBox2.Visible = true;
                    CargarCombo2Medicacion();
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
                else if (this.lbEventos.SelectedIndex == 4)
                {
                    //CargaComboAnimal(Principal.Tambo.Id_tambo);
                    this.label1.Visible = true;
                    this.label1.Text = "Tipo análisis:";
                    this.label2.Visible = false;
                    this.label3.Visible = false;
                    this.label4.Visible = false;
                    this.comboBox1.Visible = true;
                    CargarComboAnalisis();
                    this.comboBox2.Visible = false;
                    this.comboBox3.Visible = false;
                    this.comboBox4.Visible = false;
                    this.btnLimpiar.Visible = true;
                }
            }
        }

        /*public void CargaComboAnimal(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error   
            this.cbAnimal.DisplayMember = "caravana";
            this.cbAnimal.ValueMember = "rp";
            this.cbAnimal.DataSource = animalNegocio.RecuperarPorTambo(id_tambo);
            this.cbAnimal.SelectedIndex = -1;
            this.cbAnimal.Enabled = true;
            
            
        }*/

        /*public void CargaComboAnimalSoloVacas(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error   
            this.cbAnimal.DisplayMember = "caravana";
            this.cbAnimal.ValueMember = "rp";
            this.cbAnimal.DataSource = animalNegocio.RecuperarVacasPorTambo(id_tambo);
            this.cbAnimal.SelectedIndex = -1;
            this.cbAnimal.Enabled = true;
            
        }*/

        Desc_Subevento_Negocio descSubeventoNegocio = new Desc_Subevento_Negocio();

        public void CargarCombo1Parto()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(1);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo2Parto()
        {
            try
            {
                this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(2);
                this.comboBox2.DisplayMember = "descripcion";
                this.comboBox2.ValueMember = "id_desc";
                this.comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo3Parto()
        {
            try
            {
                this.comboBox3.DataSource = descSubeventoNegocio.RecuperarPorSubevento(3);
                this.comboBox3.DisplayMember = "descripcion";
                this.comboBox3.ValueMember = "id_desc";
                this.comboBox3.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarComboAborto()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(4);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo1Celo()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(5);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo2Celo()
        {
            try
            {
                this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(6);
                this.comboBox2.DisplayMember = "descripcion";
                this.comboBox2.ValueMember = "id_desc";
                this.comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo3Celo()
        {
            try
            {
                this.comboBox3.DataSource = descSubeventoNegocio.RecuperarPorSubevento(7);
                this.comboBox3.DisplayMember = "descripcion";
                this.comboBox3.ValueMember = "id_desc";
                this.comboBox3.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarComboVenta()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(8);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarComboMuerte()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(16);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo1Enfermedad()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(9);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo2Enfermedad()
        {
            try
            {
                this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(10);
                this.comboBox2.DisplayMember = "descripcion";
                this.comboBox2.ValueMember = "id_desc";
                this.comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo1TactoRectal()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(11);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo2TactoRectal()
        {
            try
            {
                this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(12);
                this.comboBox2.DisplayMember = "descripcion";
                this.comboBox2.ValueMember = "id_desc";
                this.comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo3TactoRectal()
        {
            try
            {
                this.comboBox3.DataSource = descSubeventoNegocio.RecuperarPorSubevento(13);
                this.comboBox3.DisplayMember = "descripcion";
                this.comboBox3.ValueMember = "id_desc";
                this.comboBox3.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo4TactoRectal()
        {
            try
            {
                this.comboBox4.DataSource = descSubeventoNegocio.RecuperarPorSubevento(6);
                this.comboBox4.DisplayMember = "descripcion";
                this.comboBox4.ValueMember = "id_desc";
                this.comboBox4.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo1Medicacion()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(10);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarCombo2Medicacion()
        {
            try
            {
                this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(7);
                this.comboBox2.DisplayMember = "descripcion";
                this.comboBox2.ValueMember = "id_desc";
                this.comboBox2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarComboRechazo()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(14);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarComboAnalisis()
        {
            try
            {
                this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(15);
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_desc";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
        public void CargarComboInseminador()
        {
            try
            {
                Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
                //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error
                this.comboBox1.DataSource = inseminadorNegocio.RecuperarPorTambo(Principal.Tambo.Id_tambo);
                this.comboBox1.DisplayMember = "nombre_inseminador";
                this.comboBox1.ValueMember = "id_inseminador";
                this.comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            List<EventoAnimal_DescSubevento> listaEventoAnimal = new List<EventoAnimal_DescSubevento>();

            try
            {

                //Evento_Animal evento_animal = new Evento_Animal();
                //evento_animal.Rp = animalnegocio.RecuperarPorRP(Animal.Rp).Rp;
                //evento_animal.Id_evento = eventonegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue)).Id_evento;
                //evento_animal.Fecha_desc = dtpFecha.Value;
                //eventoanimal_negocio.Insertar(evento_animal);


                if (this.lbEventos.SelectedIndex == 1 || this.lbEventos.SelectedIndex == 3 || this.lbEventos.SelectedIndex == 4 || this.lbEventos.SelectedIndex == 8 || this.lbEventos.SelectedIndex == 9 || this.lbEventos.SelectedIndex == 10)
                {
                if (validaciones.ValidarCargaEventosTipo1(dtpFecha.Value.Date, lbEventos.SelectedIndex, comboBox1.SelectedIndex))
                {
                    //Doy de alta el evento animal
                    DarDeAltaEvento();
                    //Creo el evento desc subevento
                    EventoAnimal_DescSubevento eventoAnimal1 = new EventoAnimal_DescSubevento();
                    eventoAnimal1 = MapearAEventoAnimal1();
                    listaEventoAnimal.Add(eventoAnimal1);
                    eventoNegocio.Insertar(listaEventoAnimal);
                    MessageBox.Show("El evento fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Actualizo el estado del animal
                    Animal_Negocio animalNegocio = new Animal_Negocio();
                    if (this.lbEventos.SelectedIndex == 1)  //sería el evento de aborto
                    {
                        animalNegocio.ActualizarEstado("Aborto", eventoAnimal1.Rp);
                    }
                    else if (this.lbEventos.SelectedIndex == 3)  //sería el evento de venta
                    {
                        animalNegocio.ActualizarEstado("Vendido",eventoAnimal1.Rp);
                    }
                    else if(this.lbEventos.SelectedIndex == 4)    //sería el evento de muerte
                    {
                        animalNegocio.ActualizarEstadoMuerto("Muerto",eventoAnimal1.Rp);
                    }
                    else if (this.lbEventos.SelectedIndex == 8)    //sería el evento de rechazo
                    {
                        animalNegocio.ActualizarEstadoMuerto("Rechazo", eventoAnimal1.Rp);
                    }
                    else if (this.lbEventos.SelectedIndex == 9)    //sería el evento de análisis
                    {
                        animalNegocio.ActualizarEstadoMuerto("Analisis", eventoAnimal1.Rp);
                    }

                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.lbEventos.SelectedIndex == 5 || this.lbEventos.SelectedIndex == 7)
            {
                if (validaciones.ValidarCargaEventosTipo2(dtpFecha.Value.Date, lbEventos.SelectedIndex, comboBox1.SelectedIndex, comboBox2.SelectedIndex))
                {
                    //Doy de alta el evento animal
                    DarDeAltaEvento();
                    //Creo los eventos
                    EventoAnimal_DescSubevento eventoAnimal1 = new EventoAnimal_DescSubevento();
                    EventoAnimal_DescSubevento eventoAnimal2 = new EventoAnimal_DescSubevento();
                    eventoAnimal1 = MapearAEventoAnimal1();
                    eventoAnimal2 = MapearAEventoAnimal2();
                    listaEventoAnimal.Add(eventoAnimal1);
                    listaEventoAnimal.Add(eventoAnimal2);
                    eventoNegocio.Insertar(listaEventoAnimal);
                    MessageBox.Show("El evento fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Actualizo el estado del animal
                    Animal_Negocio animalNegocio = new Animal_Negocio();
                    if (this.lbEventos.SelectedIndex == 5)  //sería el evento de enfermedad
                    {
                        animalNegocio.ActualizarEstado("Enfermo", eventoAnimal1.Rp);
                    }
                    else if (this.lbEventos.SelectedIndex == 7)  //sería el evento de medicación
                    {
                        animalNegocio.ActualizarEstado("Medicado", eventoAnimal1.Rp);
                    }

                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.lbEventos.SelectedIndex == 2)
            {
                if (validaciones.ValidarCargaEventosTipo3(dtpFecha.Value.Date, lbEventos.SelectedIndex, comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex))
                {
                    //Doy de alta el evento animal
                    DarDeAltaEvento();

                    EventoAnimal_DescSubevento eventoAnimal1 = new EventoAnimal_DescSubevento();
                    EventoAnimal_DescSubevento eventoAnimal2 = new EventoAnimal_DescSubevento();
                    EventoAnimal_DescSubevento eventoAnimal3 = new EventoAnimal_DescSubevento();
                    eventoAnimal1 = MapearAEventoAnimal1();
                    eventoAnimal2 = MapearAEventoAnimal2();
                    eventoAnimal3 = MapearAEventoAnimal3();
                    listaEventoAnimal.Add(eventoAnimal1);
                    listaEventoAnimal.Add(eventoAnimal2);
                    listaEventoAnimal.Add(eventoAnimal3);
                    eventoNegocio.Insertar(listaEventoAnimal);
                    MessageBox.Show("El evento fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Actualizo el estado del animal
                    Animal_Negocio animalNegocio = new Animal_Negocio();
                    if (this.lbEventos.SelectedIndex == 2)  //sería el evento de celo
                    {
                        animalNegocio.ActualizarEstado("Celo", eventoAnimal1.Rp);
                    }

                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.lbEventos.SelectedIndex == 0)
            {
                if (validaciones.ValidarCargaEventosTipo3(dtpFecha.Value.Date, lbEventos.SelectedIndex, comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex))
                {                       

                        if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Macho" && ((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Vivo")
                        {
                            if(btnCria.Enabled == false/*Cria.Rp != 0*/)
                            {
                                EventoAnimal_DescSubevento eventoAnimal1 = new EventoAnimal_DescSubevento();
                                EventoAnimal_DescSubevento eventoAnimal2 = new EventoAnimal_DescSubevento();
                                EventoAnimal_DescSubevento eventoAnimal3 = new EventoAnimal_DescSubevento();
                                eventoAnimal1 = MapearAEventoAnimal1();
                                eventoAnimal2 = MapearAEventoAnimal2();
                                eventoAnimal3 = MapearAEventoAnimal3();
                                listaEventoAnimal.Add(eventoAnimal1);
                                listaEventoAnimal.Add(eventoAnimal2);
                                listaEventoAnimal.Add(eventoAnimal3);
                                eventoNegocio.Insertar(listaEventoAnimal);
                                MessageBox.Show("El evento fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Actualizo el estado del animal
                                Animal_Negocio animalNegocio = new Animal_Negocio();
                                if (this.lbEventos.SelectedIndex == 0)  //sería el evento de parto
                                {
                                    animalNegocio.ActualizarEstado("Parto", eventoAnimal1.Rp);
                                }

                                //Doy de alta el evento animal
                                DarDeAltaEvento();

                                this.Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Debe dar de alta la cría haciendo click en el botón 'Agregar cría'", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Macho-Macho" && ((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Vivo")
                        {
                            if(btnCria.Enabled == false && btnCria2.Enabled == false/*Cria.Rp != 0 && Cria2.Rp != 0*/)
                            {
                                EventoAnimal_DescSubevento eventoAnimal1 = new EventoAnimal_DescSubevento();
                                EventoAnimal_DescSubevento eventoAnimal2 = new EventoAnimal_DescSubevento();
                                EventoAnimal_DescSubevento eventoAnimal3 = new EventoAnimal_DescSubevento();
                                eventoAnimal1 = MapearAEventoAnimal1();
                                eventoAnimal2 = MapearAEventoAnimal2();
                                eventoAnimal3 = MapearAEventoAnimal3();
                                listaEventoAnimal.Add(eventoAnimal1);
                                listaEventoAnimal.Add(eventoAnimal2);
                                listaEventoAnimal.Add(eventoAnimal3);
                                eventoNegocio.Insertar(listaEventoAnimal);
                                MessageBox.Show("El evento fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Actualizo el estado del animal
                                Animal_Negocio animalNegocio = new Animal_Negocio();
                                if (this.lbEventos.SelectedIndex == 0)  //sería el evento de parto
                                {
                                    animalNegocio.ActualizarEstado("Parto", eventoAnimal1.Rp);
                                }

                                //Doy de alta el evento animal
                                DarDeAltaEvento();

                                this.Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Debe dar de alta las crías antes de guardar el evento Parto", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }



                        /*if ()
                        {
                            EventoAnimal_DescSubevento eventoAnimal1 = new EventoAnimal_DescSubevento();
                            EventoAnimal_DescSubevento eventoAnimal2 = new EventoAnimal_DescSubevento();
                            EventoAnimal_DescSubevento eventoAnimal3 = new EventoAnimal_DescSubevento();
                            eventoAnimal1 = MapearAEventoAnimal1();
                            eventoAnimal2 = MapearAEventoAnimal2();
                            eventoAnimal3 = MapearAEventoAnimal3();
                            listaEventoAnimal.Add(eventoAnimal1);
                            listaEventoAnimal.Add(eventoAnimal2);
                            listaEventoAnimal.Add(eventoAnimal3);
                            eventoNegocio.Insertar(listaEventoAnimal);
                            MessageBox.Show("El evento fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Actualizo el estado del animal
                            Animal_Negocio animalNegocio = new Animal_Negocio();
                            if (this.lbEventos.SelectedIndex == 0)  //sería el evento de parto
                            {
                                animalNegocio.ActualizarEstado("Parto", eventoAnimal1.Rp);
                            }

                            this.Limpiar();
                        }
                        else
                        {

                        }*/
                }
                else
                {
                    MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.lbEventos.SelectedIndex == 6)
            {
                if (validaciones.ValidarCargaEventosTipo4(dtpFecha.Value.Date, lbEventos.SelectedIndex, comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex, comboBox4.SelectedIndex))
                {
                    //Doy de alta el evento animal
                    DarDeAltaEvento();

                    EventoAnimal_DescSubevento eventoAnimal1 = new EventoAnimal_DescSubevento();
                    EventoAnimal_DescSubevento eventoAnimal2 = new EventoAnimal_DescSubevento();
                    EventoAnimal_DescSubevento eventoAnimal3 = new EventoAnimal_DescSubevento();
                    EventoAnimal_DescSubevento eventoAnimal4 = new EventoAnimal_DescSubevento();
                    eventoAnimal1 = MapearAEventoAnimal1();
                    eventoAnimal2 = MapearAEventoAnimal2();
                    eventoAnimal3 = MapearAEventoAnimal3();
                    eventoAnimal4 = MapearAEventoAnimal4();
                    listaEventoAnimal.Add(eventoAnimal1);
                    listaEventoAnimal.Add(eventoAnimal2);
                    listaEventoAnimal.Add(eventoAnimal3);
                    listaEventoAnimal.Add(eventoAnimal4);
                    eventoNegocio.Insertar(listaEventoAnimal);
                    MessageBox.Show("El evento fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Actualizo el estado del animal
                    Animal_Negocio animalNegocio = new Animal_Negocio();
                    if (Convert.ToInt32(comboBox1.SelectedValue) == 95)  //sería la descripcion preñada
                    {
                        animalNegocio.ActualizarEstado("Preñada", eventoAnimal1.Rp);
                    }
                    else if (Convert.ToInt32(comboBox1.SelectedValue) == 96)  //sería la descripcion preñada dudosa
                    {
                        animalNegocio.ActualizarEstado("Preñada dudosa", eventoAnimal1.Rp);
                    }

                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al intentar guardar el evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        public EventoAnimal_DescSubevento MapearAEventoAnimal1()
        {
            Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Evento_Negocio eventoNegocio = new Evento_Negocio();
            Desc_Subevento_Negocio descSubeventoNegocio = new Desc_Subevento_Negocio();       
            Tambo tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
            //Animal animal = animalNegocio.RecuperarPorRP(Animal.Rp);
            Evento evento = eventoNegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue));
           

            EventoAnimal_DescSubevento eventoAnimal = new EventoAnimal_DescSubevento();

            //Registro la fecha con hora minutos y segundos
            //String hora = dtpFecha.Value.ToShortDateString() + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + "000";
            //eventoAnimal.Fecha_desc = Convert.ToDateTime(hora);
            eventoAnimal.Fecha_desc = dtpFecha.Value;
            


            eventoAnimal.Rp = Animal.Rp;
            eventoAnimal.Id_evento = evento.Id_evento;
            eventoAnimal.Id_tambo = tambo.Id_tambo;
            eventoAnimal.Estado_evento = true;

            if (this.lbEventos.SelectedIndex == 10)
            {
                Inseminador inseminador = inseminadorNegocio.RecuperarUno(Convert.ToInt32(comboBox1.SelectedValue));
                eventoAnimal.Id_inseminador = inseminador.Id_inseminador;
            }
            else
            {
                Desc_Subevento descSubevento = descSubeventoNegocio.RecuperarUno(Convert.ToInt32(comboBox1.SelectedValue));
                eventoAnimal.Id_desc = descSubevento.Id_desc;
            }

            return eventoAnimal;
        }

        public EventoAnimal_DescSubevento MapearAEventoAnimal2()
        {
            //Cambio solo el combobox seleccionado de la descripcion del subevento

            Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Evento_Negocio eventoNegocio = new Evento_Negocio();
            Desc_Subevento_Negocio descSubeventoNegocio = new Desc_Subevento_Negocio();

            Tambo tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
            //Animal animal = animalNegocio.RecuperarUnoPorCaravana(Animal.Caravana, Principal.Tambo.Id_tambo);
            //Animal animal = animalNegocio.RecuperarPorRP(Animal.Rp);
            Evento evento = eventoNegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue));
            Desc_Subevento descSubevento = descSubeventoNegocio.RecuperarUno(Convert.ToInt32(comboBox2.SelectedValue));

            EventoAnimal_DescSubevento eventoAnimal = new EventoAnimal_DescSubevento();
            //Registro la fecha con hora minutos y segundos
            //String hora = dtpFecha.Value.ToShortDateString() + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + "000";
            //eventoAnimal.Fecha_desc = Convert.ToDateTime(hora);
            eventoAnimal.Fecha_desc = dtpFecha.Value;
           


            eventoAnimal.Rp = Animal.Rp;
            eventoAnimal.Id_evento = evento.Id_evento;
            eventoAnimal.Id_desc = descSubevento.Id_desc;
            eventoAnimal.Id_tambo = tambo.Id_tambo;
            eventoAnimal.Estado_evento = true;
            if (this.label1.Text == "Inseminador:")
            {
                Inseminador inseminador = inseminadorNegocio.RecuperarUno(Convert.ToInt32(comboBox1.SelectedValue));
                eventoAnimal.Id_inseminador = inseminador.Id_inseminador;
            }

            return eventoAnimal;
        }

        public EventoAnimal_DescSubevento MapearAEventoAnimal3()
        {
            //Cambio solo el combobox seleccionado de la descripcion del subevento

            Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Evento_Negocio eventoNegocio = new Evento_Negocio();
            Desc_Subevento_Negocio descSubeventoNegocio = new Desc_Subevento_Negocio();

            Tambo tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
            //Animal animal = animalNegocio.RecuperarUnoPorCaravana(Animal.Caravana, Principal.Tambo.Id_tambo);
            //Animal animal = animalNegocio.RecuperarPorRP(Animal.Rp);
            Evento evento = eventoNegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue));
            Desc_Subevento descSubevento = descSubeventoNegocio.RecuperarUno(Convert.ToInt32(comboBox3.SelectedValue));

            EventoAnimal_DescSubevento eventoAnimal = new EventoAnimal_DescSubevento();

            //Registro la fecha con hora minutos y segundos
            //String hora = dtpFecha.Value.ToShortDateString() + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + "000";
            //eventoAnimal.Fecha_desc = Convert.ToDateTime(hora);
            eventoAnimal.Fecha_desc = dtpFecha.Value;
           



            eventoAnimal.Rp = Animal.Rp;
            eventoAnimal.Id_evento = evento.Id_evento;
            eventoAnimal.Id_desc = descSubevento.Id_desc;
            eventoAnimal.Id_tambo = tambo.Id_tambo;
            eventoAnimal.Estado_evento = true;
            if (this.label1.Text == "Inseminador:")
            {
                Inseminador inseminador = inseminadorNegocio.RecuperarUno(Convert.ToInt32(comboBox1.SelectedValue));
                eventoAnimal.Id_inseminador = inseminador.Id_inseminador;
            }
            

            return eventoAnimal;
        }

        public EventoAnimal_DescSubevento MapearAEventoAnimal4()
        {
            //Cambio solo el combobox seleccionado de la descripcion del subevento

            Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Evento_Negocio eventoNegocio = new Evento_Negocio();
            Desc_Subevento_Negocio descSubeventoNegocio = new Desc_Subevento_Negocio();

            Tambo tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
            //Animal animal = animalNegocio.RecuperarUnoPorCaravana(Animal.Caravana, Principal.Tambo.Id_tambo);
            //Animal animal = animalNegocio.RecuperarPorRP(Animal.Rp);
            Evento evento = eventoNegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue));
            Desc_Subevento descSubevento = descSubeventoNegocio.RecuperarUno(Convert.ToInt32(comboBox4.SelectedValue));

            EventoAnimal_DescSubevento eventoAnimal = new EventoAnimal_DescSubevento();

            //Registro la fecha con hora minutos y segundos
            // String hora = dtpFecha.Value.ToShortDateString() + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + "000";
            //eventoAnimal.Fecha_desc = Convert.ToDateTime(hora);
            eventoAnimal.Fecha_desc = dtpFecha.Value;

          



            eventoAnimal.Rp = Animal.Rp;
            eventoAnimal.Id_evento = evento.Id_evento;
            eventoAnimal.Id_desc = descSubevento.Id_desc;
            eventoAnimal.Id_tambo = tambo.Id_tambo;
            eventoAnimal.Estado_evento = true;
            if (this.label1.Text == "Inseminador:")
            {
                Inseminador inseminador = inseminadorNegocio.RecuperarUno(Convert.ToInt32(comboBox1.SelectedValue));
                eventoAnimal.Id_inseminador = inseminador.Id_inseminador;
            }

            return eventoAnimal;
        }

        public void Limpiar()
        {
            try
            {
                this.dtpFecha.Text = string.Empty;
                //this.cbAnimal.SelectedIndex = -1;
                lbEventos.DataSource = null;
                lbEventos.Enabled = true;
                btnSalir.Enabled = true;
                //btnLimpiar.Enabled = true;
                btnBuscarAnimal.Enabled = true;

                lbError.Text = "";
                lbCaravana.Text = "";
                lbNombreAnimal.Text = "";
                lbCategoriaAnimal.Text = "";
                lbEstadoAnimal.Text = "";

                btnCria.Visible = false;
                btnCria2.Visible = false;

                btnLimpiar.Visible = false;

                Animal = new Animal();
                Cria = new Animal();
                Cria2 = new Animal();

                gbEvento.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void AltaEventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private bool HayCamposModificados()
        {

            if (lbCaravana.Text == "" && gbEvento.Visible == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbAnimal.SelectedIndex > -1)
            //{
            //    Animal animal = (Animal)cbAnimal.SelectedItem;
            //    lbNombreAnimal.Text = "Nombre: " + animal.Nombre_animal;
            //}
        }

        private void gbAnimal_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                btnCria.Visible = false;
                btnCria2.Visible = false;

                ListaSeleccionAnimal form = new ListaSeleccionAnimal();
                form.ShowDialog();

                if (form.Animal.Rp != 0)
                {
                    Animal = form.Animal;
                    lbError.Text = "";
                    lbCaravana.Text = "Caravana: " + Animal.Caravana;
                    lbNombreAnimal.Text = "Nombre: " + Animal.Nombre_animal;
                    lbCategoriaAnimal.Text = "Tipo: " + Animal.Categoria.Descripcion;
                    lbEstadoAnimal.Text = "Estado actual: " + Animal.Estado_animal;

                    lbEventos.DataSource = null;
                    lbEventos.Visible = true;

                    gbEvento.Visible = true;
                    CargarListaEventos(Animal);
                }
                else
                {
                    lbNombreAnimal.Text = "";
                    lbCategoriaAnimal.Text = "";
                    lbEstadoAnimal.Text = "";
                    lbError.Text = "Vuelva a seleccionar un animal";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al buscar el animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Macho")
            {

            }
            else if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Macho-Macho")
            {

            }
        }*/

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*if (((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Vivo" && ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Macho")
            {
                btnCria.Visible = true;
                btnCria2.Visible = false;
            }
            else if (((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Vivo" && ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Macho-Macho")
            {
                btnCria.Visible = true;
                btnCria2.Visible = true;
            }
            else if (((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Muerto" && ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Macho-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Macho")
            {
                btnCria.Visible = false;
                btnCria2.Visible = false;
            }*/
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    btnCria.Visible = false;
                    btnCria2.Visible = false;
                }
                else if (((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Muerto")
                {
                    btnCria.Visible = false;
                    btnCria2.Visible = false;
                }
                else if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Macho" && ((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Vivo")
                {
                    btnCria.Visible = true;
                    btnCria2.Visible = false;
                }
                else if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Macho-Macho" && ((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Vivo")
                {
                    btnCria.Visible = true;
                    btnCria2.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedIndex == -1)
                {
                    btnCria.Visible = false;
                    btnCria2.Visible = false;
                }
                else if (((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Muerto")
                {
                    btnCria.Visible = false;
                    btnCria2.Visible = false;
                }
                else if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Macho" && ((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Vivo")
                {
                    btnCria.Visible = true;
                    btnCria2.Visible = false;
                }
                else if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Macho-Macho" && ((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Vivo")
                {
                    btnCria.Visible = true;
                    btnCria2.Visible = true;
                }
                /*else if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Hembra-Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Mell. Macho-Macho" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Hembra" || ((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Macho" && ((Desc_Subevento)comboBox3.SelectedItem).Descripcion == "Muerto")
                {
                    btnCria.Visible = false;
                    btnCria2.Visible = false;
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnCria_Click(object sender, EventArgs e)
        {

            try
            {
                AbmAnimales altaAnimales = new AbmAnimales(Principal.ModoForm.CRIA, Animal);
                altaAnimales.txtRPMadre.Text = Animal.Caravana.ToString();
                if(Animal.Hba != 0)
                {
                    altaAnimales.txtHBAMadre.Text = Animal.Hba.ToString();
                }
                if (comboBox3.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
                {
                    Categoria_Negocio cn = new Categoria_Negocio();
                    Categoria c = new Categoria();
                    if (((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Hembra")
                    {
                        altaAnimales.cbCategoria.SelectedIndex = 0;
                        //c = cn.RecuperarUno(1);
                        //altaAnimales.cbCategoria.SelectedItem = Animal.Categoria;
                        //altaAnimales.cbCategoria.SelectedValue = Animal.Categoria.Id_Categoria;
                    }
                    else if(((Desc_Subevento)comboBox1.SelectedItem).Descripcion == "Macho")
                    {
                        altaAnimales.cbCategoria.SelectedIndex = 1;
                        //c = cn.RecuperarUno(2);
                        //altaAnimales.cbCategoria.SelectedItem = c;
                        //altaAnimales.cbCategoria.SelectedValue = c.Id_Categoria;
                    }
                }


                altaAnimales.ShowDialog();

                if (altaAnimales.Animal.Rp != 0)
                {
                    if (Cria.Rp == 0)
                    {
                        Cria = altaAnimales.Animal;
                        //lbcria1.Text = "Caravana cría: " + Cria.Caravana;
                        //lbcria1.Visible = true;
                        
                    }

                    DeshabilitarBtnCria1();

                    //else if (Cria.Rp != 0)
                    //{
                        //Cria2 = altaAnimales.Animal;
                        //lbcria1.Text = "Caravana segunda cría: " + Cria2.Caravana;
                        //lbcria2.Visible = true;
                    //}

                }

                //Cria = altaAnimales.Animal;
                //MessageBox.Show("Se ha cargado correctamente la cria. \n " +
                //                 "Caravana: "   + Cria.Caravana +
                //                 "\n Nombre: "  + Cria.Nombre_animal,"Alta de la cria",MessageBoxButtons.OK);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);
            }
        }

        private void btnCria2_Click(object sender, EventArgs e)
        {
            try
            {
                AbmAnimales altaAnimales = new AbmAnimales(Principal.ModoForm.CRIA, Animal);
                altaAnimales.txtRPMadre.Text = Animal.Caravana.ToString();
                //altaAnimales.cbCategoria.Text = Animal.Categoria.Descripcion;

                if (Animal.Hba != 0)
                {
                    altaAnimales.txtHBAMadre.Text = Animal.Hba.ToString();
                }

                altaAnimales.ShowDialog();

                if (altaAnimales.Animal.Rp != 0)
                {
                    if (Cria2.Rp == 0)
                    {
                        Cria2 = altaAnimales.Animal;
                        //lbcria1.Text = "Caravana cría: " + Cria.Caravana;
                        //lbcria1.Visible = true;
                        
                    }

                    DeshabilitarBtnCria2();

                    //else if (Cria2.Rp != 0)
                    //{
                        //Cria2 = altaAnimales.Animal;
                        //lbcria1.Text = "Caravana segunda cría: " + Cria2.Caravana;
                        //lbcria2.Visible = true;
                    //}

                }

                //Cria = altaAnimales.Animal;
                //MessageBox.Show("Se ha cargado correctamente la cria. \n " +
                //                 "Caravana: "   + Cria.Caravana +
                //                 "\n Nombre: "  + Cria.Nombre_animal,"Alta de la cria",MessageBoxButtons.OK);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);
            }
        }

        private void DeshabilitarBtnCria1()
        {
            try
            {
                if (Cria.Rp != 0)
                {
                    btnCria.Enabled = false;
                    lbEventos.Enabled = false;
                    //btnLimpiar.Enabled = false;
                    btnSalir.Enabled = false;
                    btnBuscarAnimal.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void DeshabilitarBtnCria2()
        {
            try
            {
                if (Cria2.Rp != 0)
                {
                    btnCria2.Enabled = false;
                    lbEventos.Enabled = false;
                    //btnLimpiar.Enabled = false;
                    btnSalir.Enabled = false;
                    btnBuscarAnimal.Enabled = false;
                }
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
                if (Cria.Rp != 0 || Cria2.Rp != 0)
                {
                    DialogResult result = MessageBox.Show("Está a punto de eliminar la(s) cría(s) creada(s). ¿Desea continuar de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (Cria.Rp != 0)
                        {

                            animalnegocio.Eliminar(Cria.Rp);
                        }

                        if (Cria2.Rp != 0)
                        {
                            animalnegocio.Eliminar(Cria2.Rp);
                        }
                        this.Limpiar();
                    }
                }
                else
                {
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        /*private void cbAnimal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbAnimal.SelectedIndex > -1)
            {
                Animal = (Animal)cbAnimal.SelectedItem;
                lbNombreAnimal.Text = "Nombre: " + Animal.Nombre_animal;
            }
        }*/

        private void DarDeAltaEvento()
        {
            try
            {
                Evento_Animal evento_animal = new Evento_Animal();
                evento_animal.Rp = animalnegocio.RecuperarPorRP(Animal.Rp).Rp;
                evento_animal.Id_evento = eventonegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue)).Id_evento;
                evento_animal.Fecha_desc = dtpFecha.Value;
                eventoanimal_negocio.Insertar(evento_animal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }   
}
