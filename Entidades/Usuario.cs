using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {

        public int Id_usuario { get; set; }
        public string Usu { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public List<Tambo> Tambos { get; set; }

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
