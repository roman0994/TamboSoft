using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EventoAnimal_DescSubevento
    {


        public int Id_desc_evento { get; set; }
        public int Rp { get; set; }
        public int Id_evento { get; set; }
        public int Id_desc { get; set; }
        public DateTime Fecha_desc { get; set; }
        public string Nombre_animal { get; set; }
        public string Nombre_evento { get; set; }
        public string Nombre_subevento { get; set; }
        public string Descripcion { get; set; }
        public int Id_tambo { get; set; }
        public string Nombre_tambo { get; set; }
        public int Id_inseminador { get; set; }
        public string Nombre_inseminador { get; set; }
        public bool Estado_evento { get; set; }
        public string Caravana { get; set; }

        public Tambo Tambo { get; set; }

        public Inseminador Inseminador { get; set; }

        public EventoAnimal_DescSubevento()
        {

        }

        public EventoAnimal_DescSubevento(int id_desc_evento,int rp, int id_evento, int id_desc, DateTime fecha_desc, string nombre_animal, string nombre_evento, string nombre_subevento, string descripcion, int id_tambo, string nombre_tambo, int id_inseminador, string nombre_inseminador,bool estado_evento)
        {
            this.Id_desc_evento = id_desc_evento;
            this.Rp = rp;
            this.Id_evento = id_evento;
            this.Id_desc = id_desc;
            this.Fecha_desc = fecha_desc;
            this.Nombre_animal = nombre_animal;
            this.Nombre_evento = nombre_evento;
            this.Nombre_subevento = nombre_subevento;
            this.Descripcion = descripcion;
            this.Id_tambo = id_tambo;
            this.Nombre_tambo = nombre_tambo;
            this.Id_inseminador = id_inseminador;
            this.Nombre_inseminador = nombre_inseminador;
            this.Estado_evento = estado_evento;
        }

        public EventoAnimal_DescSubevento(int id_desc_evento, int rp, int id_evento, int id_desc, DateTime fecha_desc, string nombre_animal, string nombre_evento, string nombre_subevento, string descripcion, int id_tambo, string nombre_tambo, bool estado_evento)
        {
            this.Id_desc_evento = id_desc_evento;
            this.Rp = rp;
            this.Id_evento = id_evento;
            this.Id_desc = id_desc;
            this.Fecha_desc = fecha_desc;
            this.Nombre_animal = nombre_animal;
            this.Nombre_evento = nombre_evento;
            this.Nombre_subevento = nombre_subevento;
            this.Descripcion = descripcion;
            this.Id_tambo = id_tambo;
            this.Nombre_tambo = nombre_tambo;
            this.Estado_evento = estado_evento;
        }
    }
}
