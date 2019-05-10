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
    public class Control_Animal_Negocio
    {
        Control_Animal_Datos controlAnimalDatos = new Control_Animal_Datos();

        public List<Control_Animal> RecuperarTodos()
        {
            return controlAnimalDatos.RecuperarTodos();
        }

        public List<Control_Animal> RecuperarPorTambo(int id_tambo)
        {
            return controlAnimalDatos.RecuperarPorTambo(id_tambo);
        }

        public List<Control_Animal> RecuperarPorTamboYAnimal(int id_tambo, int rp)
        {
            return controlAnimalDatos.RecuperarPorTamboYAnimal(id_tambo,rp);
        }

        public DataTable RecuperarDTPorTambo(int id_tambo)
        {
            return controlAnimalDatos.RecuperarDTPorTambo(id_tambo);
        }

        public DataTable RecuperarDTPorTamboYAnimal(int id_tambo, int rp)
        {
            return controlAnimalDatos.RecuperarDTPorTamboYAnimal(id_tambo, rp);
        }

        public List<Control_Animal> RecuperarPorTamboPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            return controlAnimalDatos.RecuperarPorTamboPorFecha(id_tambo,fechaDesde,fechaHasta);
        }

        public void Insertar (Control_Animal control)
        {
            controlAnimalDatos.Insertar(control);
        }

        public void Actualizar (Control_Animal controlAnimal)
        {
            controlAnimalDatos.Actualizar(controlAnimal);
        }

        public void Eliminar (DateTime fecha_control,int id_control,int rp)
        {
            controlAnimalDatos.Eliminar(fecha_control,id_control,rp);
        }

        public DataTable ProduccionPorFecha(int id_tambo)
        {
            return controlAnimalDatos.ProduccionPorFecha(id_tambo);
        }

        public DataTable ProduccionPorFiltroDia(int id_tambo, DateTime fecha)
        {
            return controlAnimalDatos.ProduccionPorFiltroDia(id_tambo,fecha);
        }

        public DataTable ProduccionPorFiltroDiaYAnimal(int id_tambo, DateTime fecha,int rp)
        {
            return controlAnimalDatos.ProduccionPorFiltroDiaYAnimal(id_tambo, fecha,rp);
        }

        public DataTable ProduccionPorFiltroMes(int id_tambo, int mes, int año)
        {
            return controlAnimalDatos.ProduccionPorFiltroMes(id_tambo, mes, año);
        }

        public DataTable ProduccionPorFiltroMesYAnimal(int id_tambo, int mes, int año, int rp)
        {
            return controlAnimalDatos.ProduccionPorFiltroMesYAnimal(id_tambo, mes, año, rp);
        }

        public DataTable ProduccionPorAnimal(int id_tambo)
        {
            return controlAnimalDatos.ProduccionPorAnimal(id_tambo);
        }

        public DataTable ProduccionPorFiltroAnimal(int id_tambo, int rp)
        {
            return controlAnimalDatos.ProduccionPorFiltroAnimal(id_tambo, rp);
        }

        public DataTable FiltrarPorNombre(string texto,int idtambo)
        {
            return controlAnimalDatos.FiltrarPorNombre(texto,idtambo);
        }

        public DataTable FiltrarPorCaravana(string caravana, int idtambo)
        {
            return controlAnimalDatos.FiltrarPorCaravana(caravana, idtambo);
        }

        public DataTable FiltrarPorRP(int rp)
        {
            return controlAnimalDatos.FiltrarPorRP(rp);
        }

        public DataTable FiltrarPorFechaControl (DateTime fechaControl)
        {
            return FiltrarPorFechaControl(fechaControl);
        }

        public bool HayControles(int id_tambo)
        {
            return controlAnimalDatos.HayControles(id_tambo);
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
            return controlAnimalDatos.TieneControles(rp);
        }
    }
}
