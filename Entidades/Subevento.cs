using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Subevento
    {
        

        public int Id_subevento { get; set; }
        public string Nombre_subevento { get; set; }
        public bool Estado_subevento { get; set; }
        
        public List<Desc_Subevento> Descripciones_Subeventos { get; set; }

        public List<Evento> Eventos { get; set; }


        public Subevento()
        {

        }

        public Subevento(int id, string nombre, bool estado)
        {
            this.Id_subevento = id;
            this.Nombre_subevento = nombre;
            this.Estado_subevento = estado;
        }
    }
}
