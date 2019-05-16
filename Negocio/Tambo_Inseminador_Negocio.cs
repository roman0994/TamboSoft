using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class Tambo_Inseminador_Negocio
    {
        Tambo_Inseminador_Datos tamboInseminadorDatos = new Tambo_Inseminador_Datos();

        public List<Tambo_Inseminador> RecuperarTodos()
        {
            try
            {
                return tamboInseminadorDatos.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Tambo_Inseminador> RecuperarPorTambo(int id_tambo)
        {
            try
            {
                return tamboInseminadorDatos.RecuperarPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Tambo_Inseminador RecuperarUno(int id_tambo, int id_ins)
        {
            try
            {
                return tamboInseminadorDatos.RecuperarUno(id_tambo,id_ins);
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
                return tamboInseminadorDatos.RecuperarDTPorTambo(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int id_inseminador)
        {
            try
            {
                tamboInseminadorDatos.Eliminar(id_inseminador);
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
                return tamboInseminadorDatos.FiltrarPorNombre(texto, idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayInseminadores(int id_tambo)
        {
            try
            {
                return tamboInseminadorDatos.HayInseminadores(id_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
