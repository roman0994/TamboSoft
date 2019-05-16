using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
    public class Inseminador_Negocio
    {
        Inseminador_Datos inseminadorDatos = new Inseminador_Datos();

        public List<Inseminador> RecuperarTodos()
        {
            try
            {
                return inseminadorDatos.RecuperarTodos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Inseminador> RecuperarPorTambo(int idtambo)
        {
            try
            {
                return inseminadorDatos.RecuperarPorTambo(idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Inseminador RecuperarUno(int id)
        {
            try
            {
                return inseminadorDatos.RecuperarUno(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Actualizar(Inseminador inseminador)
        {
            try
            {
                inseminadorDatos.Actualizar(inseminador);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insertar(Inseminador inseminador, Tambo_Inseminador tamboInseminador)
        {
            try
            {
                inseminadorDatos.Insertar(inseminador, tamboInseminador);
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
                return inseminadorDatos.FiltrarPorNombre(texto,idtambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
