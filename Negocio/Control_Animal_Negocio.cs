using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class Control_Animal_Negocio
    {
        Control_Animal_Datos controlAnimalDatos = new Control_Animal_Datos();

        public List<Control_Animal> RecuperarTodos()
        {
            return controlAnimalDatos.RecuperarTodos();
        }

        public List<Control_Animal> RecuperarPorTambo(int id_tambo)
        {
            return controlAnimalDatos.RecuperarPorTambo(id_tambo);
        }

        public List<Control_Animal> RecuperarPorTamboPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            return controlAnimalDatos.RecuperarPorTamboPorFecha(id_tambo,fechaDesde,fechaHasta);
        }

        public void Insertar (Control_Animal control)
        {
            controlAnimalDatos.Insertar(control);
        }

        public void Actualizar (Control_Animal controlAnimal)
        {
            controlAnimalDatos.Actualizar(controlAnimal);
        }

        public void Eliminar (DateTime fecha_control,int id_control,int rp)
        {
            controlAnimalDatos.Eliminar(fecha_control,id_control,rp);
        }

        public DataTable ProduccionPorDia(int id_tambo, DateTime fecha)
        {
            return controlAnimalDatos.ProduccionPorDia(id_tambo,fecha);
        }

        public DataTable FiltrarPorNombre(string texto)
        {
            return controlAnimalDatos.FiltrarPorNombre(texto);
        }

        public DataTable FiltrarPorRP(int rp)
        {
            return controlAnimalDatos.FiltrarPorRP(rp);
        }

        public DataTable FiltrarPorFechaControl (DateTime fechaControl)
        {
            return FiltrarPorFechaControl(fechaControl);
        }
    }
}
