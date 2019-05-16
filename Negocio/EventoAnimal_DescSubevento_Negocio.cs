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
    public class EventoAnimal_DescSubevento_Negocio
    {
        EventoAnimal_DescSubevento_Datos eventoAnimal_DescSubevento = new EventoAnimal_DescSubevento_Datos();

        public List<EventoAnimal_DescSubevento> RecuperarTodos()
        {
            try
            {
                return eventoAnimal_DescSubevento.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarPorTambo(int id_tambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.RecuperarPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarPorTamboYAnimal(int id_tambo, int rp)
        {
            try
            {
                return eventoAnimal_DescSubevento.RecuperarPorTamboYAnimal(id_tambo, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarSoloEventosPorTambo(int id_tambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.RecuperarSoloEventosPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarDescripcionesPorEvento(int id_tambo, int rp, int id_evento, DateTime fecha)
        {
            try
            {
                return eventoAnimal_DescSubevento.RecuperarDescripcionesPorEvento(id_tambo, rp, id_evento, fecha);
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
                return eventoAnimal_DescSubevento.RecuperarDTPorTambo(id_tambo);
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
                return eventoAnimal_DescSubevento.RecuperarDTPorTamboYAnimal(id_tambo, rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ReporteReproduccion(int id_tambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.ReporteReproduccion(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarPartosPorTambo(int id_tambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.RecuperarPartosPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarPartosPorTamboPorFecha(int idtambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return eventoAnimal_DescSubevento.RecuperarPartosPorTamboPorFecha(idtambo,fechaDesde,fechaHasta);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insertar(List<EventoAnimal_DescSubevento> listaEventoAnimal)
        {
            try
            {
                eventoAnimal_DescSubevento.Insertar(listaEventoAnimal);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Actualizar(EventoAnimal_DescSubevento evento)
        {
            try
            {
                eventoAnimal_DescSubevento.Actualizar(evento);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(bool estado_evento, int id_evento, int rp, DateTime fecha_desc)
        {
            try
            {
                eventoAnimal_DescSubevento.Eliminar(estado_evento,id_evento,rp,fecha_desc);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorNombreAnimal(string texto, int idtambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.FiltrarPorNombreAnimal(texto, idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorNombreEvento(string texto, int idtambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.FiltrarPorNombreEvento(texto, idtambo);
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
                return eventoAnimal_DescSubevento.FiltrarPorCaravana(texto, idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorNombreSubevento(string texto, int idtambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.FiltrarPorNombreSubevento(texto, idtambo);
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
                return eventoAnimal_DescSubevento.FiltrarPorRP(rp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorNombreInseminador(string texto)
        {
            try
            {
                return eventoAnimal_DescSubevento.FiltrarPorNombreInseminador(texto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorNombreTambo(string texto)
        {
            try
            {
                return eventoAnimal_DescSubevento.FiltrarPorNombreTambo(texto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayEventos(int id_tambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.HayEventos(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayPartos(DateTime fechaDesde, DateTime fechaHasta, int id_tambo)
        {
            try
            {
                return eventoAnimal_DescSubevento.HayPartos(fechaDesde,fechaHasta,id_tambo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
