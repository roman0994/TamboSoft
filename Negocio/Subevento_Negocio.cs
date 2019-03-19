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
        Subevento_Datos subeventoDatos = new Subevento_Datos();

        public bool HaySubeventos()
        {
            return subeventoDatos.HaySubeventos();
        }
    }
}
