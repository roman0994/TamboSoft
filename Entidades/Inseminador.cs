using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inseminador
    {


        public int Id_inseminador { get; set; }
        public string Nombre_inseminador { get; set; }
        public bool Estado_inseminador { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Dni { get; set; }
        public int Id_localidad { get; set; }
        public string Nombre_localidad { get; set; }

        public Localidad Localidad { get; set; }

        public List<Tambo> Tambos { get; set; }

        public List<EventoAnimal_DescSubevento> EventoAnimal_DescSubevento_Tambo { get; set; }


        public Inseminador()
        {

        }

        public Inseminador(int id, string nombre, bool estado, string telefono, string direccion, string dni, int id_localidad, string nombre_localidad)
        {
            this.Id_inseminador = id;
            this.Nombre_inseminador = nombre;
            this.Estado_inseminador = estado;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Dni = dni;
            this.Id_localidad = id_localidad;
            this.Nombre_localidad = nombre_localidad;
        }
    }
}
