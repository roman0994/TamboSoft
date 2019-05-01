using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {


        public int Id_provincia { get; set; }
        public string Nombre_provincia { get; set; }

        public List<Localidad> Localidades { get; set; }

        public Provincia()
        {

        }

        public Provincia(int id_provincia, string nombre_provincia)
        {
            Id_provincia = id_provincia;
            Nombre_provincia = nombre_provincia;
        }
    }
}
