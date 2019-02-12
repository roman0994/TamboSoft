using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Raza_Negocio
    {
        Raza_Datos razaDatos = new Raza_Datos();
        
        public List<Raza> RecuperarTodos()
        {
            return razaDatos.RecuperarTodos();
        }

        public Raza RecuperarUno(int id)
        {
            return razaDatos.RecuperarUno(id);
        }
    }
}
