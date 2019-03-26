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
        public AltaEventos(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            CargaComboAnimal(id_tambo);
            CargarListaEventos();
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();
            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        public void CargaComboAnimal(int id_tambo)
        {
            Animal_Negocio animalNegocio = new Animal_Negocio();
            //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error   
            this.cbAnimal.DisplayMember = "nombre_animal";
            this.cbAnimal.ValueMember = "rp";
            this.cbAnimal.DataSource = animalNegocio.RecuperarPorTambo(id_tambo);
            this.cbAnimal.SelectedIndex = -1;
        }

        public void CargarListaEventos()
        {
            Evento_Negocio eventoNegocio = new Evento_Negocio();
            //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error
            this.lbEventos.DisplayMember = "nombre_evento";
            this.lbEventos.ValueMember = "id_evento";
            this.lbEventos.DataSource = eventoNegocio.RecuperarTodos();
            this.lbEventos.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbEventos_SelectedIndexChanged(object sender, EventArgs e)
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
            }
            else if (this.lbEventos.SelectedIndex == 0)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 1)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 2)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 3)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 4)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 5)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 6)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 7)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 8)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 9)
            {
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
            }
            else if (this.lbEventos.SelectedIndex == 10)
            {
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
            }
        }

        Desc_Subevento_Negocio descSubeventoNegocio = new Desc_Subevento_Negocio();

        public void CargarCombo1Parto()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(1);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarCombo2Parto()
        {
            this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(2);
            this.comboBox2.DisplayMember = "descripcion";
            this.comboBox2.ValueMember = "id_desc";
            this.comboBox2.SelectedIndex = -1;
        }
        public void CargarCombo3Parto()
        {
            this.comboBox3.DataSource = descSubeventoNegocio.RecuperarPorSubevento(3);
            this.comboBox3.DisplayMember = "descripcion";
            this.comboBox3.ValueMember = "id_desc";
            this.comboBox3.SelectedIndex = -1;
        }
        public void CargarComboAborto()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(4);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarCombo1Celo()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(5);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarCombo2Celo()
        {
            this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(6);
            this.comboBox2.DisplayMember = "descripcion";
            this.comboBox2.ValueMember = "id_desc";
            this.comboBox2.SelectedIndex = -1;
        }
        public void CargarCombo3Celo()
        {
            this.comboBox3.DataSource = descSubeventoNegocio.RecuperarPorSubevento(7);
            this.comboBox3.DisplayMember = "descripcion";
            this.comboBox3.ValueMember = "id_desc";
            this.comboBox3.SelectedIndex = -1;
        }
        public void CargarComboVenta()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(8);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarComboMuerte()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(16);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarCombo1Enfermedad()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(9);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarCombo2Enfermedad()
        {
            this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(10);
            this.comboBox2.DisplayMember = "descripcion";
            this.comboBox2.ValueMember = "id_desc";
            this.comboBox2.SelectedIndex = -1;
        }
        public void CargarCombo1TactoRectal()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(11);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarCombo2TactoRectal()
        {
            this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(12);
            this.comboBox2.DisplayMember = "descripcion";
            this.comboBox2.ValueMember = "id_desc";
            this.comboBox2.SelectedIndex = -1;

        }
        public void CargarCombo3TactoRectal()
        {
            this.comboBox3.DataSource = descSubeventoNegocio.RecuperarPorSubevento(13);
            this.comboBox3.DisplayMember = "descripcion";
            this.comboBox3.ValueMember = "id_desc";
            this.comboBox3.SelectedIndex = -1;
        }
        public void CargarCombo4TactoRectal()
        {
            this.comboBox4.DataSource = descSubeventoNegocio.RecuperarPorSubevento(6);
            this.comboBox4.DisplayMember = "descripcion";
            this.comboBox4.ValueMember = "id_desc";
            this.comboBox4.SelectedIndex = -1;
        }
        public void CargarCombo1Medicacion()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(10);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarCombo2Medicacion()
        {
            this.comboBox2.DataSource = descSubeventoNegocio.RecuperarPorSubevento(7);
            this.comboBox2.DisplayMember = "descripcion";
            this.comboBox2.ValueMember = "id_desc";
            this.comboBox2.SelectedIndex = -1;
        }
        public void CargarComboRechazo()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(14);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarComboAnalisis()
        {
            this.comboBox1.DataSource = descSubeventoNegocio.RecuperarPorSubevento(15);
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.ValueMember = "id_desc";
            this.comboBox1.SelectedIndex = -1;
        }
        public void CargarComboInseminador()
        {
            Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
            //Asigno primero el displaymember y el valuemember, despues el data source, sino tira error
            this.comboBox1.DataSource = inseminadorNegocio.RecuperarTodos();
            this.comboBox1.DisplayMember = "nombre_inseminador";
            this.comboBox1.ValueMember = "id_inseminador";
            this.comboBox1.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
            List<EventoAnimal_DescSubevento> listaEventoAnimal = new List<EventoAnimal_DescSubevento>();

            if (this.lbEventos.SelectedIndex == 1 || this.lbEventos.SelectedIndex == 3 || this.lbEventos.SelectedIndex == 4 || this.lbEventos.SelectedIndex == 8 || this.lbEventos.SelectedIndex == 9 || this.lbEventos.SelectedIndex == 10)
            {
                if (validaciones.ValidarCargaEventosTipo1(dtpFecha.Value.Date, cbAnimal.SelectedIndex, lbEventos.SelectedIndex, comboBox1.SelectedIndex))
                {
                    //Creo el evento
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
                if (validaciones.ValidarCargaEventosTipo2(dtpFecha.Value.Date, cbAnimal.SelectedIndex, lbEventos.SelectedIndex, comboBox1.SelectedIndex, comboBox2.SelectedIndex))
                {
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
            else if (this.lbEventos.SelectedIndex == 0 || this.lbEventos.SelectedIndex == 2)
            {
                if (validaciones.ValidarCargaEventosTipo3(dtpFecha.Value.Date, cbAnimal.SelectedIndex, lbEventos.SelectedIndex, comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex))
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
                    if (this.lbEventos.SelectedIndex == 2)  //sería el evento de celo
                    {
                        animalNegocio.ActualizarEstado("Celo", eventoAnimal1.Rp);
                    }
                    else if (this.lbEventos.SelectedIndex == 0)  //sería el evento de parto
                    {
                        animalNegocio.ActualizarEstado("Parto", eventoAnimal1.Rp);
                    }

                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.lbEventos.SelectedIndex == 6)
            {
                if (validaciones.ValidarCargaEventosTipo4(dtpFecha.Value.Date, cbAnimal.SelectedIndex, lbEventos.SelectedIndex, comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex, comboBox4.SelectedIndex))
                {
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

        public EventoAnimal_DescSubevento MapearAEventoAnimal1()
        {
            Inseminador_Negocio inseminadorNegocio = new Inseminador_Negocio();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Animal_Negocio animalNegocio = new Animal_Negocio();
            Evento_Negocio eventoNegocio = new Evento_Negocio();
            Desc_Subevento_Negocio descSubeventoNegocio = new Desc_Subevento_Negocio();       
            Tambo tambo = tamboNegocio.RecuperarPorNombre(this.txtTambo.Text);
            Animal animal = animalNegocio.RecuperarUno(Convert.ToInt32(cbAnimal.SelectedValue));
            Evento evento = eventoNegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue));
            

            EventoAnimal_DescSubevento eventoAnimal = new EventoAnimal_DescSubevento();

            eventoAnimal.Fecha_desc = dtpFecha.Value.Date;
            eventoAnimal.Rp = animal.Rp;
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
            Animal animal = animalNegocio.RecuperarUno(Convert.ToInt32(cbAnimal.SelectedValue));
            Evento evento = eventoNegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue));
            Desc_Subevento descSubevento = descSubeventoNegocio.RecuperarUno(Convert.ToInt32(comboBox2.SelectedValue));

            EventoAnimal_DescSubevento eventoAnimal = new EventoAnimal_DescSubevento();

            eventoAnimal.Fecha_desc = dtpFecha.Value.Date;
            eventoAnimal.Rp = animal.Rp;
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
            Animal animal = animalNegocio.RecuperarUno(Convert.ToInt32(cbAnimal.SelectedValue));
            Evento evento = eventoNegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue));
            Desc_Subevento descSubevento = descSubeventoNegocio.RecuperarUno(Convert.ToInt32(comboBox3.SelectedValue));

            EventoAnimal_DescSubevento eventoAnimal = new EventoAnimal_DescSubevento();

            eventoAnimal.Fecha_desc = dtpFecha.Value.Date;
            eventoAnimal.Rp = animal.Rp;
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
            Animal animal = animalNegocio.RecuperarUno(Convert.ToInt32(cbAnimal.SelectedValue));
            Evento evento = eventoNegocio.RecuperarUno(Convert.ToInt32(lbEventos.SelectedValue));
            Desc_Subevento descSubevento = descSubeventoNegocio.RecuperarUno(Convert.ToInt32(comboBox4.SelectedValue));

            EventoAnimal_DescSubevento eventoAnimal = new EventoAnimal_DescSubevento();

            eventoAnimal.Fecha_desc = dtpFecha.Value.Date;
            eventoAnimal.Rp = animal.Rp;
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
            this.dtpFecha.Text = string.Empty;
            this.cbAnimal.SelectedIndex = -1;
            this.lbEventos.SelectedIndex = -1;
        }

        private void AltaEventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir sin guardar los cambios?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }   
}
