﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Escritorio
{
    public partial class vpProduccionPorFechaDia : Form
    {
        public int idtambo;
        public int bandera;
        public DateTime fecha;
        public int rp;

        public vpProduccionPorFechaDia()
        {
            InitializeComponent();
        }

        private void vpProduccionPorFecha_Load(object sender, EventArgs e)
        {
            try
            {
                Control_Animal_Negocio controlAnimalNegocio = new Control_Animal_Negocio();
                rptProduccionPorFechaDia reporte = new rptProduccionPorFechaDia();

                reporte.SetDataSource(controlAnimalNegocio.ProduccionPorFiltroDiaYAnimal(idtambo, fecha, rp));
                crvProduccionPorDia.ReportSource = reporte;
                crvProduccionPorDia.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrió un error", MessageBoxButtons.OK);

            }
        }
    }
}
