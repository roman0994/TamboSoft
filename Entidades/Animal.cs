using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Animal
    {
        private int _rp;
        private DateTime _fecha_nacimiento;
        private int _edad;
        private string _foto;
        private string _nombre_animal;
        private string _estado_animal;
        private int _hba;
        private string _categoria;
        private string _sexo;
        private int _rp_madre;
        private int _rp_padre;
        private int _hba_padre;
        private int _hba_madre;
        private int _id_tambo;
        private string _nombre_tambo;
        private int _id_raza;
        private string _nombre_raza;
        private bool _habilitado;


        public int Rp
        {
            get { return _rp; }
            set { _rp = value; }
        }

        public DateTime Fecha_nacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public string Nombre_animal
        {
            get { return _nombre_animal; }
            set { _nombre_animal = value; }
        }

        public string Estado_animal
        {
            get { return _estado_animal; }
            set { _estado_animal = value; }
        }

        public int Hba
        {
            get { return _hba; }
            set { _hba = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public int Rp_madre
        {
            get { return _rp_madre; }
            set { _rp_madre = value; }
        }

        public int Rp_padre
        {
            get { return _rp_padre; }
            set { _rp_padre = value; }
        }

        public int Hba_padre
        {
            get { return _hba_padre; }
            set { _hba_padre = value; }
        }

        public int Hba_madre
        {
            get { return _hba_madre; }
            set { _hba_madre = value; }
        }


        public int Id_tambo
        {
            get { return _id_tambo; }
            set { _id_tambo = value; }
        }

        public string Nombre_tambo
        {
            get { return _nombre_tambo; }
            set { _nombre_tambo = value; }
        }


        public int Id_raza
        {
            get { return _id_raza; }
            set { _id_raza = value; }
        }

        public string Nombre_raza
        {
            get { return _nombre_raza; }
            set { _nombre_raza = value; }
        }

        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public Animal()
        {

        }


        public Animal(int rp, DateTime fecha_nacimiento, int edad, string foto, string nombre_animal, string estado, int hba, string categoria, string sexo, int rp_madre, int rp_padre, int hba_padre, int hba_madre, int id_tambo, int id_raza,string nombre_raza,string nombre_tambo,bool habilitado)
        {
            Rp = rp;
            Fecha_nacimiento = fecha_nacimiento;
            Edad = edad;
            Foto = foto;
            Nombre_animal = nombre_animal;
            Estado_animal = estado;
            Hba = hba;
            Categoria = categoria;
            Sexo = sexo;
            Rp_madre = rp_madre;
            Rp_padre = rp_padre;
            Hba_padre = hba_padre;
            Hba_madre = hba_madre;
            Id_tambo = id_tambo;
            Id_raza = id_raza;
            Nombre_raza = nombre_raza;
            Nombre_tambo = nombre_tambo;
            Habilitado = habilitado;
        }
        public Animal(int rp, DateTime fecha_nacimiento, int edad, string foto, string nombre_animal, string estado, int hba, string categoria, string sexo, int rp_madre, int rp_padre, int hba_padre, int hba_madre, int id_tambo, int id_raza,bool habilitado)
        {
            Rp = rp;
            Fecha_nacimiento = fecha_nacimiento;
            Edad = edad;
            Foto = foto;
            Nombre_animal = nombre_animal;
            Estado_animal = estado;
            Hba = hba;
            Categoria = categoria;
            Sexo = sexo;
            Rp_madre = rp_madre;
            Rp_padre = rp_padre;
            Hba_padre = hba_padre;
            Hba_madre = hba_madre;
            Id_tambo = id_tambo;
            Id_raza = id_raza;
            Habilitado = habilitado;
        }
    }
}
