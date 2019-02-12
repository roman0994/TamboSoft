using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento_Subevento
    {
        private int _id_evento;
        private int _id_subevento;
        private string _nombre_evento;
        private string _nombre_subevento;

        public int Id_evento { get => _id_evento; set => _id_evento = value; }
        public int Id_subevento { get => _id_subevento; set => _id_subevento = value; }
        public string Nombre_evento { get => _nombre_evento; set => _nombre_evento = value; }
        public string Nombre_subevento { get => _nombre_subevento; set => _nombre_subevento = value; }

        public Evento_Subevento()
        {

        }
        
        public Evento_Subevento(int id_evento, int id_subevento, string nombre_evento, string nombre_subevento)
        {
            this.Id_evento = id_evento;
            this.Id_subevento = id_subevento;
            this.Nombre_evento = nombre_evento;
            this.Nombre_subevento = nombre_subevento;
        }
    }
}
