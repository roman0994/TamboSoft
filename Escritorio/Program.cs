using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;
using Entidades;

namespace Escritorio
{
    static class Program
    {
        public static Usuario UsuarioSesion { get; set; }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           

            Usuario_Negocio usuarioNegocio = new Usuario_Negocio();
            UsuarioSesion = new Usuario();
            if (usuarioNegocio.HayUsuarios())
            {

                Application.Run(new LoginUsuario());
            }
        }
    }
}
