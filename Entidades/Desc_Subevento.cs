using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Desc_Subevento
    {
       

        public int Id_desc { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
        public bool Estado_desc { get; set; }
        public int Id_subevento { get; set; }
        public string Nombre_subevento { get; set; }
        public Evento evento { get; set; }

        public List<Evento_Animal> Evento_Animales { get; set; }


        public Desc_Subevento()
        {

        }

        public Desc_Subevento(int id, string desc, string abreviacion, bool estado_desc, int id_subevento, string nombre_subevento)
        {
            this.Id_desc = id;
            this.Descripcion = desc;
            this.Abreviacion = abreviacion;
            this.Estado_desc = estado_desc;
            this.Id_subevento = id_subevento;
            this.Nombre_subevento = nombre_subevento;
        }
    }
}
