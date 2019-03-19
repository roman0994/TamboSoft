using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Evento_Negocio
    {
        Evento_Datos eventoDatos = new Evento_Datos();

        public List<Evento> RecuperarTodos()
        {
            return eventoDatos.RecuperarTodos();
        }

        public Evento RecuperarUno(int id)
        {
            return eventoDatos.RecuperarUno(id);
        }

        public bool HayEventos()
        {
            return eventoDatos.HayEventos();
        }
    }
}
