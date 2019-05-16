using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Localidad_Negocio
    {
        Localidad_Datos localidadDatos = new Localidad_Datos();

        public List<Localidad> RecuperarPorProvincia(int id_provincia)
        {
            try
            {
                return localidadDatos.RecuperarPorProvincia(id_provincia);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Localidad RecuperarUno(int id)
        {
            try
            {
                return localidadDatos.RecuperarUno(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayLocalidades()
        {
            try
            {
                return localidadDatos.HayLocalidades();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
