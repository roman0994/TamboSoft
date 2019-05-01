using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Control_Animal
    {


        public DateTime Fecha_control { get; set; }
        public int Id_control { get; set; }
        public int Rp { get; set; }
        public decimal Primer_control { get; set; }
        public decimal Segundo_control { get; set; }
        public decimal Porcentaje_grasa { get; set; }
        public decimal Kg_grasa { get; set; }
        public string Nombre_animal { get; set; }
        public int Id_tambo { get; set; }
        public string Nombre_tambo { get; set; }
        public decimal Grasa_segundocontrol { get; set; }
        public decimal Grasa_primercontrol { get; set; }
        public string Caravana { get; set; }

        public List<Animal> Animales { get; set; }


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
