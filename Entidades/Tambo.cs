using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tambo
    {
        int _id_tambo;
        string _nombre_tambo;
        decimal _superficie;
        bool _estado_tambo;
        int _id_localidad;
        string _nombre_localidad;
        string _nombre_provincia;
        int _id_usuario;


        public int Id_tambo { get => _id_tambo; set => _id_tambo = value; }
        public string Nombre_tambo { get => _nombre_tambo; set => _nombre_tambo = value; }
        public decimal Superficie { get => _superficie; set => _superficie = value; }
        public bool Estado_tambo { get => _estado_tambo; set => _estado_tambo = value; }
        public int Id_localidad { get => _id_localidad; set => _id_localidad = value; }
        public string Nombre_localidad { get => _nombre_localidad; set => _nombre_localidad = value; }        
        public string Nombre_provincia { get => _nombre_provincia; set => _nombre_provincia = value; }
        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }

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
