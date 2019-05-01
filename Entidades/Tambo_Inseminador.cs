using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tambo_Inseminador
    {
       

        public int Id_tambo { get; set;}
        public int Id_inseminador { get; set; }
        public string Nombre_tambo { get; set; }
        public string Nombre_inseminador { get; set; }
        public bool Estado_inseminador { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Dni { get; set; }
        public int Id_localidad { get; set; }
        public string Nombre_localidad { get; set; }

        public Tambo_Inseminador()
        {

        }

        public Tambo_Inseminador(int id_tambo, int id_inseminador, string nombre_tambo, string nombre_inseminador, bool estado, string telefono, string direccion, string dni, int id_loc, string nombre_loc)
        {
            this.Id_tambo = id_tambo;
            this.Id_inseminador = id_inseminador;
            this.Nombre_tambo = nombre_tambo;
            this.Nombre_inseminador = nombre_inseminador;
            this.Estado_inseminador = estado;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Dni = dni;
            this.Id_localidad = id_loc;
            this.Nombre_localidad = nombre_loc;
        }
    }
}
