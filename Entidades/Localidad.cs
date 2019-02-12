using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidad
    {
        int _id_localidad;
        string _nombre_localidad;
        int _id_provincia;
        string _nombre_provincia;


        public int Id_localidad { get => _id_localidad; set => _id_localidad = value; }
        public string Nombre_localidad { get => _nombre_localidad; set => _nombre_localidad = value; }
        public int Id_provincia { get => _id_provincia; set => _id_provincia = value; }
        public string Nombre_provincia { get => _nombre_provincia; set => _nombre_provincia = value; }

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
