using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class Control_Animal_Negocio
    {
        Control_Animal_Datos controlAnimalDatos = new Control_Animal_Datos();

        public List<Control_Animal> RecuperarTodos()
        {
            try
            {
                return controlAnimalDatos.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Control_Animal> RecuperarPorTambo(int id_tambo)
        {
            try
            {
                return controlAnimalDatos.RecuperarPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Control_Animal> RecuperarPorTamboYAnimal(int id_tambo, int rp)
        {
            try
            {
                return controlAnimalDatos.RecuperarPorTamboYAnimal(id_tambo, rp);
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
                return controlAnimalDatos.RecuperarDTPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RecuperarDTPorTamboYAnimal(int id_tambo, int rp)
        {
            try
            {
                return controlAnimalDatos.RecuperarDTPorTamboYAnimal(id_tambo, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Control_Animal> RecuperarPorTamboPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return controlAnimalDatos.RecuperarPorTamboPorFecha(id_tambo, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insertar(Control_Animal control)
        {
            try
            {
                controlAnimalDatos.Insertar(control);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Actualizar(Control_Animal controlAnimal)
        {
            try
            {
                controlAnimalDatos.Actualizar(controlAnimal);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(DateTime fecha_control, int id_control, int rp)
        {
            try
            {
                controlAnimalDatos.Eliminar(fecha_control, id_control, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ProduccionPorFecha(int id_tambo)
        {
            try
            {
                return controlAnimalDatos.ProduccionPorFecha(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ProduccionPorFiltroDia(int id_tambo, DateTime fecha)
        {
            try
            {
                return controlAnimalDatos.ProduccionPorFiltroDia(id_tambo, fecha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ProduccionPorFiltroDiaYAnimal(int id_tambo, DateTime fecha, int rp)
        {
            try
            {
                return controlAnimalDatos.ProduccionPorFiltroDiaYAnimal(id_tambo, fecha, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
        public DataTable ProduccionPorFiltroMes(int id_tambo, int mes, int año)
        {
            try
            {
                return controlAnimalDatos.ProduccionPorFiltroMes(id_tambo, mes, año);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ProduccionPorFiltroMesYAnimal(int id_tambo, int mes, int año, int rp)
        {
            try
            {
                return controlAnimalDatos.ProduccionPorFiltroMesYAnimal(id_tambo, mes, año, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ProduccionPorAnimal(int id_tambo)
        {
            try
            {
                return controlAnimalDatos.ProduccionPorAnimal(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ProduccionPorFiltroAnimal(int id_tambo, int rp)
        {
            try
            {
                return controlAnimalDatos.ProduccionPorFiltroAnimal(id_tambo, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorNombre(string texto,int idtambo)
        {
            try
            {
                return controlAnimalDatos.FiltrarPorNombre(texto,idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorCaravana(string caravana, int idtambo)
        {
            try
            {
                return controlAnimalDatos.FiltrarPorCaravana(caravana, idtambo);
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
                return controlAnimalDatos.FiltrarPorRP(rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorFechaControl (DateTime fechaControl)
        {
            try
            {
                return FiltrarPorFechaControl(fechaControl);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayControles(int id_tambo)
        {
            try
            {
                return controlAnimalDatos.HayControles(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayControlesMes(int mes, int anio, int id_tambo)
        {
            try
            {
                return controlAnimalDatos.HayControlesMes(mes, anio, id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public bool TieneControles(int rp)
        {
            try
            {
                return controlAnimalDatos.TieneControles(rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
