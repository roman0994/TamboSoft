using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidad
    {


        public int Id_localidad { get; set; }
        public string Nombre_localidad { get; set; }
        public int Id_provincia { get; set; }
        public string Nombre_provincia { get; set; }

        public Provincia Provincia { get; set; }

        public List<Inseminador> Inseminadores { get; set; }

        public List<Tambo> Tambos { get; set; }



        public Localidad()
        {

        }

        public Localidad(int id_localidad, string nombre_localidad, int id_provincia, string nombre_provincia)
        {
            Id_localidad = id_localidad;
            Nombre_localidad = nombre_localidad;
            Id_provincia = id_provincia;
            Nombre_provincia = nombre_provincia;
        }
    }
}
