using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EventoAnimal_Negocio
    {
        EventoAnimal_Datos evdatos;

        public EventoAnimal_Negocio()
        {
            evdatos = new EventoAnimal_Datos();
        }

        public void Insertar(Evento_Animal eventoanimal)
        {
            try
            {
                evdatos.Insertar(eventoanimal);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public bool TieneEventos(int rp)
        {
            return evdatos.TieneEventos(rp);
        }

    }
}
