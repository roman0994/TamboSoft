using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Tambo_Negocio
    {
        Tambo_Datos tamboDatos = new Tambo_Datos();

        public List<Tambo> RecuperarTodos()
        {
            return tamboDatos.RecuperarTodos();
        }

        public List<Tambo> RecuperarOtrosTambos(int id_tambo)
        {
            return tamboDatos.RecuperarOtrosTambos(id_tambo);
        }

        public Tambo RecuperarUno(int id)
        {
            return tamboDatos.RecuperarUno(id);
        }

        public Tambo RecuperarPorNombre(string nombre_tambo)
        {
            return tamboDatos.RecuperarPorNombre(nombre_tambo);
        }

        public void Actualizar(Tambo tambo)
        {
            tamboDatos.Actualizar(tambo);
        }

        public void Insertar(Tambo tambo)
        {
            tamboDatos.Insertar(tambo);
        }

        public void Eliminar(int id)
        {
            tamboDatos.Eliminar(id);
        }
    }
}
