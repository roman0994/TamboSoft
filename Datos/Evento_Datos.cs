using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class Evento_Datos : Conexion
    {
        public List<Evento> RecuperarTodos()
        {

            try
            {
                List<Evento> lista = new List<Evento>();
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("SELECT id_evento,nombre_evento FROM Evento", Conn);


                SqlDataReader dr = cmdEvento.ExecuteReader();

                while (dr.Read())
                {

                    Evento evento = new Evento();
                    evento.Id_evento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    evento.Nombre_evento = dr.IsDBNull(1) ? string.Empty : dr["nombre_evento"].ToString();


                    lista.Add(evento);

                }
                dr.Close();
                return lista;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos del evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<Evento> RecuperarEventosParaToros()
        {

            try
            {
                List<Evento> lista = new List<Evento>();
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("SELECT id_evento,nombre_evento FROM Evento where nombre_evento='Analisis' or nombre_evento='Enfermedad' or nombre_evento='Medicacion' or nombre_evento='Muerte' or nombre_evento='Venta'", Conn);


                SqlDataReader dr = cmdEvento.ExecuteReader();

                while (dr.Read())
                {

                    Evento evento = new Evento();
                    evento.Id_evento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    evento.Nombre_evento = dr.IsDBNull(1) ? string.Empty : dr["nombre_evento"].ToString();


                    lista.Add(evento);

                }
                dr.Close();
                return lista;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos del evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<Evento> RecuperarPorCategoria(int tipo_categoria)
        {

            try
            {
                List<Evento> lista = new List<Evento>();
                this.AbrirConexion();
                SqlCommand cmdEvento;
                //Si la categoria es 0, tiene que traer solo los eventos para toro. Sino trae todos los eventos


                if (tipo_categoria == 0)
                {
                   cmdEvento = new SqlCommand("SELECT id_evento,nombre_evento,tipo_categoria " +
                                                     " FROM Evento " +
                                                     " where tipo_categoria = @tipo_categoria" +
                                                     " order by nombre_evento asc ", Conn);
                    cmdEvento.Parameters.Add("tipo_categoria", SqlDbType.Int).Value = tipo_categoria;

                }
                else
                {
                    cmdEvento = new SqlCommand("SELECT id_evento,nombre_evento,tipo_categoria " +
                                                     " FROM Evento " +
                                                     " order by nombre_evento asc ", Conn);
                    
                }

                SqlDataReader dr = cmdEvento.ExecuteReader();

                while (dr.Read())
                {

                    Evento evento = new Evento();
                    evento.Id_evento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    evento.Nombre_evento = dr.IsDBNull(1) ? string.Empty : dr["nombre_evento"].ToString();
                    evento.Tipo_Categoria = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["tipo_categoria"]));

                    lista.Add(evento);

                }
                dr.Close();
                return lista;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar listado de eventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }




        public Evento RecuperarUno(int id)
        {
            try
            {
                Evento evento = new Evento();
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("select * from Evento where id_evento=@id_evento", Conn);
                cmdEvento.Parameters.Add("id_evento", SqlDbType.Int).Value = id;
                SqlDataReader drEvento = cmdEvento.ExecuteReader();

                while (drEvento.Read())
                {
                    evento.Id_evento = drEvento.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drEvento["id_evento"]));
                    evento.Nombre_evento = drEvento.IsDBNull(1) ? string.Empty : drEvento["nombre_evento"].ToString();
                }
                drEvento.Close();
                return evento;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Insertar(Evento evento)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Evento(nombre_evento) values (@nombre_evento)", Conn);
              
                cmdInsertar.Parameters.Add("nombre_evento", SqlDbType.VarChar, 50).Value = evento.Nombre_evento;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool HayEventos()
        {
            this.AbrirConexion();
            SqlCommand cmdEvento = new SqlCommand("SELECT id_evento,nombre_evento FROM Evento", Conn);

            SqlDataReader drEvento = cmdEvento.ExecuteReader();

            if (drEvento.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


       



        public Evento TraerSubeventos(Evento evento)
        {
            List<Subevento> listado = new List<Subevento>();
            Subevento subevento;
            try
            {
                this.AbrirConexion();
                SqlCommand cmsSubevento = new SqlCommand("select distinct es.id_evento,es.id_subevento,e.nombre_evento,se.nombre_subevento " +
                                                            "from Evento_Subevento es " +
                                                            "inner join Evento e on e.id_evento = es.id_evento " +
                                                            "inner join Subevento se on se.id_subevento = es.id_subevento " +
                                                            "where es.id_evento = @id_evento", Conn);

                cmsSubevento.Parameters.Add("id_evento", SqlDbType.Int).Value = evento.Id_evento;

                SqlDataReader dr = cmsSubevento.ExecuteReader();

                while (dr.Read())
                {
                   
                    subevento = new Subevento();
                    subevento.Id_subevento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_subevento"]));
                    subevento.Nombre_subevento = dr.IsDBNull(1) ? string.Empty : dr["nombre_subevento"].ToString();
                    listado.Add(subevento);

                }
                dr.Close();
                evento.SubEventos = new List<Subevento>();
                evento.SubEventos = listado;
                return evento;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos del animal", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

    }
}
