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
            try
            {
                return animalDatos.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Animal> RecuperarPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Animal> RecuperarParaReportePorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarParaReportePorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RecuperarPorTamboDT(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarPorTamboDT(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RecuperarVacasPorTamboDT(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarVacasPorTamboDT(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Animal> RecuperarVacasPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarVacasPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RecuperarDTPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarDTPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Animal RecuperarUno(int rp)
        {
            try
            {
                return animalDatos.RecuperarUno(rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Animal RecuperarUnoPorCaravana(string caravana,int idtambo)
        {
            try
            {
                return animalDatos.RecuperarUnoPorCaravana(caravana,idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Animal> RecuperarVacasServidasPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarVacasServidasPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RecuperarDTVacasServidasPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarDTVacasServidasPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Animal> RecuperarVacasEnCeloPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarVacasEnCeloPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RecuperarDTVacasEnCeloPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarDTVacasEnCeloPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Animal> RecuperarVacasConPartoPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarVacasConPartoPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RecuperarDTVacasConPartoPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarDTVacasConPartoPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Animal> RecuperarAnimalesEnfermosPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarAnimalesEnfermosPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RecuperarDTAnimalesEnfermosPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.RecuperarDTAnimalesEnfermosPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CantidadCriasMacho(int id_tambo)
        {
            try
            {
                return animalDatos.CantidadCriasMacho(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CantidadCriasHembra(int id_tambo)
        {
            try
            {
                return animalDatos.CantidadCriasHembra(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CantidadCriasMuertas(int id_tambo)
        {
            try
            {
                return animalDatos.CantidadCriasMuertas(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CantidadCriasMachoPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return animalDatos.CantidadCriasMachoPorFecha(id_tambo, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CantidadCriasHembraPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return animalDatos.CantidadCriasHembraPorFecha(id_tambo, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CantidadCriasMuertasPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return animalDatos.CantidadCriasMuertasPorFecha(id_tambo, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insertar(Animal animal)
        {
            try
            {
                animalDatos.Insertar(animal);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Actualizar(Animal animal)
        {
            try
            {
                animalDatos.Actualizar(animal);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarEstado(string estado, int rp)
        {
            try
            {
                animalDatos.ActualizarEstado(estado,rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarEstadoMuerto(string estado, int rp)
        {
            try
            {
                animalDatos.ActualizarEstadoMuerto(estado, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarEstadoVendido(string estado, int rp)
        {
            try
            {
                animalDatos.ActualizarEstadoVendido(estado, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int rp)
        {
            try
            {
                animalDatos.Eliminar(rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Animal RecuperarPorRP(int rp)
        {
            try
            {
                return animalDatos.RecuperarPorRP(rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Animal RecuperarPorNombre(string nombre)
        {
            try
            {
                return animalDatos.RecuperarPorNombre(nombre);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorNombre(string texto, int idtambo)
        {
            try
            {
                return animalDatos.FiltrarPorNombre(texto,idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorRP(int rp)
        {
            try
            {
                return animalDatos.FiltrarPorRP(rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorEstado(string texto,int idtambo)
        {
            try
            {
                return animalDatos.FiltrarPorEstado(texto,idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorCaravana(string texto, int idtambo)
        {
            try
            {
                return animalDatos.FiltrarPorCaravana(texto, idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorAnimalesEnCeloPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.FiltrarPorAnimalesEnCeloPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorAnimalesEnfermosPorTambo(int id_tambo)
        {
            try
            {
                return animalDatos.FiltrarPorAnimalesEnfermosPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayVacas(int id_tambo)
        {
            try
            {
                return animalDatos.HayVacas(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayAnimales(int id_tambo)
        {
            try
            {
                return animalDatos.HayAnimales(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ExisteLaCaravana(int id_tambo,string caravana)
        {
            try
            {
                return animalDatos.ExisteLaCaravana(id_tambo,caravana);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public int ObtenerUltimaCaravana(int id_tambo)
        {
            try
            {
                return animalDatos.ObtenerUltimaCaravana(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
