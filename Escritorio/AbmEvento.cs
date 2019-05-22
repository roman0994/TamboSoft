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
    public partial class AbmEvento : Form
    {
        Evento_Negocio eventonegocio;
        Animal_Negocio animalnegocio;
        Desc_Subevento_Negocio dessubeventonegocio;
       
        public Evento Evento { get; set; }
        public Animal Animal { get; set; }
        public Animal Cria { get; set; }
        public Animal Cria2 { get; set; }
        Inseminador inseminador;
        List<Desc_Subevento> listadoSubeventos;
        int cantidadcombos = 0;
        System.Threading.Thread t;
        public AbmEvento()
        {
            InitializeComponent();
            eventonegocio       = new Evento_Negocio();
            dessubeventonegocio = new Desc_Subevento_Negocio();
            animalnegocio       = new Animal_Negocio();
            listadoSubeventos   = new List<Desc_Subevento>();           
            Evento              = new Evento();
            Animal              = new Animal();
            Cria                = new Animal();
            Cria2               = new Animal();
            Inicializacion();
        }

        private void gbEvento_Enter(object sender, EventArgs e)
        {

        }

       

        private void Inicializacion()
        {
            txtTambo.Text = Principal.Tambo.Nombre_tambo;        
        }        

        private void CargarComboEventos()
        {
            try
            {
                this.gbEvento.Visible = true;
                var eventos = eventonegocio.RecuperarPorCategoria(Animal.Id_Categoria);
                cbEventos.DataSource = eventos;
                cbEventos.DisplayMember = "nombre_evento";
                cbEventos.ValueMember = "id_evento";
                cbEventos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);
            }


        }

        private void CargarSubEventos()
        {
            try
            {
                this.gbDescripciones.Visible = true;

                while (this.gbDescripciones.Controls.Count >= 1)
                {
                    foreach (System.Windows.Forms.Control item in this.gbDescripciones.Controls)
                    {
                        if (item.GetType().FullName == "System.Windows.Forms.Label" || item.GetType().FullName == "System.Windows.Forms.ComboBox")
                        {
                            this.gbDescripciones.Controls.Remove(item);
                        }

                    }
                }

                int cant = 30;
                if (Evento.SubEventos.Count > 0)
                {
                    Evento.SubEventos = dessubeventonegocio.RecuperarTodos(Evento.SubEventos);

                    
                    foreach (var item in Evento.SubEventos)
                    {
                                 
                        Label lb = new Label();
                        lb.Text = item.Nombre_subevento;
                        lb.Location = new Point(17, cant);
                        lb.Visible = true;
                        lb.AutoSize = true;
                        this.gbDescripciones.Controls.Add(lb);
                        


                        ComboBox combo = new ComboBox();
                        if (Evento.Nombre_evento == "Servicio")
                        {
                            combo.Visible = true;
                            combo.Location = new Point(180, cant);
                            combo.DropDownStyle = ComboBoxStyle.DropDownList;
                            
                            combo.SelectionChangeCommitted += Combo_SelectionChangeCommitted;
                            combo.DataSource = Principal.Tambo.Inseminadores;
                            combo.DisplayMember = "nombre_inseminador";
                            combo.ValueMember = "id_inseminador";
                            combo.SelectedIndex = -1;


                        }
                        
                        else {

                            combo.Visible = true;
                            combo.Location = new Point(180, cant);
                            combo.DropDownStyle = ComboBoxStyle.DropDownList;
                            combo.SelectionChangeCommitted += Combo_SelectionChangeCommitted;
                            combo.DataSource = item.Descripciones_Subeventos;
                            combo.DisplayMember = "descripcion";
                            combo.ValueMember = "id_desc";
                           
                            combo.SelectedIndex = -1;
                            
                        }
                        
                        this.gbDescripciones.Controls.Add(combo);
                        
                        cant = cant + 30;


                    }

                    foreach (System.Windows.Forms.Control item in this.gbDescripciones.Controls)
                    {
                        if (item.GetType().FullName == "System.Windows.Forms.ComboBox")
                        {
                            var combo = (ComboBox)item;
                            combo.SelectedIndex = -1;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);
            }
           

        }

        private void Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var combo = (ComboBox)sender;
                int cant = 10;
                if (combo.SelectedIndex != -1)
                {
                    var descripcion = listadoSubeventos.Where(x => x.Id_subevento == ((Desc_Subevento)combo.SelectedItem).Id_subevento).FirstOrDefault();
                    listadoSubeventos.Remove(descripcion);
                    if (Evento.Nombre_evento == "Servicio")
                    {
                        inseminador = new Inseminador();
                        inseminador = ((Inseminador)combo.SelectedItem);
                        Desc_Subevento des = dessubeventonegocio.RecuperarPorNombre("Inseminador");

                        listadoSubeventos.Add(des);
                    }
                    else
                    {
                        listadoSubeventos.Add((Desc_Subevento)combo.SelectedItem);
                    }

                    if ( (  (Evento.Nombre_evento == "Parto") 
                            &&  
                            ( 
                                ((Desc_Subevento)combo.SelectedItem).Descripcion == "Vivo"
                                 &&
                                (listadoSubeventos.Exists(x => x.Descripcion == "Mell. Hembra-Macho" ||
                                x.Descripcion == "Mell. Hembra-Hembra" || x.Descripcion == "Mell. Macho-Macho"))
                            )                         
                            ||
                            (
                                (
                                ((Desc_Subevento)combo.SelectedItem).Descripcion == "Mell. Hembra-Macho" ||
                                ((Desc_Subevento)combo.SelectedItem).Descripcion == "Mell. Hembra-Hembra" ||
                                ((Desc_Subevento)combo.SelectedItem).Descripcion == "Mell. Macho-Macho"
                                )
                                &&
                                (listadoSubeventos.Exists(x => x.Descripcion == "Vivo"))
                            )
                        )
                      )

                    {
                        for (int i = 0; i < this.gbDescripciones.Controls.Count; i++)
                        {
                            foreach (System.Windows.Forms.Control item in this.gbDescripciones.Controls)
                            {
                                if (item.GetType().FullName == "System.Windows.Forms.Button")
                                {
                                    this.gbDescripciones.Controls.Remove(item);
                                }

                            }
                        }
                       

                            
                            for (int i = 1; i <= 2; i++)
                            {
                                Button button = new Button();
                                button.Location = new Point(cant, 127);

                                button.Text = "Agregar cria " + i;
                                button.Click += Button_Click;
                                button.Visible = true;
                                cant = cant + 286;
                                this.gbDescripciones.Controls.Add(button);
                            }


                    }
                    else if (   (Evento.Nombre_evento == "Parto") &&
                                    (
                                    ((Desc_Subevento)combo.SelectedItem).Descripcion == "Vivo" ||
                                    listadoSubeventos.Exists(x => x.Descripcion == "Vivo")
                                    )                          
                           )
                    {

                        for (int i = 0; i < this.gbDescripciones.Controls.Count; i++)
                        {
                            foreach (System.Windows.Forms.Control item in this.gbDescripciones.Controls)
                            {
                                if (item.GetType().FullName == "System.Windows.Forms.Button")
                                {
                                    this.gbDescripciones.Controls.Remove(item);
                                }

                            }
                        }
                        Button button = new Button();
                            button.Location = new Point(10, 127);

                            button.Text = "Agregar cria ";
                            button.Click += Button_Click;
                            button.Visible = true;
                            this.gbDescripciones.Controls.Add(button);
                        
                    }
                    else if (Evento.Nombre_evento == "Parto" && 
                                (
                                    ((Desc_Subevento)combo.SelectedItem).Descripcion == "Muerto" ||
                                    listadoSubeventos.Exists(x => x.Descripcion == "Muerto")
                                )
                            )

                    {

                        for (int i = 0; i < this.gbDescripciones.Controls.Count; i++)
                        {
                            foreach (System.Windows.Forms.Control item in this.gbDescripciones.Controls)
                            {
                                if (item.GetType().FullName == "System.Windows.Forms.Button")
                                {
                                    this.gbDescripciones.Controls.Remove(item);
                                }

                            }
                        }
                            
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                var boton = (Button)sender;
                AbmAnimales altaAnimales = new AbmAnimales(Principal.ModoForm.CRIA,Animal);
                altaAnimales.txtRPMadre.Text = Animal.Caravana.ToString();
                altaAnimales.ShowDialog();

                if (altaAnimales.Animal.Rp != 0)
                {
                    if (Cria.Rp == 0 && Cria2.Rp == 0)
                    {
                        Cria = altaAnimales.Animal;
                        lbcria1.Text = "Caravana cría: " + Cria.Caravana;
                        lbcria1.Visible = true;
                    }
                    else if (Cria.Rp != 0 && Cria2.Rp == 0)
                    {
                        Cria2 = altaAnimales.Animal;
                        lbcria1.Text = "Caravana segunda cría: " + Cria2.Caravana;
                        lbcria2.Visible = true;
                    }

                }
               
                //Cria = altaAnimales.Animal;
                //MessageBox.Show("Se ha cargado correctamente la cria. \n " +
                //                 "Caravana: "   + Cria.Caravana +
                //                 "\n Nombre: "  + Cria.Nombre_animal,"Alta de la cria",MessageBoxButtons.OK);
                boton.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);
            }
            
        }

        private void LimpiarControles()
        {

            lbCategoriaAnimal.Text = "";
            lbNombreAnimal.Text = "";
            lbCaravana.Text = "";
            lbEstadoAnimal.Text = "";
            lbcria1.Text = "";

            gbEvento.Visible = false;
            gbDescripciones.Visible = false;
            dtpFecha.Value = DateTime.Now;
        }


        private void MostrarContenedores(bool valor)
        {

            this.gbEvento.Visible = valor;
            this.gbDescripciones.Visible = valor;


        }

        private void start()
        {
            longProcess(15);
        }

        private void longProcess(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
            if (this.InvokeRequired) this.Invoke(new Action(finishProcess));
        }

        private void finishProcess()
        {
            //progressBar1.Style = ProgressBarStyle.Blocks;
            //lbSincronizacion.Text = "Finalizado";
            //btnSincronizar.Enabled = true;
            //btnSubir.Enabled = true;
        }

        private void cbEventos_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                t = new System.Threading.Thread(start);
                t.Start();


                if (this.gbDescripciones.Visible == true)
                {
                    this.gbDescripciones.Visible = false;
                }

                if (cbEventos.SelectedIndex > -1)
                {
                    listadoSubeventos = new List<Desc_Subevento>();
                    Evento = (Evento)cbEventos.SelectedItem;
                    Evento = eventonegocio.TraerSubEventosEvento(Evento);
                    cantidadcombos = Evento.SubEventos.Count;

                    CargarSubEventos();
                }
                finishProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ocurrió un error",  MessageBoxButtons.OK);
                
            }
            
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {               
                //dtpFecha.Value = dtpFecha.Value.AddMinutes(1);

                if (ValidarCampos())
                {
                    if (Evento.Nombre_evento == "Servicio")
                    {
                        eventonegocio.Alta_Evento(Animal, Evento, listadoSubeventos, dtpFecha.Value, inseminador, null);
                    }
                    else
                    {
                        eventonegocio.Alta_Evento(Animal, Evento, listadoSubeventos, dtpFecha.Value, null, null);
                    }

                    MessageBox.Show("Se ha guardado con exito el evento", "Alta evento", MessageBoxButtons.OK);
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);
            }
        }


        private bool ValidarCampos()
        {

            if (Animal.Rp == 0)
            {
                MessageBox.Show("Debe seleccionar un animal", "Advertencia", MessageBoxButtons.OK);
                return false;
            }

            if (Evento.Id_evento == 0)
            {
                MessageBox.Show("Debe seleccionar un evento", "Advertencia", MessageBoxButtons.OK);
                return false;
            }

            

            foreach (System.Windows.Forms.Control item in this.gbDescripciones.Controls)
           {
                    if (item.GetType().FullName == "System.Windows.Forms.ComboBox")
                    {
                        var combo = (ComboBox)item;
                        if (combo.SelectedIndex == -1)
                        {
                            MessageBox.Show("Debe seleccionar la descripcion del evento", "Advertencia", MessageBoxButtons.OK);
                            return false;
                        
                        }
                        
                    }

           }

            return true;


        }



        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gbEvento.Visible == true || this.gbDescripciones.Visible == true)
                {
                    Evento = new Evento();
                    listadoSubeventos = new List<Desc_Subevento>();
                    this.gbEvento.Visible = false;
                    this.gbDescripciones.Visible = false;
                }


                ListaSeleccionAnimal form = new ListaSeleccionAnimal("Evento");
                form.ShowDialog();

                if (form.Animal.Rp != 0)
                {
                    Animal = form.Animal;
                    lbError.Text = "";
                    lbCaravana.Text = "Caravana: " + Animal.Caravana;
                    lbNombreAnimal.Text = "Nombre: " + Animal.Nombre_animal;
                    lbCategoriaAnimal.Text = "Tipo: " + Animal.Categoria.Descripcion;
                    lbEstadoAnimal.Text = "Estado actual: " + Animal.Estado_animal;
                    CargarComboEventos();
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

        private void AbmEvento_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
        }
    }
}
