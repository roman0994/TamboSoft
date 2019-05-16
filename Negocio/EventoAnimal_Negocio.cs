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
            try
            {
                evdatos = new EventoAnimal_Datos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            try
            {
                return evdatos.TieneEventos(rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
