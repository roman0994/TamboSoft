using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Usuario_Negocio
    {
        Usuario_Datos usuarioDatos = new Usuario_Datos();

        public bool ExisteUsuario(string user, string pass)
        {
            try
            {
                return usuarioDatos.ExisteUsuario(user,pass);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool HayUsuarios()
        {
            try
            {
                return usuarioDatos.HayUsuarios();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insertar(Usuario usuario)
        {
            try
            {
                usuarioDatos.Insertar(usuario);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        public string RecuperarContraseña(string email)
        {
            try
            {
                return usuarioDatos.RecuperarContraseña(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool YaExisteElUsuario(string usu)
        {
            try
            {
                return usuarioDatos.YaExisteElUsuario(usu);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool YaExisteElEmail(string email)
        {
            try
            {
                return usuarioDatos.YaExisteElEmail(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Usuario RecuperarUno(string usu, string pass)
        {
            try
            {
                return usuarioDatos.RecuperarUno(usu,pass);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Usuario RecuperarPorID(int id)
        {
            try
            {
                return usuarioDatos.RecuperarPorID(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
