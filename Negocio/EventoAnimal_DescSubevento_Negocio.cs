﻿using System;
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
            return eventoAnimal_DescSubevento.RecuperarTodos();
        }

        public List<EventoAnimal_DescSubevento> RecuperarPorTambo(int id_tambo)
        {
            return eventoAnimal_DescSubevento.RecuperarPorTambo(id_tambo);
        }

        public void Insertar(List<EventoAnimal_DescSubevento> listaEventoAnimal)
        {
            eventoAnimal_DescSubevento.Insertar(listaEventoAnimal);
        }

        public void Actualizar(EventoAnimal_DescSubevento evento)
        {
            eventoAnimal_DescSubevento.Actualizar(evento);
        }

        public void Eliminar(bool estado_evento, int id_desc_evento)
        {
            eventoAnimal_DescSubevento.Eliminar(estado_evento,id_desc_evento);
        }

        public DataTable FiltrarPorNombreAnimal(string texto, int idtambo)
        {
            return eventoAnimal_DescSubevento.FiltrarPorNombreAnimal(texto, idtambo);
        }

        public DataTable FiltrarPorNombreEvento(string texto, int idtambo)
        {
            return eventoAnimal_DescSubevento.FiltrarPorNombreEvento(texto, idtambo);
        }

        public DataTable FiltrarPorNombreSubevento(string texto, int idtambo)
        {
            return eventoAnimal_DescSubevento.FiltrarPorNombreSubevento(texto, idtambo);
        }

        public DataTable FiltrarPorRP(int rp)
        {
            return eventoAnimal_DescSubevento.FiltrarPorRP(rp);
        }

        public DataTable FiltrarPorNombreInseminador(string texto)
        {
            return eventoAnimal_DescSubevento.FiltrarPorNombreInseminador(texto);
        }

        public DataTable FiltrarPorNombreTambo(string texto)
        {
            return eventoAnimal_DescSubevento.FiltrarPorNombreTambo(texto);
        }
    }
}
