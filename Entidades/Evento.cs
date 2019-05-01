using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento
    {



        public int Id_evento { get; set; }
        public string Nombre_evento { get; set; }
        public int Tipo_Categoria { get; set; }

       
        public List<Subevento> SubEventos { get; set; }
        public List<Animal> Animales { get; set; }



        public Evento()
        {

        }

        public Evento(int id, string nombre_evento)
        {
            this.Id_evento = id;
            this.Nombre_evento = nombre_evento;
        }
    }
}
