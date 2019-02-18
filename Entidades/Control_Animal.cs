using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Control_Animal
    {
        private DateTime _fecha_control;
        private int _id_control;
        private int _rp;
        private string _nombre_animal;
        private int _id_tambo;
        private string _nombre_tambo;
        private decimal _primer_control;
        private decimal _segundo_control;
        private decimal _porcentaje_grasa;
        private decimal _kg_grasa;
        private decimal grasa_primercontrol;
        private decimal grasa_segundocontrol;

        public DateTime Fecha_control { get => _fecha_control; set => _fecha_control = value; }
        public int Id_control { get => _id_control; set => _id_control = value; }
        public int Rp { get => _rp; set => _rp = value; }
        public decimal Primer_control { get => _primer_control; set => _primer_control = value; }
        public decimal Segundo_control { get => _segundo_control; set => _segundo_control = value; }
        public decimal Porcentaje_grasa { get => _porcentaje_grasa; set => _porcentaje_grasa = value; }
        public decimal Kg_grasa { get => _kg_grasa; set => _kg_grasa = value; }
        public string Nombre_animal { get => _nombre_animal; set => _nombre_animal = value; }
        public int Id_tambo { get => _id_tambo; set => _id_tambo = value; }
        public string Nombre_tambo { get => _nombre_tambo; set => _nombre_tambo = value; }
        public decimal Grasa_segundocontrol { get => grasa_segundocontrol; set => grasa_segundocontrol = value; }
        public decimal Grasa_primercontrol { get => grasa_primercontrol; set => grasa_primercontrol = value; }

        public Control_Animal()
        {

        }

        public Control_Animal(DateTime fecha_control, int id_control, int rp, string nombre_animal, int id_tambo,string nombre_tambo, decimal primer_control, decimal segundo_control, decimal porcentaje_grasa, decimal kg_grasa, decimal grasa_primercontrol, decimal grasa_segundocontrol)
        {
            this.Fecha_control = fecha_control;
            this.Id_control = id_control;
            this.Rp = rp;
            this.Nombre_animal = nombre_animal;
            this.Id_tambo = id_tambo;
            this.Nombre_tambo = nombre_tambo;
            this.Primer_control = primer_control;
            this.Segundo_control = segundo_control;
            this.Porcentaje_grasa = porcentaje_grasa;
            this.Kg_grasa = kg_grasa;
            this.Grasa_primercontrol = grasa_primercontrol;
            this.Grasa_segundocontrol = grasa_segundocontrol;
        }
    }
}
