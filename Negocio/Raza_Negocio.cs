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
            try
            {
                return razaDatos.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Raza RecuperarUno(int id)
        {
            try
            {
                return razaDatos.RecuperarUno(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayRazas()
        {
            try
            {
                return razaDatos.HayRazas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
