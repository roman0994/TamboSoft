using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class Desc_Subevento_Negocio
    {
        Desc_Subevento_Datos descSubeventoDatos = new Desc_Subevento_Datos();

        public List<Desc_Subevento> RecuperarPorSubevento (int id_subevento)
        {
            try
            {
                return descSubeventoDatos.RecuperarPorSubevento(id_subevento);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public Desc_Subevento RecuperarPorNombre(string nombre)
        {
            try
            {
                return descSubeventoDatos.RecuperarPorNombre(nombre);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }


        public List<Subevento> RecuperarTodos(List<Subevento> listadosubeventos)
        {
            List<Desc_Subevento> listanueva = new List<Desc_Subevento>();

            try
            {
                listanueva = descSubeventoDatos.RecuperarTodos();
                foreach (var item in listadosubeventos)
                {
                    item.Descripciones_Subeventos = new List<Desc_Subevento>();
                    item.Descripciones_Subeventos = listanueva.Where(x => x.Id_subevento == item.Id_subevento).ToList();

                }
                return listadosubeventos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
            
        }

        public Desc_Subevento RecuperarUno(int id)
        {
            try
            {
                return descSubeventoDatos.RecuperarUno(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public bool HayDescripciones()
        {
            try
            {
                return descSubeventoDatos.HayDescripciones();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
