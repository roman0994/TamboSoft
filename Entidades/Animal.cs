using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Animal
    {
 
        public int Rp {get;set; }

        public DateTime Fecha_nacimiento { get; set; }
       

        public int Edad { get; set; }
        

        public string Foto { get; set; }
        

        public string Nombre_animal { get; set; }
      

        public string Estado_animal { get; set; }
        

        public int Hba { get; set; }
       

       
       

        public int Rp_madre { get; set; }
       

        public int Rp_padre { get; set; }
        

        public int Hba_padre { get; set; }
       

        public int Hba_madre { get; set; }
       


        public int Id_tambo { get; set; }
      

        public string Nombre_tambo { get; set; }
        


        public int Id_raza { get; set; }
       

        public string Nombre_raza { get; set; }
        

        public bool Habilitado { get; set; }
       

        public string  Caravana { get; set; }

        public int Id_Categoria { get; set; }

        public Raza Raza { get; set; }

        public Tambo Tambo { get; set; }


        public List<Control> Controles { get; set; }

        public List<Evento> Eventos { get; set; }
        
        public Categoria Categoria { get; set; }



        public Animal()
        {

        }

       

        
    }
}
