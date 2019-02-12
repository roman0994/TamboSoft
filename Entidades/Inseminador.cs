using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inseminador
    {
        private int _id_inseminador;
        private string _nombre_inseminador;
        private bool _estado_inseminador;
        private string _telefono;
        private string _direccion;
        private string _dni;
        private int _id_localidad;
        private string _nombre_localidad;

        public int Id_inseminador { get => _id_inseminador; set => _id_inseminador = value; }
        public string Nombre_inseminador { get => _nombre_inseminador; set => _nombre_inseminador = value; }
        public bool Estado_inseminador { get => _estado_inseminador; set => _estado_inseminador = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public int Id_localidad { get => _id_localidad; set => _id_localidad = value; }
        public string Nombre_localidad { get => _nombre_localidad; set => _nombre_localidad = value; }

        public Inseminador()
        {

        }

        public Inseminador(int id, string nombre, bool estado, string telefono, string direccion, string dni, int id_localidad, string nombre_localidad)
        {
            this.Id_inseminador = id;
            this.Nombre_inseminador = nombre;
            this.Estado_inseminador = estado;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Dni = dni;
            this.Id_localidad = id_localidad;
            this.Nombre_localidad = nombre_localidad;
        }
    }
}
