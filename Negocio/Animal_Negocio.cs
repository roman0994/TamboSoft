using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace Negocio
{
    public class Animal_Negocio
    {
        Animal_Datos animalDatos = new Animal_Datos();

        public List<Animal> RecuperarTodos()
        {
            return animalDatos.RecuperarTodos();
        }

        public List<Animal> RecuperarPorTambo(int id_tambo)
        {
            return animalDatos.RecuperarPorTambo(id_tambo);
        }

        public Animal RecuperarUno(int rp)
        {
            return animalDatos.RecuperarUno(rp);
        }

        public void Insertar(Animal animal)
        {
            animalDatos.Insertar(animal);
        }

        public void Actualizar(Animal animal)
        {
            animalDatos.Actualizar(animal);
        }

        public void ActualizarEstado(string estado, int rp)
        {
            animalDatos.ActualizarEstado(estado,rp);
        }

        public void Eliminar(int rp)
        {
            animalDatos.Eliminar(rp);
        }

        public Animal RecuperarPorRP(int rp)
        {
            return animalDatos.RecuperarPorRP(rp);
        }

        public Animal RecuperarPorNombre(string nombre)
        {
            return animalDatos.RecuperarPorNombre(nombre);
        }

        public DataTable FiltrarPorNombre(string texto)
        {
            return animalDatos.FiltrarPorNombre(texto);
        }

        public DataTable FiltrarPorRP(int rp)
        {
            return animalDatos.FiltrarPorRP(rp);
        }

        public DataTable FiltrarPorEstado(string texto)
        {
            return animalDatos.FiltrarPorEstado(texto);
        }
    }
}
