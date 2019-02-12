using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        int _id_provincia;
        string _nombre_provincia;


        public int Id_provincia { get => _id_provincia; set => _id_provincia = value; }
        public string Nombre_provincia { get => _nombre_provincia; set => _nombre_provincia = value; }

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
