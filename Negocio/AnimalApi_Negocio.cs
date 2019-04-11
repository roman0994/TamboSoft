using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AnimalApi_Negocio
    {
        AnimalApi_Datos animalDatos = new AnimalApi_Datos();

        public List<AnimalApi> RecuperarTodos()
        {
            return animalDatos.RecuperarTodos();
        }

        public List<AnimalApi> RecuperarPorTambo(int id_tambo)
        {
            return animalDatos.RecuperarPorTambo(id_tambo);
        }
    }
}
