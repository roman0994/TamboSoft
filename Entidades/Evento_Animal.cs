using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento_Animal
    {
        private int _rp;
        private int _id_evento;
        private string _nombre_animal;
        private string _nombre_evento;

        public int Rp { get => _rp; set => _rp = value; }
        public int Id_evento { get => _id_evento; set => _id_evento = value; }
        public string Nombre_animal { get => _nombre_animal; set => _nombre_animal = value; }
        public string Nombre_evento { get => _nombre_evento; set => _nombre_evento = value; }

        public Evento_Animal()
        {

        }

        public Evento_Animal(int rp, int id_evento, string nombre_animal, string nombre_evento)
        {
            this.Rp = rp;
            this.Id_evento = id_evento;
            this.Nombre_animal = nombre_animal;
            this.Nombre_evento = nombre_evento;
        }
    }
}
