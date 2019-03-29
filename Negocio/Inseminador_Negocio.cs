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
            return inseminadorDatos.RecuperarTodos();
        }

        public List<Inseminador> RecuperarPorTambo(int idtambo)
        {
            return inseminadorDatos.RecuperarPorTambo(idtambo);
        }

        public Inseminador RecuperarUno(int id)
        {
            return inseminadorDatos.RecuperarUno(id);
        }

        public void Actualizar(Inseminador inseminador)
        {
            inseminadorDatos.Actualizar(inseminador);
        }

        public void Insertar(Inseminador inseminador, Tambo_Inseminador tamboInseminador)
        {
            inseminadorDatos.Insertar(inseminador, tamboInseminador);
        }

        public DataTable FiltrarPorNombre(string texto,int idtambo)
        {
            return inseminadorDatos.FiltrarPorNombre(texto,idtambo);
        }
    }
}
