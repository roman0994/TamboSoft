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

namespace Escritorio
{
    public partial class Principal : Form
    {
        public int id_tambo;
        public static Tambo Tambo { get; set; }

        public int id_usuario;
        public static Usuario Usuario { get; set; }
        
        Inseminador_Negocio inseminadornegocio = new Inseminador_Negocio();

        public enum EstadoAnimales
        {
            Parto, Aborto, Celo, Vendido, Muerto, Enfermo, Medicado, Preñada, Vivo
        }

        public enum ModoForm
        {
            ALTA,BAJA,MODIFICACION,ELIMINACION,CRIA
        }

        public Principal(int id_tambo)
        {
            InitializeComponent();

            //Bitmap img = new Bitmap(Application.StartupPath+ @"\fondos\fondo1.jpg");
            //this.BackgroundImage = img;
            inseminadornegocio = new Inseminador_Negocio();
            Usuario_Negocio usuario_Negocio = new Usuario_Negocio();
            Tambo = new Tambo();
            //Tambo.Id_tambo = id_tambo;
            CargarTambo(id_tambo);
            Usuario = new Usuario();
            Usuario.Id_usuario = id_usuario;
        }

        private void CargarTambo(int id_tambo)
        {
            try
            {
                //Tambo tambo = new Tambo();
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                Tambo = tamboNegocio.RecuperarUno(id_tambo);
                Tambo.Inseminadores = new List<Inseminador>();
                Tambo.Inseminadores = inseminadornegocio.RecuperarPorTambo(Tambo.Id_tambo);
                this.txtTambo.Text = Tambo.Nombre_tambo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void animalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayAnimales(Principal.Tambo.Id_tambo))
                {
                    ListadoAnimales listadoAnimales = new ListadoAnimales(id_tambo);
                    listadoAnimales.idtambo = id_tambo;
                    listadoAnimales.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee animales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
                if (eventoNegocio.HayEventos(Principal.Tambo.Id_tambo))
                {
                    ListadoEventos listadoEventos = new ListadoEventos(id_tambo);
                    listadoEventos.idtambo = id_tambo;
                    listadoEventos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee eventos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void controlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Control_Animal_Negocio controlNegocio = new Control_Animal_Negocio();
                if (controlNegocio.HayControles(Principal.Tambo.Id_tambo))
                {
                    ListadoControles listadoControles = new ListadoControles(id_tambo);
                    listadoControles.idtambo = id_tambo;
                    listadoControles.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee controles lecheros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void inseminadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Tambo_Inseminador_Negocio insNegocio = new Tambo_Inseminador_Negocio();
                if (insNegocio.HayInseminadores(Principal.Tambo.Id_tambo))
                {
                    ListadoInseminadores listadoInseminadores = new ListadoInseminadores(id_tambo);
                    listadoInseminadores.idtambo = id_tambo;
                    listadoInseminadores.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee inseminadores registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void gestiónAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayAnimales(Principal.Tambo.Id_tambo))
                {
                    GestionAnimales gestionAnimales = new GestionAnimales(id_tambo);
                    gestionAnimales.idtambo = id_tambo;
                    gestionAnimales.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee animales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void gestiónEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EventoAnimal_DescSubevento_Negocio eventoNegocio = new EventoAnimal_DescSubevento_Negocio();
                if (eventoNegocio.HayEventos(Principal.Tambo.Id_tambo))
                {
                    GestionEventos gestionEventos = new GestionEventos(id_tambo);
                    gestionEventos.idtambo = id_tambo;
                    gestionEventos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee eventos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void altaAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AltaAnimales alta = new AltaAnimales();
                alta.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void altaEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayAnimales(Principal.Tambo.Id_tambo))
                {
                    //AltaEventos alta = new AltaEventos(id_tambo);
                    AltaEventos form = new AltaEventos(Tambo.Id_tambo);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No es posible cargar eventos si no exiten animales cargados. Primero debe dar de alta un animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestiónControlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Control_Animal_Negocio controlNegocio = new Control_Animal_Negocio();
                if (controlNegocio.HayControles(Principal.Tambo.Id_tambo))
                {
                    GestionControles controles = new GestionControles(id_tambo);
                    controles.idtambo = id_tambo;
                    controles.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee controles lecheros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void nuevoControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                {
                    AltaControles alta = new AltaControles(id_tambo);
                    alta.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No es posible cargar controles si no exiten animales cargados. Primero debe dar de alta un animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DatosTambo datosTambo = new DatosTambo(id_tambo);
                datosTambo.idtambo = id_tambo;
                datosTambo.id_usuario = id_usuario;
                datosTambo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                if (tamboNegocio.HayTambos(id_usuario))
                {
                    Login login = new Login();
                    login.ShowDialog();
                }
                else
                {
                    LoginAltaTambos loginAltaTambos = new LoginAltaTambos();
                    loginAltaTambos.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Personal personal = new Personal(id_tambo);
                personal.idtambo = id_tambo;
                personal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void otrosTambosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                if (tamboNegocio.HayOtrosTambos(Principal.Tambo.Id_tambo, id_usuario))
                {
                    GestionTambos gestionTambos = new GestionTambos(id_tambo);
                    gestionTambos.idtambo = id_tambo;
                    gestionTambos.id_usuario = id_usuario;
                    gestionTambos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existen otros tambos registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void cargarTamboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AltaTambos altaTambos = new AltaTambos();
                altaTambos.id_usuario = id_usuario;
                altaTambos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void acercaDeTamboSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AcercaDeTamboSoft tamboSoft = new AcercaDeTamboSoft();
                tamboSoft.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void reporteEventosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayAnimales(Principal.Tambo.Id_tambo))
                {
                    vpExistencia vp = new vpExistencia();
                    vp.Show();
                }
                else
                {
                    MessageBox.Show("El tambo no posee animales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void reporteProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                {
                    ReporteProduccion reporteEventos = new ReporteProduccion();
                    reporteEventos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee vacas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                {
                    ReporteProduccionPorFecha reporteReproduccionPorFecha = new ReporteProduccionPorFecha(id_tambo);
                    reporteReproduccionPorFecha.idtambo = id_tambo;
                    reporteReproduccionPorFecha.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee animales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void porAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                {
                    ReporteProduccionPorAnimal reporteReproduccionPorAnimal = new ReporteProduccionPorAnimal(id_tambo);
                    reporteReproduccionPorAnimal.idtambo = id_tambo;
                    reporteReproduccionPorAnimal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee animales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void reproducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Animal_Negocio animalNegocio = new Animal_Negocio();
                if (animalNegocio.HayVacas(Principal.Tambo.Id_tambo))
                {
                    ReporteReproduccion reporteReproduccion = new ReporteReproduccion(id_tambo);
                    reporteReproduccion.idtambo = id_tambo;
                    reporteReproduccion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El tambo no posee animales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PruebaSincronizacion sincronizacion = new PruebaSincronizacion();
                sincronizacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
                Tambo_Negocio tamboNegocio = new Tambo_Negocio();

                LoginUsuario login = new LoginUsuario();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
