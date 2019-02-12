using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Desc_Subevento
    {
        private int _id_desc;
        private string _descripcion;
        private string _abreviacion;
        private bool _estado_desc;
        private int _id_subevento;
        private string _nombre_subevento;

        public int Id_desc { get => _id_desc; set => _id_desc = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Abreviacion { get => _abreviacion; set => _abreviacion = value; }
        public bool Estado_desc { get => _estado_desc; set => _estado_desc = value; }
        public int Id_subevento { get => _id_subevento; set => _id_subevento = value; }
        public string Nombre_subevento { get => _nombre_subevento; set => _nombre_subevento = value; }

        public Desc_Subevento()
        {

        }

        public Desc_Subevento(int id, string desc, string abreviacion, bool estado_desc, int id_subevento, string nombre_subevento)
        {
            this.Id_desc = id;
            this.Descripcion = desc;
            this.Abreviacion = abreviacion;
            this.Estado_desc = estado_desc;
            this.Id_subevento = id_subevento;
            this.Nombre_subevento = nombre_subevento;
        }
    }
}
