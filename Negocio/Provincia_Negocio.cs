using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class Provincia_Negocio
    {
        Provincia_Datos provinciaDatos = new Provincia_Datos();

        public List<Provincia> RecuperarTodos()
        {
            return provinciaDatos.RecuperarTodos();
        }

        public Provincia RecuperarUno(int id)
        {
            return provinciaDatos.RecuperarUno(id);
        }

        public bool HayProvincias()
        {
            return provinciaDatos.HayProvincias();
        }
    }
}
