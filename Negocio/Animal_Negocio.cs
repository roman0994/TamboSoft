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

        public List<Animal> RecuperarVacasServidasPorTambo(int id_tambo)
        {
            return animalDatos.RecuperarVacasServidasPorTambo(id_tambo);
        }

        public List<Animal> RecuperarVacasEnCeloPorTambo(int id_tambo)
        {
            return animalDatos.RecuperarVacasEnCeloPorTambo(id_tambo);
        }

        public List<Animal> RecuperarVacasConPartoPorTambo(int id_tambo)
        {
            return animalDatos.RecuperarVacasConPartoPorTambo(id_tambo);
        }

        public List<Animal> RecuperarAnimalesEnfermosPorTambo(int id_tambo)
        {
            return animalDatos.RecuperarAnimalesEnfermosPorTambo(id_tambo);
        }

        public int CantidadCriasMacho(int id_tambo)
        {
            return animalDatos.CantidadCriasMacho(id_tambo);
        }

        public int CantidadCriasHembra(int id_tambo)
        {
            return animalDatos.CantidadCriasHembra(id_tambo);
        }

        public int CantidadCriasMuertas(int id_tambo)
        {
            return animalDatos.CantidadCriasMuertas(id_tambo);
        }

        public int CantidadCriasMachoPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            return animalDatos.CantidadCriasMachoPorFecha(id_tambo, fechaDesde, fechaHasta);
        }

        public int CantidadCriasHembraPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            return animalDatos.CantidadCriasHembraPorFecha(id_tambo, fechaDesde, fechaHasta);
        }

        public int CantidadCriasMuertasPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            return animalDatos.CantidadCriasMuertasPorFecha(id_tambo, fechaDesde, fechaHasta);
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

        public void ActualizarEstadoMuerto(string estado, int rp)
        {
            animalDatos.ActualizarEstadoMuerto(estado, rp);
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

        public DataTable FiltrarPorAnimalesEnCeloPorTambo(int id_tambo)
        {
            return animalDatos.FiltrarPorAnimalesEnCeloPorTambo(id_tambo);
        }

        public DataTable FiltrarPorAnimalesEnfermosPorTambo(int id_tambo)
        {
            return animalDatos.FiltrarPorAnimalesEnfermosPorTambo(id_tambo);
        }
    }
}
