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
    public class Tambo_Negocio
    {
        Tambo_Datos tamboDatos = new Tambo_Datos();

        public List<Tambo> RecuperarTodos(int id_usuario)
        {
            try
            {
                return tamboDatos.RecuperarTodos(id_usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Tambo> RecuperarOtrosTambos(int id_tambo, int id_usuario)
        {
            try
            {
                return tamboDatos.RecuperarOtrosTambos(id_tambo,id_usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Tambo RecuperarUno(int id)
        {
            try
            {
                return tamboDatos.RecuperarUno(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Tambo RecuperarPorNombre(string nombre_tambo)
        {
            try
            {
                return tamboDatos.RecuperarPorNombre(nombre_tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayTambos(int id_usuario)
        {
            try
            {
                return tamboDatos.HayTambos(id_usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayOtrosTambos(int id_tambo, int id_usuario)
        {
            try
            {
                return tamboDatos.HayOtrosTambos(id_tambo, id_usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Actualizar(Tambo tambo)
        {
            try
            {
                tamboDatos.Actualizar(tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insertar(Tambo tambo)
        {
            try
            {
                tamboDatos.Insertar(tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int InsertarDevolviendoID(Tambo tambo)
        {
            try
            {
                return tamboDatos.InsertarDevolviendoID(tambo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                tamboDatos.Eliminar(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable FiltrarPorNombre(string texto, int idtambo, int id_usuario)
        {
            try
            {
                return tamboDatos.FiltrarPorNombre(texto, idtambo, id_usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
