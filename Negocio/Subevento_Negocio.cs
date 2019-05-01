using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using Datos;

namespace Negocio
{
    public class Subevento_Negocio
    {
        Subevento_Datos subeventoDatos;

        public Subevento_Negocio()
        {
            subeventoDatos = new Subevento_Datos();
        }



        public bool HaySubeventos()
        {
            try
            {
                return subeventoDatos.HaySubeventos();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Subevento RecuperarPorNombre(string nombresubevento)
        {
            try
            {
                return subeventoDatos.RecuperarPorNombre(nombresubevento);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public List<Subevento> RecuperarTodos()
        {
            try
            {
                return subeventoDatos.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
