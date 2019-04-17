using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int _id_usuario;
        private string _usu;
        private string _password;
        private string _email;

        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public string Usu { get => _usu; set => _usu = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }

        public Usuario()
        {

        }

        public Usuario(int id, string usu, string pass, string email)
        {
            Id_usuario = id;
            Usu = usu;
            Password = pass;
            Email = email;
        }
    }
}
