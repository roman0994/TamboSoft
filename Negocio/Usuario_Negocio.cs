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
            return usuarioDatos.ExisteUsuario(user,pass);
        }

        public bool HayUsuarios()
        {
            return usuarioDatos.HayUsuarios();
        }

        public void Insertar(Usuario usuario)
        {
            usuarioDatos.Insertar(usuario);
        }

        public string RecuperarContraseña(string email)
        {
            return usuarioDatos.RecuperarContraseña(email);
        }

        public bool YaExisteElUsuario(string usu)
        {
            return usuarioDatos.YaExisteElUsuario(usu);
        }

        public bool YaExisteElEmail(string email)
        {
            return usuarioDatos.YaExisteElEmail(email);
        }

        public Usuario RecuperarUno(string usu, string pass)
        {
            return usuarioDatos.RecuperarUno(usu,pass);
        }
    }
}
