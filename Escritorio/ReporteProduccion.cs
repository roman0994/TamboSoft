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
            CargarGrilla(id_tambo);
        }

        public void CargarTextBoxTambo(int id_tambo)
        {
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            Tambo tambo = new Tambo();

            tambo = tamboNegocio.RecuperarUno(id_tambo);
            this.txtTambo.Text = tambo.Nombre_tambo;
        }

        public void CargarGrilla(int id_tambo)
        {
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            this.dgvControles.DataSource = controlAnimalNegocio.RecuperarPorTambo(id_tambo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = this.dateTimePicker1.Value;
            DateTime fechaHasta = this.dateTimePicker2.Value;
            Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
            this.dgvControles.DataSource = controlAnimalNegocio.RecuperarPorTamboPorFecha(idtambo,fechaDesde,fechaHasta);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
