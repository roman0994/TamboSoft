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
    public partial class ReporteProduccion : Form
    {
        public int idtambo;
        public ReporteProduccion(int id_tambo)
        {
            InitializeComponent();
            CargarTextBoxTambo(id_tambo);
            CargarComboBusqueda();
        }

        public void CargarComboBusqueda()
        {
            this.cbBuscar.Items.Add("Día");
            this.cbBuscar.Items.Add("Mes");
            this.cbBuscar.Items.Add("Año");
            this.cbBuscar.SelectedIndex = -1;
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();

            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }
    }
}
