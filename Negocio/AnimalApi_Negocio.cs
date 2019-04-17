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
        public AnimalApi_Negocio()
        {

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
                if (!listadoBase.Exists(a=> a.Rp == item.Rp))
                {
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
                if (listadoBase.Exists(a => a.Rp == item.Rp && a.Caravana == item.Caravana))
                {
                    if (listadoBase.Exists(a => a.FechaNacimiento != item.FechaNacimiento || a.Edad != item.Edad || a.NombreAnimal != item.NombreAnimal || a.EstadoAnimal != item.EstadoAnimal || a.Hba != item.Hba || a.Categoria != item.Categoria || a.RpMadre != item.RpMadre || a.RpPadre != item.RpPadre || a.HbaMadre != item.HbaMadre || a.HbaPadre != item.HbaPadre || a.IdTambo != item.IdTambo || a.IdRaza != item.IdRaza || a.Habilitado != item.Habilitado))
                    {
                        listadoModificados.Add(item);
                    }
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
