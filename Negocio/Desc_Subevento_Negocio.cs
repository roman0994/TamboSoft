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
            return descSubeventoDatos.RecuperarPorSubevento(id_subevento);
        }

        public Desc_Subevento RecuperarUno(int id)
        {
            return descSubeventoDatos.RecuperarUno(id);
        }
    }
}
