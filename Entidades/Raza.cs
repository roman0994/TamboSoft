using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Raza
    {
        int _id_raza;
        string _nombre_raza;
        bool _estado_raza;



        public int Id_raza { get => _id_raza; set => _id_raza = value; }
        public string Nombre_raza { get => _nombre_raza; set => _nombre_raza = value; }
        public bool Estado_raza { get => _estado_raza; set => _estado_raza = value; }

        public Raza()
        {

        }

        public Raza(int id_raza, string nombre_raza, bool estado_raza)
        {
            Id_raza = id_raza;
            Nombre_raza = nombre_raza;
            Estado_raza = estado_raza;
        }
    }
}
