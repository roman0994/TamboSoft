﻿using System;
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
    public partial class DetalleEventos : Form
    {
        public DetalleEventos()
        {
            InitializeComponent();
            this.dgvDetalles.AutoGenerateColumns = false;
        }

        
    }
}
