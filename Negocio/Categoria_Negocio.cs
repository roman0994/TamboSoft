using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    
    public class Categoria_Negocio
    {
        Categoria_Datos categoriadatos;
        public Categoria_Negocio()
        {

            categoriadatos = new Categoria_Datos();
        }

        public List<Categoria> RecuperarTodos()
        {
            try
            {
                return categoriadatos.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }

        public Categoria RecuperarUno(int id)
        {

            try
            {
                return categoriadatos.RecuperarUno(id);
            }
            catch (Exception ex)
            {
                throw ex;
               
            }


        }
        


    }
}
