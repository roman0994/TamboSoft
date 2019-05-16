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
        Raza_Datos razadatos;
        public AnimalApi_Negocio()
        {
            razadatos = new Raza_Datos();
        }


        public List<AnimalApi> RecuperarTodos()
        {
            return animalDatos.RecuperarTodos();
        }

        public List<AnimalApi> RecuperarPorTambo(int id_tambo)
        {
            return animalDatos.RecuperarPorTambo(id_tambo);
        }

        public List<AnimalApi> Comparar_ApiBase(List<AnimalApi> listado,int idtambo)
        {
            List<AnimalApi> listadoBase = animalDatos.RecuperarPorTambo(idtambo);
            List<AnimalApi> listadoInexistentes = new List<AnimalApi>();
            
            foreach (var item in listado)
            {
                if (!listadoBase.Exists(a => a.Rp == item.Rp))
                {
                    
                    var raza = razadatos.RecuperarUno(Convert.ToInt32( item.IdRaza));
                    
                    listadoInexistentes.Add(item);
                }
            }
            return listadoInexistentes;
        }

        public void Insertar(AnimalApi animal)
        {
            animalDatos.Insertar(animal);
        }

        public List<AnimalApi> CompararModif_ApiBase(List<AnimalApi> listado, int idtambo)
        {
            List<AnimalApi> listadoBase = animalDatos.RecuperarPorTambo(idtambo);
            List<AnimalApi> listadoModificados = new List<AnimalApi>();
            foreach (var item in listado)
            {
                if (listadoBase.Exists(a => a.Rp == item.Rp && a.Caravana == item.Caravana && (a.FechaNacimiento != item.FechaNacimiento || a.NombreAnimal != item.NombreAnimal || a.EstadoAnimal != item.EstadoAnimal)))
                {
                    //if (listadoBase.Exists(a => a.FechaNacimiento != item.FechaNacimiento ||  a.NombreAnimal != item.NombreAnimal || a.EstadoAnimal != item.EstadoAnimal  || a.Categoria != item.Categoria ))
                    //{
                        listadoModificados.Add(item);
                    //}
                }
            }
            return listadoModificados;
        }

        public void Actualizar(AnimalApi animal)
        {
            animalDatos.Actualizar(animal);
        }
    }
}
