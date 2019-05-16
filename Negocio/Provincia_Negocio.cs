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
            try
            {
                return provinciaDatos.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Provincia RecuperarUno(int id)
        {
            try
            {
                return provinciaDatos.RecuperarUno(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayProvincias()
        {
            try
            {
                return provinciaDatos.HayProvincias();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
