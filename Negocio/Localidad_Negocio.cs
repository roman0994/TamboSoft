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
            return localidadDatos.RecuperarPorProvincia(id_provincia);
        }

        public Localidad RecuperarUno(int id)
        {
            return localidadDatos.RecuperarUno(id);
        }

        public bool HayLocalidades()
        {
            return localidadDatos.HayLocalidades();
        }
    }
}
