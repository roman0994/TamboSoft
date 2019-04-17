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
            return tamboDatos.RecuperarTodos(id_usuario);
        }

        public List<Tambo> RecuperarOtrosTambos(int id_tambo, int id_usuario)
        {
            return tamboDatos.RecuperarOtrosTambos(id_tambo,id_usuario);
        }

        public Tambo RecuperarUno(int id)
        {
            return tamboDatos.RecuperarUno(id);
        }

        public Tambo RecuperarPorNombre(string nombre_tambo)
        {
            return tamboDatos.RecuperarPorNombre(nombre_tambo);
        }

        public bool HayTambos(int id_usuario)
        {
            return tamboDatos.HayTambos(id_usuario);
        }

        public bool HayOtrosTambos(int id_tambo, int id_usuario)
        {
            return tamboDatos.HayOtrosTambos(id_tambo, id_usuario);
        }

        public void Actualizar(Tambo tambo)
        {
            tamboDatos.Actualizar(tambo);
        }

        public void Insertar(Tambo tambo)
        {
            tamboDatos.Insertar(tambo);
        }

        public int InsertarDevolviendoID(Tambo tambo)
        {
            return tamboDatos.InsertarDevolviendoID(tambo);
        }

        public void Eliminar(int id)
        {
            tamboDatos.Eliminar(id);
        }

        public DataTable FiltrarPorNombre(string texto, int idtambo, int id_usuario)
        {
            return tamboDatos.FiltrarPorNombre(texto, idtambo, id_usuario);
        }
    }
}
