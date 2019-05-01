using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tambo
    {

        public int Id_tambo { get; set; }
        public string Nombre_tambo { get; set; }
        public decimal Superficie { get; set; }
        public bool Estado_tambo { get; set; }
        public int Id_localidad { get; set; }
        public string Nombre_localidad { get; set; }
        public string Nombre_provincia { get; set; }
        public int Id_usuario { get; set; }


        public Localidad Localidad { get; set; }

        
        public Usuario Usuario { get; set; }


        
        public List<Inseminador> Inseminadores { get; set; }

        
        public List<Animal> Animales { get; set; }

        
        public List<EventoAnimal_DescSubevento> EventoAnimal_DescSubeventos_Tambos { get; set; }



        public Tambo()
        {

        }

        public Tambo(int id_tambo, string nombre_tambo, decimal superficie, bool estado_tambo, int id_localidad, string nombre_localidad,string nombre_provincia,int id_usuario)
        {
            Id_tambo = id_tambo;
            Nombre_tambo = nombre_tambo;
            Superficie = superficie;
            Estado_tambo = estado_tambo;
            Id_localidad = id_localidad;
            Nombre_localidad = nombre_localidad;
            Nombre_provincia = nombre_provincia;
            Id_usuario = id_usuario;
        }
    }
}
