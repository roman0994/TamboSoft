using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento
    {
        private int _id_evento;
        private string _nombre_evento;


        public int Id_evento { get => _id_evento; set => _id_evento = value; }
        public string Nombre_evento { get => _nombre_evento; set => _nombre_evento = value; }
       

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
