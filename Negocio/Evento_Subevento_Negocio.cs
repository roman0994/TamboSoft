using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class Evento_Subevento_Negocio
    {
        Evento_Subevento_Datos eventoSubeventoDatos = new Evento_Subevento_Datos();

        public bool HayEventos_Subeventos()
        {
            try
            {
                return eventoSubeventoDatos.HayEventos_Subeventos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
