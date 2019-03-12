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
            return tamboInseminadorDatos.RecuperarTodos();
        }

        public List<Tambo_Inseminador> RecuperarPorTambo(int id_tambo)
        {
            return tamboInseminadorDatos.RecuperarPorTambo(id_tambo);
        }

        public DataTable RecuperarDTPorTambo(int id_tambo)
        {
            return tamboInseminadorDatos.RecuperarDTPorTambo(id_tambo);
        }

        public void Eliminar(int id_inseminador)
        {
            tamboInseminadorDatos.Eliminar(id_inseminador);
        }
    }
}
