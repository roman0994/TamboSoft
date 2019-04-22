using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EventoAnimal_DescSubevento
    {
        private int _id_desc_evento;
        private int _rp;
        private int _id_evento;
        private int _id_desc;
        private DateTime _fecha_desc;
        private string _nombre_animal;
        private string _nombre_evento;
        private string _nombre_subevento;
        private string _descripcion;
        private int _id_tambo;
        private string _nombre_tambo;
        private int _id_inseminador;
        private string _nombre_inseminador;
        private bool _estado_evento;

        public int Id_desc_evento { get => _id_desc_evento; set => _id_desc_evento = value; }
        public int Rp { get => _rp; set => _rp = value; }
        public int Id_evento { get => _id_evento; set => _id_evento = value; }
        public int Id_desc { get => _id_desc; set => _id_desc = value; }
        public DateTime Fecha_desc { get => _fecha_desc; set => _fecha_desc = value; }
        public string Nombre_animal { get => _nombre_animal; set => _nombre_animal = value; }
        public string Nombre_evento { get => _nombre_evento; set => _nombre_evento = value; }
        public string Nombre_subevento { get => _nombre_subevento; set => _nombre_subevento = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Id_tambo { get => _id_tambo; set => _id_tambo = value; }
        public string Nombre_tambo { get => _nombre_tambo; set => _nombre_tambo = value; }
        public int Id_inseminador { get => _id_inseminador; set => _id_inseminador = value; }
        public string Nombre_inseminador { get => _nombre_inseminador; set => _nombre_inseminador = value; }
        public bool Estado_evento { get => _estado_evento; set => _estado_evento = value; }
        public string Caravana { get; set; }


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
