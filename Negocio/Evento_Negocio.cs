using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Evento_Negocio
    {
        Evento_Datos eventoDatos = new Evento_Datos();
        Evento_Animal eventoanimal;
        EventoAnimal_DescSubevento ev_desc;
        Animal Animal;
        Evento Evento;
        EventoAnimal_Datos EventoAnimal_Datos;
        Animal_Datos Animal_Datos;
        EventoAnimal_DescSubevento_Datos ev_ds_Datos;

        public Evento_Negocio()
        {
           eventoDatos = new Evento_Datos();
             eventoanimal = new Evento_Animal();
            ev_desc = new EventoAnimal_DescSubevento();
            Animal = new Animal();
            Evento = new Evento();
            EventoAnimal_Datos = new EventoAnimal_Datos();
            Animal_Datos = new Animal_Datos();
            ev_ds_Datos = new EventoAnimal_DescSubevento_Datos();
        }



        public List<Evento> RecuperarTodos()
        {
            return eventoDatos.RecuperarTodos();
        }

        public List<Evento> RecuperarEventosParaToros()
        {
            return eventoDatos.RecuperarEventosParaToros();
        }

        public List<Evento> RecuperarPorCategoria(int categoria)
        {
            // categoria = 1 vaca
            //          = 2 toro

            if (categoria == 2)
            {
                categoria = 0;
                
            }
            

            return eventoDatos.RecuperarPorCategoria(categoria);
        }

        public Evento RecuperarUno(int id)
        {
            return eventoDatos.RecuperarUno(id);
        }

        public bool HayEventos()
        {
            return eventoDatos.HayEventos();
        }


        public void Alta_Evento(Animal animal, Evento evento, List<Desc_Subevento> listado_descripciones, DateTime fecha, Inseminador inseminador, Animal toro)
        {
            try
            {
                
                Animal = animal;
                Evento = evento;

                eventoanimal.Rp = Animal.Rp;
                eventoanimal.Id_evento = Evento.Id_evento;
                eventoanimal.Fecha_desc = fecha;

                EventoAnimal_Datos.Insertar(eventoanimal);


                switch (Evento.Nombre_evento)
                {
                    case "Parto":
                        Animal.Estado_animal = "Parto";
                        break;
                    case "Aborto":
                        Animal.Estado_animal = "Aborto";
                        break;
                    case "Celo":
                        Animal.Estado_animal = "Celo";
                        break;
                    case "Venta":
                        Animal.Estado_animal = "Vendido";

                        break;
                    case "Muerte":
                        Animal.Estado_animal = "Muerto";

                        break;
                    case "Enfermedad":
                        Animal.Estado_animal = "Enfermo";
                        break;
                    case "Medicacion":
                        Animal.Estado_animal = "Medicado";
                        break;
                    case "Tacto Rectal":
                        foreach (var item in listado_descripciones)
                        {
                            if (item.Descripcion == "Preñada")
                            {
                                Animal.Estado_animal = "Preñada";
                            }
                        }

                        break;
                    case "Vivo":
                        Animal.Estado_animal = "Vivo";
                        break;
                    case "Servicio":
                        ev_desc.Id_inseminador = inseminador.Id_inseminador;
                        break;
                    default:
                        Animal.Estado_animal = "Vivo";
                        break;

                }
                
                Animal_Datos.Actualizar(Animal);


                ev_desc.Id_evento = eventoanimal.Id_evento;
                ev_desc.Rp = eventoanimal.Rp;
                ev_desc.Fecha_desc = fecha;
                ev_desc.Id_tambo = Animal.Id_tambo;
                ev_desc.Estado_evento = true;


                ev_ds_Datos.Insertar(ev_desc, listado_descripciones);



            }
            catch (Exception ex)
            {
                throw ex;
            }




        }


        public Evento TraerSubEventosEvento(Evento ev)
        {
            try
            {
                return eventoDatos.TraerSubeventos(ev);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
