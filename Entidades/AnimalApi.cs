using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AnimalApi
    {
        public int Rp { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        //public int? Edad { get; set; }
        public string Foto { get; set; }
        public string NombreAnimal { get; set; }
        public string EstadoAnimal { get; set; }
        public int? Hba { get; set; }
        public string Categoria { get; set; }
        public int? RpMadre { get; set; }
        public int? RpPadre { get; set; }
        public int? HbaMadre { get; set; }
        public int? HbaPadre { get; set; }
        public int? IdTambo { get; set; }
        public int? IdRaza { get; set; }
        public bool? Habilitado { get; set; }
        public string Caravana { get; set; }
    }
}
