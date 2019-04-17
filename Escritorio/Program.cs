using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Escritorio
{
    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           

            Usuario_Negocio usuarioNegocio = new Usuario_Negocio();

            if (usuarioNegocio.HayUsuarios())
            {
                Application.Run(new LoginUsuario());
            }
        }
    }
}
