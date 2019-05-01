using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int Id_Categoria { get; set; }
        public string Descripcion { get; set; }

        public List<Animal> Animales { get; set; }
        public List<Evento> Eventos { get; set; }

    }
}
