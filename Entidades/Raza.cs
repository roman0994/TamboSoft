using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Raza
    {


        public int Id_raza { get; set; }
        public string Nombre_raza { get; set; }
        public bool Estado_raza { get; set; }


        public List<Animal> Animales { get; set; }

        public Raza()
        {

        }

        public Raza(int id_raza, string nombre_raza, bool estado_raza)
        {
            Id_raza = id_raza;
            Nombre_raza = nombre_raza;
            Estado_raza = estado_raza;
        }
    }
}
