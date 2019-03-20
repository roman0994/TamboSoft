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


            int idtambo;

            CargarTablas cargarTablas = new CargarTablas();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            if (tamboNegocio.HayTambos())
            {
                cargarTablas.CargaTablasData();
                Application.Run(new Login());
            }
            else
            {
                cargarTablas.CargaTablasData();
                Application.Run(new LoginAltaTambos());
            }
        }
    }
}
