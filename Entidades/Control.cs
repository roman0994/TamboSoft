﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Control
    {
        private int _id_control;
        private decimal _primer_control;
        private decimal _segundo_control;
        private decimal _porcentaje_grasa;
        private decimal _kg_grasa;

        public int Id_control { get => _id_control; set => _id_control = value; }
        public decimal Primer_control { get => _primer_control; set => _primer_control = value; }
        public decimal Segundo_control { get => _segundo_control; set => _segundo_control = value; }
        public decimal Porcentaje_grasa { get => _porcentaje_grasa; set => _porcentaje_grasa = value; }
        public decimal Kg_grasa { get => _kg_grasa; set => _kg_grasa = value; }

        public Control()
        {

        }

        public Control(int id, decimal primer_control, decimal segundo_control, decimal porcentaje_grasa, decimal kg_grasa)
        {
            this.Id_control = id;
            this.Primer_control = primer_control;
            this.Segundo_control = segundo_control;
            this.Porcentaje_grasa = porcentaje_grasa;
            this.Kg_grasa = kg_grasa;
        }
    }
}
