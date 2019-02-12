using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Subevento
    {
        private int _id_subevento;
        private string _nombre_subevento;
        private bool _estado_subevento;

        public int Id_subevento { get => _id_subevento; set => _id_subevento = value; }
        public string Nombre_subevento { get => _nombre_subevento; set => _nombre_subevento = value; }
        public bool Estado_subevento { get => _estado_subevento; set => _estado_subevento = value; }

        public Subevento()
        {

        }

        public Subevento(int id, string nombre, bool estado)
        {
            this.Id_subevento = id;
            this.Nombre_subevento = nombre;
            this.Estado_subevento = estado;
        }
    }
}
