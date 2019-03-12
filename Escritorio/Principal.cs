using System;
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

        public Principal(int id_tambo)
        {
            InitializeComponent();
            CargarTambo(id_tambo);
            //Bitmap img = new Bitmap(Application.StartupPath+ @"\fondos\fondo1.jpg");
            //this.BackgroundImage = img;

        }

        private void CargarTambo(int id_tambo)
        {
            Tambo tambo = new Tambo();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        private void animalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListadoAnimales listadoAnimales = new ListadoAnimales(id_tambo);
            listadoAnimales.idtambo = id_tambo;
            listadoAnimales.ShowDialog();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoEventos listadoEventos = new ListadoEventos(id_tambo);
            listadoEventos.idtambo = id_tambo;
            listadoEventos.ShowDialog();
        }

        private void controlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListadoControles listadoControles = new ListadoControles(id_tambo);
            listadoControles.idtambo = id_tambo;
            listadoControles.ShowDialog();
        }

        private void inseminadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoInseminadores listadoInseminadores = new ListadoInseminadores(id_tambo);
            listadoInseminadores.idtambo = id_tambo;
            listadoInseminadores.ShowDialog();
        }

        private void gestiónAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionAnimales gestionAnimales = new GestionAnimales(id_tambo);
            gestionAnimales.ShowDialog();
        }

        private void gestiónEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEventos gestionEventos = new GestionEventos(id_tambo);
            gestionEventos.idtambo = id_tambo;
            gestionEventos.ShowDialog();
        }

        private void altaAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAnimales alta = new AltaAnimales(id_tambo);
            alta.ShowDialog();
        }

        private void altaEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaEventos alta = new AltaEventos(id_tambo);
            alta.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestiónControlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionControles controles = new GestionControles(id_tambo);
            controles.ShowDialog();
        }

        private void nuevoControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaControles alta = new AltaControles(id_tambo);
            alta.ShowDialog();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosTambo datosTambo = new DatosTambo(id_tambo);
            datosTambo.idtambo = id_tambo;
            datosTambo.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            if (tamboNegocio.HayTambos())
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

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal(id_tambo);
            personal.idtambo = id_tambo;
            personal.ShowDialog();
        }

        private void otrosTambosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionTambos gestionTambos = new GestionTambos(id_tambo);
            gestionTambos.idtambo = id_tambo;
            gestionTambos.ShowDialog();
        }

        private void cargarTamboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTambos altaTambos = new AltaTambos();
            altaTambos.ShowDialog();
        }

        private void acercaDeTamboSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDeTamboSoft tamboSoft = new AcercaDeTamboSoft();
            tamboSoft.ShowDialog();
        }

        private void reporteEventosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteEventos reporteEventos = new ReporteEventos(id_tambo);
            reporteEventos.idtambo = id_tambo;
            reporteEventos.ShowDialog();
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteProduccionPorFecha reporteReproduccionPorFecha = new ReporteProduccionPorFecha(id_tambo);
            reporteReproduccionPorFecha.idtambo = id_tambo;
            reporteReproduccionPorFecha.ShowDialog();
        }

        private void porAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteProduccionPorAnimal reporteReproduccionPorAnimal = new ReporteProduccionPorAnimal(id_tambo);
            reporteReproduccionPorAnimal.idtambo = id_tambo;
            reporteReproduccionPorAnimal.ShowDialog();
        }

        private void reproducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteReproduccion reporteReproduccion = new ReporteReproduccion(id_tambo);
            reporteReproduccion.idtambo = id_tambo;
            reporteReproduccion.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
