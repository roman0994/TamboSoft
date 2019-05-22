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
    public partial class ListadoModifSincronizacion : Form
    {
        public ListadoModifSincronizacion(List<AnimalApi> listaModificados)
        {
            InitializeComponent();
            CargarGrilla(listaModificados);
        }

        public void CargarGrilla(List<AnimalApi> listaModificados)
        {
            try
            {
                this.dgvSincronizacion.AutoGenerateColumns = false;

                this.dgvSincronizacion.DataSource = listaModificados;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
