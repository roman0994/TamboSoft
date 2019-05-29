using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class EventoAnimal_DescSubevento_Datos : Conexion
    {
        public List<EventoAnimal_DescSubevento> RecuperarTodos()
        {
            try
            {
                List<EventoAnimal_DescSubevento> lista = new List<EventoAnimal_DescSubevento>();
                this.AbrirConexion();
                SqlCommand cmdEventosAnimalDescSubevento = new SqlCommand("SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_inseminador,i.nombre_inseminador,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e left join Evento ev on e.id_evento=ev.id_evento inner join Animal a on e.rp=a.rp left join Desc_Subevento d on e.id_desc=d.id_desc left join Tambo t on e.id_tambo=t.id_tambo left join Subevento s on d.id_subevento=s.id_subevento left join Inseminador i on e.id_inseminador=i.id_inseminador where e.estado_evento = 'true'", Conn);


                SqlDataReader dr = cmdEventosAnimalDescSubevento.ExecuteReader();

                while (dr.Read())
                {

                    EventoAnimal_DescSubevento eventoAnimal_DescSubevento = new EventoAnimal_DescSubevento();
                    eventoAnimal_DescSubevento.Id_desc_evento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_desc_evento"]));
                    eventoAnimal_DescSubevento.Rp = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    eventoAnimal_DescSubevento.Id_evento = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    eventoAnimal_DescSubevento.Id_desc = dr.IsDBNull(3) ? 0 : (Convert.ToInt32(dr["id_desc"]));
                    eventoAnimal_DescSubevento.Fecha_desc = dr.IsDBNull(4) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_desc"]));
                    eventoAnimal_DescSubevento.Nombre_animal = dr.IsDBNull(5) ? string.Empty : dr["nombre_animal"].ToString();
                    eventoAnimal_DescSubevento.Nombre_evento = dr.IsDBNull(6) ? string.Empty : dr["nombre_evento"].ToString();
                    eventoAnimal_DescSubevento.Nombre_subevento = dr.IsDBNull(7) ? string.Empty : dr["nombre_subevento"].ToString();
                    eventoAnimal_DescSubevento.Descripcion = dr.IsDBNull(8) ? string.Empty : dr["descripcion"].ToString();
                    eventoAnimal_DescSubevento.Id_inseminador = dr.IsDBNull(9) ? 0 : (Convert.ToInt32(dr["id_inseminador"]));
                    eventoAnimal_DescSubevento.Nombre_inseminador = dr.IsDBNull(10) ? "N/D" : dr["nombre_inseminador"].ToString();
                    eventoAnimal_DescSubevento.Id_tambo = dr.IsDBNull(11) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(12) ? string.Empty : dr["nombre_tambo"].ToString();
                    eventoAnimal_DescSubevento.Estado_evento = dr.IsDBNull(13) ? Convert.ToBoolean(string.Empty) : Convert.ToBoolean(dr["estado_evento"]);

                    lista.Add(eventoAnimal_DescSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los eventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarPorTambo(int id_tambo)
        {
            try
            {
                List<EventoAnimal_DescSubevento> lista = new List<EventoAnimal_DescSubevento>();
                this.AbrirConexion();
                SqlCommand cmdEventosAnimalDescSubevento = new SqlCommand(" SELECT e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal, " +
                                                                          " ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo, " +
                                                                          " e.estado_evento,e.id_inseminador,i.nombre_inseminador " +
                                                                          " FROM EventoAnimal_DescSubevento e " +
                                                                          " left join Evento ev on e.id_evento=ev.id_evento " +
                                                                          " left join Animal a on e.rp=a.rp " +
                                                                          " left join Tambo t on e.id_tambo=t.id_tambo " +
                                                                          " left join Desc_Subevento d on e.id_desc=d.id_desc " +
                                                                          " left join Subevento s on d.id_subevento=s.id_subevento " +
                                                                          " left join Inseminador i on e.id_inseminador=i.id_inseminador " +
                                                                          " where e.id_tambo = @id_tambo and e.estado_evento = 'true' " +
                                                                          " and a.habilitado='true' order by e.fecha_desc", Conn);
                cmdEventosAnimalDescSubevento.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdEventosAnimalDescSubevento.ExecuteReader();

                while (dr.Read())
                {

                    EventoAnimal_DescSubevento eventoAnimal_DescSubevento = new EventoAnimal_DescSubevento();
                    //eventoAnimal_DescSubevento.Id_desc_evento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_desc_evento"]));
                    eventoAnimal_DescSubevento.Rp = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    eventoAnimal_DescSubevento.Id_evento = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    eventoAnimal_DescSubevento.Id_desc = dr.IsDBNull(3) ? 0 : (Convert.ToInt32(dr["id_desc"]));
                    eventoAnimal_DescSubevento.Fecha_desc = dr.IsDBNull(4) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_desc"]));
                    eventoAnimal_DescSubevento.Nombre_animal = dr.IsDBNull(5) ? string.Empty : dr["nombre_animal"].ToString();
                    eventoAnimal_DescSubevento.Nombre_evento = dr.IsDBNull(6) ? string.Empty : dr["nombre_evento"].ToString();
                    eventoAnimal_DescSubevento.Nombre_subevento = dr.IsDBNull(7) ? "N/D" : dr["nombre_subevento"].ToString();
                    eventoAnimal_DescSubevento.Descripcion = dr.IsDBNull(8) ? "N/D" : dr["descripcion"].ToString();
                    eventoAnimal_DescSubevento.Id_tambo = dr.IsDBNull(9) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(10) ? string.Empty : dr["nombre_tambo"].ToString();
                    eventoAnimal_DescSubevento.Estado_evento = dr.IsDBNull(11) ? true : Convert.ToBoolean(dr["estado_evento"]);
                    eventoAnimal_DescSubevento.Id_inseminador = dr.IsDBNull(12) ? 0 : Convert.ToInt32(dr["id_inseminador"]);
                    eventoAnimal_DescSubevento.Nombre_inseminador = dr.IsDBNull(12) ? "N/D" : dr["nombre_inseminador"].ToString();

                    lista.Add(eventoAnimal_DescSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los eventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarPorTamboYAnimal(int id_tambo, int rp)
        {
            try
            {
                List<EventoAnimal_DescSubevento> lista = new List<EventoAnimal_DescSubevento>();
                this.AbrirConexion();
                SqlCommand cmdEventosAnimalDescSubevento = new SqlCommand("select ed.rp,ed.id_evento,ed.fecha_desc,a.nombre_animal,e.nombre_evento,t.nombre_tambo,a.caravana " +
                                                            " from EventoAnimal_DescSubevento ed " +
                                                            " inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                                                            " inner join Animal a on ea.rp = a.rp " +
                                                            " inner join Evento e on e.id_evento = ea.id_evento " +
                                                            " inner join Tambo t on ed.id_tambo = t.id_tambo " +
                                                            " where ed.id_tambo = @id_tambo and ed.estado_evento = 'true' " +
                                                            " and ed.rp=@rp " +
                                                            " group by ed.rp, ed.id_evento, ed.fecha_desc, a.nombre_animal, a.caravana, e.nombre_evento, t.nombre_tambo " +
                                                            " order by ed.fecha_desc desc ", Conn);

                cmdEventosAnimalDescSubevento.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdEventosAnimalDescSubevento.Parameters.Add("rp", SqlDbType.Int).Value = rp;

                SqlDataReader dr = cmdEventosAnimalDescSubevento.ExecuteReader();

                while (dr.Read())
                {

                    EventoAnimal_DescSubevento eventoAnimal_DescSubevento = new EventoAnimal_DescSubevento();
                    eventoAnimal_DescSubevento.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    eventoAnimal_DescSubevento.Id_evento = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    eventoAnimal_DescSubevento.Fecha_desc = dr.IsDBNull(2) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_desc"]));
                    eventoAnimal_DescSubevento.Nombre_animal = dr.IsDBNull(3) ? string.Empty : dr["nombre_animal"].ToString();
                    eventoAnimal_DescSubevento.Nombre_evento = dr.IsDBNull(4) ? string.Empty : dr["nombre_evento"].ToString();
                    //eventoAnimal_DescSubevento.Id_tambo = dr.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(5) ? string.Empty : dr["nombre_tambo"].ToString();
                    // eventoAnimal_DescSubevento.Estado_evento = dr.IsDBNull(7) ? Convert.ToBoolean(string.Empty) : Convert.ToBoolean(dr["estado_evento"]);
                    eventoAnimal_DescSubevento.Caravana = dr.IsDBNull(6) ? string.Empty : dr["caravana"].ToString();

                    lista.Add(eventoAnimal_DescSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los eventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarSoloEventosPorTambo(int id_tambo)
        {
            try
            {
                List<EventoAnimal_DescSubevento> lista = new List<EventoAnimal_DescSubevento>();
                this.AbrirConexion();
                SqlCommand cmdEventosAnimalDescSubevento = new SqlCommand("select ed.rp,ed.id_evento,ed.fecha_desc,a.nombre_animal,e.nombre_evento,t.nombre_tambo,a.caravana " +
                                                                            " from EventoAnimal_DescSubevento ed " +
                                                                            " inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                                                                            " inner join Animal a on ea.rp = a.rp " +
                                                                            " inner join Evento e on e.id_evento = ea.id_evento " +
                                                                            " inner join Tambo t on ed.id_tambo = t.id_tambo " +
                                                                            " where ed.id_tambo = @id_tambo and ed.estado_evento = 'true' " +
                                                                            " group by ed.rp, ed.id_evento, ed.fecha_desc, a.nombre_animal, a.caravana, e.nombre_evento, t.nombre_tambo " +
                                                                            " order by ed.fecha_desc desc ", Conn);
                cmdEventosAnimalDescSubevento.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdEventosAnimalDescSubevento.ExecuteReader();

                while (dr.Read())
                {
                    
                    
                    EventoAnimal_DescSubevento eventoAnimal_DescSubevento = new EventoAnimal_DescSubevento();
                    eventoAnimal_DescSubevento.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    eventoAnimal_DescSubevento.Id_evento = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    eventoAnimal_DescSubevento.Fecha_desc = dr.IsDBNull(2) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_desc"]));
                    eventoAnimal_DescSubevento.Nombre_animal = dr.IsDBNull(3) ? string.Empty : dr["nombre_animal"].ToString();
                    eventoAnimal_DescSubevento.Nombre_evento = dr.IsDBNull(4) ? string.Empty : dr["nombre_evento"].ToString();
                    //eventoAnimal_DescSubevento.Id_tambo = dr.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(5) ? string.Empty : dr["nombre_tambo"].ToString();
                   // eventoAnimal_DescSubevento.Estado_evento = dr.IsDBNull(7) ? Convert.ToBoolean(string.Empty) : Convert.ToBoolean(dr["estado_evento"]);
                    eventoAnimal_DescSubevento.Caravana = dr.IsDBNull(6) ? string.Empty : dr["caravana"].ToString();

                  
                    lista.Add(eventoAnimal_DescSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los eventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarDescripcionesPorEvento(int id_tambo, int rp, int id_evento, DateTime fecha)
        {
            try
            {
                List<EventoAnimal_DescSubevento> lista = new List<EventoAnimal_DescSubevento>();
                this.AbrirConexion();
                SqlCommand cmdEventosAnimalDescSubevento = new SqlCommand("SELECT ed.rp,e.id_evento,ed.id_desc,ed.fecha_desc,a.nombre_animal,e.nombre_evento, " +
                                                                        "s.nombre_subevento, d.descripcion, t.id_tambo, t.nombre_tambo, ed.estado_evento, ed.id_inseminador, i.nombre_inseminador,a.caravana " +
                                                                        "FROM EventoAnimal_DescSubevento ed " +
                                                                        "inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                                                                        "inner join Animal a on ea.rp = a.rp " +
                                                                        "inner join Evento e on e.id_evento = ea.id_evento " +
                                                                        "inner join Tambo t on ed.id_tambo = t.id_tambo " +
                                                                        "inner join Desc_Subevento d on ed.id_desc = d.id_desc " +
                                                                        "inner join Subevento s on d.id_subevento = s.id_subevento " +
                                                                        "left join Inseminador i on ed.id_inseminador = i.id_inseminador " +
                                                                        "where ed.id_tambo = @id_tambo and ed.rp = @rp and " +
                                                                        " e.id_evento = @id_evento and ed.fecha_desc = @fecha " +
                                                                        " and ed.estado_evento = 'true' ", Conn);
                cmdEventosAnimalDescSubevento.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdEventosAnimalDescSubevento.Parameters.Add("rp", SqlDbType.Int).Value = rp;
                cmdEventosAnimalDescSubevento.Parameters.Add("id_evento", SqlDbType.Int).Value = id_evento;
                cmdEventosAnimalDescSubevento.Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha;

                SqlDataReader dr = cmdEventosAnimalDescSubevento.ExecuteReader();

                while (dr.Read())
                {

                    EventoAnimal_DescSubevento eventoAnimal_DescSubevento = new EventoAnimal_DescSubevento();
                   // eventoAnimal_DescSubevento.Id_desc_evento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_desc_evento"]));
                    eventoAnimal_DescSubevento.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    eventoAnimal_DescSubevento.Id_evento = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    eventoAnimal_DescSubevento.Id_desc = dr.IsDBNull(2) ? 0 : (Convert.ToInt32(dr["id_desc"]));
                    eventoAnimal_DescSubevento.Fecha_desc = dr.IsDBNull(3) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_desc"]));
                    eventoAnimal_DescSubevento.Nombre_animal = dr.IsDBNull(4) ? string.Empty : dr["nombre_animal"].ToString();
                    eventoAnimal_DescSubevento.Nombre_evento = dr.IsDBNull(5) ? string.Empty : dr["nombre_evento"].ToString();
                    eventoAnimal_DescSubevento.Nombre_subevento = dr.IsDBNull(6) ? "N/D" : dr["nombre_subevento"].ToString();
                    eventoAnimal_DescSubevento.Descripcion = dr.IsDBNull(7) ? "N/D" : dr["descripcion"].ToString();
                    eventoAnimal_DescSubevento.Id_tambo = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(9) ? string.Empty : dr["nombre_tambo"].ToString();
                    eventoAnimal_DescSubevento.Estado_evento = dr.IsDBNull(10) ? true : Convert.ToBoolean(dr["estado_evento"]);
                    eventoAnimal_DescSubevento.Id_inseminador = dr.IsDBNull(11) ? 0 : Convert.ToInt32(dr["id_inseminador"]);
                    eventoAnimal_DescSubevento.Nombre_inseminador = dr.IsDBNull(12) ? "N/D" : dr["nombre_inseminador"].ToString();
                    eventoAnimal_DescSubevento.Caravana = dr.IsDBNull(13) ? string.Empty : dr["caravana"].ToString();
                    lista.Add(eventoAnimal_DescSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los eventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable RecuperarDTPorTambo(int id_tambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("SELECT e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,a.caravana,ev.nombre_evento, " +
                                                       "s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo,e.estado_evento  " +
                                                       " FROM EventoAnimal_DescSubevento e " +
                                                       " left join Evento ev on e.id_evento=ev.id_evento " +
                                                       " left join Animal a on e.rp=a.rp " +
                                                       " left join Tambo t on e.id_tambo=t.id_tambo " +
                                                       " left join Desc_Subevento d on e.id_desc=d.id_desc " +
                                                       " left join Subevento s on d.id_subevento=s.id_subevento " +
                                                       " where e.id_tambo = @id_tambo and e.estado_evento = 'true' " +
                                                       " order by e.fecha_desc", Conn);

                cmdEvento.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdEvento.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(dr);

                dr.Close();

                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable RecuperarDTPorTamboYAnimal(int id_tambo, int rp)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,a.caravana,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e left join Evento ev on e.id_evento=ev.id_evento left join Animal a on e.rp=a.rp left join Tambo t on e.id_tambo=t.id_tambo left join Desc_Subevento d on e.id_desc=d.id_desc left join Subevento s on d.id_subevento=s.id_subevento where e.id_tambo = @id_tambo and e.rp=@rp and e.estado_evento = 'true' order by e.fecha_desc", Conn);

                cmdEvento.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdEvento.Parameters.Add("rp", SqlDbType.Int).Value = rp;

                SqlDataReader dr = cmdEvento.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(dr);

                dr.Close();
                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable ReporteReproduccion(int id_tambo)
        {
            try
            {
                this.AbrirConexion();
                DataTable dt = new DataTable();
                //Partos
                SqlCommand cmdPartos = new SqlCommand("SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e left join Evento ev on e.id_evento=ev.id_evento left join Animal a on e.rp=a.rp left join Tambo t on e.id_tambo=t.id_tambo left join Desc_Subevento d on e.id_desc=d.id_desc left join Subevento s on d.id_subevento=s.id_subevento where e.id_tambo = @id_tambo and e.estado_evento = 'true' and ev.nombre_evento = 'Parto' and d.id_subevento = 1 order by e.fecha_desc", Conn);
                cmdPartos.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                SqlDataReader drPartos = cmdPartos.ExecuteReader();
                dt.Load(drPartos);
                drPartos.Close();



                //Cantidad crías hembra
                //int cantCriasHembra = 0;
                SqlCommand cmdCriasHembra = new SqlCommand("select COUNT(*) crias_hembra from EventoAnimal_DescSubevento ev inner join Evento e on ev.id_evento = e.id_evento inner join Tambo t on ev.id_tambo = t.id_tambo where e.nombre_evento = 'Parto' and ev.id_desc = 1 and t.id_tambo=@id_tambo", Conn);
                cmdCriasHembra.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                SqlDataReader drCriasHembra = cmdCriasHembra.ExecuteReader();
                //if (drCriasHembra.Read())
                //{
                //cantCriasHembra = Convert.ToInt32(drCriasHembra["crias_hembra"]);
                dt.Load(drCriasHembra);
                //}
                drCriasHembra.Close();

                //Cantidad crías muertas
                int cantCriasMuertas = 0;
                SqlCommand cmdCriasMuertas = new SqlCommand("select COUNT(*) crias_muertas from EventoAnimal_DescSubevento ev inner join Evento e on ev.id_evento = e.id_evento inner join Tambo t on ev.id_tambo = t.id_tambo where e.nombre_evento = 'Parto' and ev.id_desc = 12 and t.id_tambo=@id_tambo", Conn);
                cmdCriasMuertas.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                SqlDataReader drCriasMuertas = cmdCriasMuertas.ExecuteReader();
                if (drCriasMuertas.Read())
                {
                    cantCriasMuertas = Convert.ToInt32(drCriasMuertas["crias_muertas"]);
                    dt.Load(drCriasMuertas);
                }
                else
                {
                    cantCriasMuertas = 0;
                }
                drCriasMuertas.Close();

                
                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarPartosPorTambo(int id_tambo)
        {
            try
            {
                List<EventoAnimal_DescSubevento> lista = new List<EventoAnimal_DescSubevento>();
                this.AbrirConexion();
                SqlCommand cmdEventosAnimalDescSubevento = new SqlCommand("SELECT ed.rp, e.id_evento, ed.id_desc, ed.fecha_desc, a.nombre_animal, e.nombre_evento, " +
                                                                        "s.nombre_subevento,d.descripcion,t.id_tambo,t.nombre_tambo,ed.estado_evento,ed.id_inseminador,i.nombre_inseminador, " +
                                                                        "a.caravana " +
                                                                        "FROM EventoAnimal_DescSubevento ed " +
                                                                        "inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                                                                        "inner join Animal a on ea.rp = a.rp " +
                                                                        "inner join Evento e on e.id_evento = ea.id_evento " +
                                                                        "inner join Tambo t on ed.id_tambo = t.id_tambo " +
                                                                         "inner join Desc_Subevento d on ed.id_desc = d.id_desc " +
                                                                        "inner join Subevento s on d.id_subevento = s.id_subevento " +
                                                                        "left join Inseminador i on ed.id_inseminador = i.id_inseminador " +
                                                                         " where ed.id_tambo = @id_tambo and ed.estado_evento = 'true' " +
                                                                        " and e.nombre_evento = 'Parto' and d.id_subevento = 1 " +
                                                                        " order by ea.fecha_desc desc", Conn);



                cmdEventosAnimalDescSubevento.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdEventosAnimalDescSubevento.ExecuteReader();

                while (dr.Read())
                {
        
                    EventoAnimal_DescSubevento eventoAnimal_DescSubevento = new EventoAnimal_DescSubevento();
                    eventoAnimal_DescSubevento.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    eventoAnimal_DescSubevento.Id_evento = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    eventoAnimal_DescSubevento.Id_desc = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_desc"]));
                    eventoAnimal_DescSubevento.Fecha_desc = dr.IsDBNull(3) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_desc"]));
                    eventoAnimal_DescSubevento.Nombre_animal = dr.IsDBNull(4) ? string.Empty : dr["nombre_animal"].ToString();
                    eventoAnimal_DescSubevento.Nombre_evento = dr.IsDBNull(5) ? string.Empty : dr["nombre_evento"].ToString();
                    eventoAnimal_DescSubevento.Nombre_subevento = dr.IsDBNull(6) ? string.Empty : dr["nombre_subevento"].ToString();
                    eventoAnimal_DescSubevento.Descripcion = dr.IsDBNull(7) ? string.Empty : dr["descripcion"].ToString();
                    eventoAnimal_DescSubevento.Id_tambo = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(9) ? string.Empty : dr["nombre_tambo"].ToString();
                    eventoAnimal_DescSubevento.Estado_evento = dr.IsDBNull(10) ? true : Convert.ToBoolean(dr["estado_evento"]);
                    eventoAnimal_DescSubevento.Id_inseminador = dr.IsDBNull(11) ? 0 : (Convert.ToInt32(dr["id_inseminador"]));
                    eventoAnimal_DescSubevento.Nombre_inseminador = dr.IsDBNull(12) ? "NN" : dr["nombre_inseminador"].ToString();
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(13) ? string.Empty : dr["caravana"].ToString();

                    lista.Add(eventoAnimal_DescSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los eventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<EventoAnimal_DescSubevento> RecuperarPartosPorTamboPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                List<EventoAnimal_DescSubevento> lista = new List<EventoAnimal_DescSubevento>();
                this.AbrirConexion();

                SqlCommand cmdEventosAnimalDescSubevento = new SqlCommand("SELECT ed.rp, e.id_evento, ed.id_desc, ed.fecha_desc, a.nombre_animal, e.nombre_evento, " +
                                                                        "s.nombre_subevento,d.descripcion,t.id_tambo,t.nombre_tambo,ed.estado_evento,ed.id_inseminador,i.nombre_inseminador, " +
                                                                        "a.caravana " +
                                                                        "FROM EventoAnimal_DescSubevento ed " +
                                                                        "inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                                                                        "inner join Animal a on ea.rp = a.rp " +
                                                                        "inner join Evento e on e.id_evento = ea.id_evento " +
                                                                        "inner join Tambo t on ed.id_tambo = t.id_tambo " +
                                                                         "inner join Desc_Subevento d on ed.id_desc = d.id_desc " +
                                                                        "inner join Subevento s on d.id_subevento = s.id_subevento " +
                                                                        "left join Inseminador i on ed.id_inseminador = i.id_inseminador " +
                                                                        " where ed.id_tambo = @id_tambo and ed.estado_evento = 'true' " +
                                                                        " and e.nombre_evento = 'Parto' and d.id_subevento = 1 " +
                                                                        " and ed.fecha_desc>=@fechaDesde and ed.fecha_desc<=@fechaHasta " +
                                                                        " order by ed.fecha_desc", Conn);

                cmdEventosAnimalDescSubevento.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdEventosAnimalDescSubevento.Parameters.Add("fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                cmdEventosAnimalDescSubevento.Parameters.Add("fechaHasta", SqlDbType.DateTime).Value = fechaHasta;

                SqlDataReader dr = cmdEventosAnimalDescSubevento.ExecuteReader();

                while (dr.Read())
                {

                    EventoAnimal_DescSubevento eventoAnimal_DescSubevento = new EventoAnimal_DescSubevento();
                    eventoAnimal_DescSubevento.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    eventoAnimal_DescSubevento.Id_evento = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    eventoAnimal_DescSubevento.Id_desc = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_desc"]));
                    eventoAnimal_DescSubevento.Fecha_desc = dr.IsDBNull(3) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_desc"]));
                    eventoAnimal_DescSubevento.Nombre_animal = dr.IsDBNull(4) ? string.Empty : dr["nombre_animal"].ToString();
                    eventoAnimal_DescSubevento.Nombre_evento = dr.IsDBNull(5) ? string.Empty : dr["nombre_evento"].ToString();
                    eventoAnimal_DescSubevento.Nombre_subevento = dr.IsDBNull(6) ? string.Empty : dr["nombre_subevento"].ToString();
                    eventoAnimal_DescSubevento.Descripcion = dr.IsDBNull(7) ? string.Empty : dr["descripcion"].ToString();
                    eventoAnimal_DescSubevento.Id_tambo = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(9) ? string.Empty : dr["nombre_tambo"].ToString();
                    eventoAnimal_DescSubevento.Estado_evento = dr.IsDBNull(10) ? true : Convert.ToBoolean(dr["estado_evento"]);
                    eventoAnimal_DescSubevento.Id_inseminador = dr.IsDBNull(11) ? 0 : (Convert.ToInt32(dr["id_inseminador"]));
                    eventoAnimal_DescSubevento.Nombre_inseminador = dr.IsDBNull(12) ? "NN" : dr["nombre_inseminador"].ToString();
                    eventoAnimal_DescSubevento.Nombre_tambo = dr.IsDBNull(13) ? string.Empty : dr["caravana"].ToString();

                    lista.Add(eventoAnimal_DescSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los eventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
        
        public void Insertar(List<EventoAnimal_DescSubevento> listaEventoAnimal)
        {
            try
            {
                foreach (EventoAnimal_DescSubevento eventoAnimal in listaEventoAnimal)
                {
                    this.AbrirConexion();
                    SqlCommand cmdInsertar = new SqlCommand("insert into EventoAnimal_DescSubevento(rp,id_evento,id_desc,fecha_desc,id_inseminador,id_tambo,estado_evento) values (@rp,@id_evento,@id_desc,@fecha_desc,@id_inseminador,@id_tambo,@estado_evento)", Conn);

                    cmdInsertar.Parameters.Add("rp", SqlDbType.Int).Value = eventoAnimal.Rp;
                    cmdInsertar.Parameters.Add("id_evento", SqlDbType.Int).Value = eventoAnimal.Id_evento;
                    if (eventoAnimal.Id_desc == 0)
                    {
                        cmdInsertar.Parameters.AddWithValue("id_desc", DBNull.Value);
                    }
                    else
                    {
                        cmdInsertar.Parameters.Add("id_desc", SqlDbType.Int).Value = eventoAnimal.Id_desc;
                    }

                    cmdInsertar.Parameters.Add("fecha_desc", SqlDbType.DateTime).Value = eventoAnimal.Fecha_desc;

                    if (eventoAnimal.Id_inseminador == 0)
                    {
                        cmdInsertar.Parameters.AddWithValue("id_inseminador", DBNull.Value);
                    }
                    else
                    {
                        cmdInsertar.Parameters.Add("id_inseminador", SqlDbType.Int).Value = eventoAnimal.Id_inseminador;
                    }
                    cmdInsertar.Parameters.Add("id_tambo", SqlDbType.Int).Value = eventoAnimal.Id_tambo;
                    cmdInsertar.Parameters.Add("estado_evento", SqlDbType.Bit).Value = eventoAnimal.Estado_evento;

                    cmdInsertar.ExecuteNonQuery();
                }
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

        public void Insertar(EventoAnimal_DescSubevento ev_des, List<Desc_Subevento> listadodescripciones)
        {
            try
            {
                foreach (Desc_Subevento item in listadodescripciones)
                {
                    this.AbrirConexion();
                    ev_des.Id_desc = item.Id_desc;

                    SqlCommand cmdInsertar = new SqlCommand("insert into " +
                        " EventoAnimal_DescSubevento(rp,id_evento,id_desc,fecha_desc,id_inseminador,id_tambo,estado_evento) " +
                                           " values (@rp,@id_evento,@id_desc,@fecha_desc,@id_inseminador,@id_tambo,@estado_evento)", Conn);

                    cmdInsertar.Parameters.Add("rp", SqlDbType.Int).Value = ev_des.Rp;
                    cmdInsertar.Parameters.Add("id_evento", SqlDbType.Int).Value = ev_des.Id_evento;
                    cmdInsertar.Parameters.Add("id_desc", SqlDbType.Int).Value = ev_des.Id_desc;
                    cmdInsertar.Parameters.Add("fecha_desc", SqlDbType.DateTime).Value = ev_des.Fecha_desc;
                    if (ev_des.Id_inseminador == 0)
                    {
                        cmdInsertar.Parameters.AddWithValue("id_inseminador", DBNull.Value);
                    }
                    else
                    {
                        cmdInsertar.Parameters.Add("id_inseminador", SqlDbType.Int).Value = ev_des.Id_inseminador;
                    }
                    cmdInsertar.Parameters.Add("id_tambo", SqlDbType.Int).Value = ev_des.Id_tambo;
                    cmdInsertar.Parameters.Add("estado_evento", SqlDbType.Bit).Value = ev_des.Estado_evento;

                    cmdInsertar.ExecuteNonQuery();
                }
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

        public void Actualizar (EventoAnimal_DescSubevento evento)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("update EventoAnimal_DescSubevento set rp=@rp,id_evento=@id_evento,id_desc=@id_desc,fecha_desc=@fecha_desc,id_inseminador=@id_inseminador,id_tambo=@id_tambo,estado_animal=@estado_animal where id_desc_evento=@id_desc_evento", Conn);

                cmdInsertar.Parameters.Add("rp", SqlDbType.Int).Value = evento.Rp;
                cmdInsertar.Parameters.Add("id_evento", SqlDbType.Int).Value = evento.Id_evento;
                if (evento.Id_desc == 0)
                {
                    cmdInsertar.Parameters.AddWithValue("id_desc", DBNull.Value);
                }
                else
                {
                    cmdInsertar.Parameters.Add("id_desc", SqlDbType.Int).Value = evento.Id_desc;
                }
                cmdInsertar.Parameters.Add("fecha_desc", SqlDbType.DateTime).Value = evento.Fecha_desc;
                if (evento.Id_inseminador == 0)
                {
                    cmdInsertar.Parameters.AddWithValue("id_inseminador", DBNull.Value);
                }
                else
                {
                    cmdInsertar.Parameters.Add("id_inseminador", SqlDbType.Int).Value = evento.Id_inseminador;
                }
                cmdInsertar.Parameters.Add("id_tambo", SqlDbType.Int).Value = evento.Id_tambo;
                cmdInsertar.Parameters.Add("estado_evento", SqlDbType.Bit).Value = evento.Estado_evento;
                cmdInsertar.Parameters.Add("id_desc_evento", SqlDbType.Int).Value = evento.Id_desc_evento;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al actualizar evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
        
        public void Eliminar(bool estado_evento, int id_evento, int rp, DateTime fecha_desc)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("update EventoAnimal_DescSubevento " +
                    "set estado_evento = @estado_evento " +
                    " where id_evento=@id_evento and rp=@rp " +
                    " and CONVERT(varchar,fecha_desc,21) = CONVERT(varchar,@fecha_desc,21)", Conn);

                cmdInsertar.Parameters.Add("estado_evento", SqlDbType.Bit).Value = estado_evento;
                cmdInsertar.Parameters.Add("id_evento", SqlDbType.VarChar, 50).Value = id_evento;
                cmdInsertar.Parameters.Add("rp", SqlDbType.VarChar, 50).Value = rp;
                cmdInsertar.Parameters.Add("fecha_desc", SqlDbType.DateTime).Value = fecha_desc;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al eliminar evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable FiltrarPorNombreAnimal(string texto, int idtambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdFiltro = Conn.CreateCommand();
                cmdFiltro.CommandType = CommandType.Text;

                cmdFiltro.CommandText = "select ed.rp,ed.id_evento,ed.fecha_desc,a.nombre_animal,e.nombre_evento,ed.id_tambo,t.nombre_tambo,ed.estado_evento,a.caravana " +
                                                                               " from EventoAnimal_DescSubevento ed " +
                                                                               " inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                                                                               " inner join Animal a on ea.rp = a.rp " +
                                                                               " inner join Evento e on e.id_evento = ea.id_evento " +
                                                                               " inner join Tambo t on ed.id_tambo = t.id_tambo " +
                                                                              "where ed.id_tambo = @id_tambo and " +
                                                                                 "a.nombre_animal like('%" + texto + "%') " +
                                                                                " and ed.estado_evento = 'true' " +
                                                                               " group by ed.rp, ed.id_evento, ed.fecha_desc, a.nombre_animal, a.caravana, e.nombre_evento, t.nombre_tambo,ed.id_tambo,ed.estado_evento " +
                                                                               " order by ed.fecha_desc desc ";


                //cmdFiltro.CommandText = "SELECT ed.rp,e.id_evento,ed.id_desc,ed.fecha_desc,a.nombre_animal,e.nombre_evento, " +
                //                                                           "s.nombre_subevento, d.descripcion, t.id_tambo, t.nombre_tambo, ed.estado_evento, ed.id_inseminador, i.nombre_inseminador,a.caravana " +
                //                                                           "FROM EventoAnimal_DescSubevento ed " +
                //                                                           "inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                //                                                           "inner join Animal a on ea.rp = a.rp " +
                //                                                           "inner join Evento e on e.id_evento = ea.id_evento " +
                //                                                           "inner join Tambo t on ed.id_tambo = t.id_tambo " +
                //                                                           "inner join Desc_Subevento d on ed.id_desc = d.id_desc " +
                //                                                           "inner join Subevento s on d.id_subevento = s.id_subevento " +
                //                                                           "left join Inseminador i on ed.id_inseminador = i.id_inseminador " +
                //                                                           "where ed.id_tambo = @id_tambo and " +
                //                                                           "a.nombre_animal like('%" + texto + "%') " +
                //                                                           " and ed.estado_evento = 'true' and a.habilitado = 'true'";


                //cmdFiltro.CommandText = "SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e left join Evento ev on e.id_evento=ev.id_evento inner join Animal a on e.rp=a.rp left join Desc_Subevento d on e.id_desc=d.id_desc left join Tambo t on e.id_tambo=t.id_tambo left join Subevento s on d.id_subevento=s.id_subevento where e.id_tambo = @id_tambo and a.nombre_animal like ('%" + texto + "%') and e.estado_evento = 'true' and a.habilitado='true'";
                cmdFiltro.Parameters.Add("id_tambo", SqlDbType.Int).Value = idtambo;
                cmdFiltro.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable FiltrarPorNombreEvento(string texto, int idtambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdFiltro = Conn.CreateCommand();
                cmdFiltro.CommandType = CommandType.Text;

                //cmdFiltro.CommandText = "SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e left join Evento ev on e.id_evento=ev.id_evento inner join Animal a on e.rp=a.rp left join Desc_Subevento d on e.id_desc=d.id_desc left join Tambo t on e.id_tambo=t.id_tambo left join Subevento s on d.id_subevento=s.id_subevento where e.id_tambo = @id_tambo and ev.nombre_evento like ('%" + texto + "%') and e.estado_evento = 'true' and a.habilitado='true'";


                cmdFiltro.CommandText = "select ed.rp,ed.id_evento,ed.fecha_desc,a.nombre_animal,e.nombre_evento,ed.id_tambo,t.nombre_tambo,ed.estado_evento,a.caravana " +
                                                                               " from EventoAnimal_DescSubevento ed " +
                                                                               " inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                                                                               " inner join Animal a on ea.rp = a.rp " +
                                                                               " inner join Evento e on e.id_evento = ea.id_evento " +
                                                                               " inner join Tambo t on ed.id_tambo = t.id_tambo " +
                                                                              "where ed.id_tambo = @id_tambo and " +
                                                                           "e.nombre_evento like('%" + texto + "%') " +
                                                                          " and ed.estado_evento = 'true' " +
                                                                               " group by ed.rp, ed.id_evento, ed.fecha_desc, a.nombre_animal, a.caravana, e.nombre_evento, t.nombre_tambo,ed.id_tambo,ed.estado_evento " +
                                                                               " order by ed.fecha_desc desc ";



                //cmdFiltro.CommandText = "SELECT ed.rp,e.id_evento,ed.id_desc,ed.fecha_desc,a.nombre_animal,e.nombre_evento, " +
                //                                                           "s.nombre_subevento, d.descripcion, t.id_tambo, t.nombre_tambo, ed.estado_evento, ed.id_inseminador, i.nombre_inseminador,a.caravana " +
                //                                                           "FROM EventoAnimal_DescSubevento ed " +
                //                                                           "inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                //                                                           "inner join Animal a on ea.rp = a.rp " +
                //                                                           "inner join Evento e on e.id_evento = ea.id_evento " +
                //                                                           "inner join Tambo t on ed.id_tambo = t.id_tambo " +
                //                                                           "inner join Desc_Subevento d on ed.id_desc = d.id_desc " +
                //                                                           "inner join Subevento s on d.id_subevento = s.id_subevento " +
                //                                                           "left join Inseminador i on ed.id_inseminador = i.id_inseminador " +
                //                                                           "where ed.id_tambo = @id_tambo and " +
                //                                                           "e.nombre_evento like('%" + texto + "%') " +
                //                                                           " and ed.estado_evento = 'true' and a.habilitado = 'true'";


                cmdFiltro.Parameters.Add("id_tambo", SqlDbType.Int).Value = idtambo;
                cmdFiltro.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable FiltrarPorCaravana(string texto, int idtambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdFiltro = Conn.CreateCommand();
                cmdFiltro.CommandType = CommandType.Text;

                //cmdFiltro.CommandText = "SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e left join Evento ev on e.id_evento=ev.id_evento inner join Animal a on e.rp=a.rp left join Desc_Subevento d on e.id_desc=d.id_desc left join Tambo t on e.id_tambo=t.id_tambo left join Subevento s on d.id_subevento=s.id_subevento where e.id_tambo = @id_tambo and ev.nombre_evento like ('%" + texto + "%') and e.estado_evento = 'true' and a.habilitado='true'";


                cmdFiltro.CommandText = "select ed.rp,ed.id_evento,ed.fecha_desc,a.nombre_animal,e.nombre_evento,ed.id_tambo,t.nombre_tambo,ed.estado_evento,a.caravana " +
                                                                               " from EventoAnimal_DescSubevento ed " +
                                                                               " inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                                                                               " inner join Animal a on ea.rp = a.rp " +
                                                                               " inner join Evento e on e.id_evento = ea.id_evento " +
                                                                               " inner join Tambo t on ed.id_tambo = t.id_tambo " +
                                                                              "where ed.id_tambo = @id_tambo and " +
                                                                           "a.caravana like('%" + texto + "%') " +
                                                                          " and ed.estado_evento = 'true' " +
                                                                               " group by ed.rp, ed.id_evento, ed.fecha_desc, a.nombre_animal, a.caravana, e.nombre_evento, t.nombre_tambo,ed.id_tambo,ed.estado_evento " +
                                                                               " order by ed.fecha_desc desc ";



                //cmdFiltro.CommandText = "SELECT ed.rp,e.id_evento,ed.id_desc,ed.fecha_desc,a.nombre_animal,e.nombre_evento, " +
                //                                                           "s.nombre_subevento, d.descripcion, t.id_tambo, t.nombre_tambo, ed.estado_evento, ed.id_inseminador, i.nombre_inseminador,a.caravana " +
                //                                                           "FROM EventoAnimal_DescSubevento ed " +
                //                                                           "inner join Evento_Animal ea on ed.id_evento = ea.id_evento and ed.rp = ea.rp and ed.fecha_desc = ea.fecha_desc " +
                //                                                           "inner join Animal a on ea.rp = a.rp " +
                //                                                           "inner join Evento e on e.id_evento = ea.id_evento " +
                //                                                           "inner join Tambo t on ed.id_tambo = t.id_tambo " +
                //                                                           "inner join Desc_Subevento d on ed.id_desc = d.id_desc " +
                //                                                           "inner join Subevento s on d.id_subevento = s.id_subevento " +
                //                                                           "left join Inseminador i on ed.id_inseminador = i.id_inseminador " +
                //                                                           "where ed.id_tambo = @id_tambo and " +
                //                                                           "e.nombre_evento like('%" + texto + "%') " +
                //                                                           " and ed.estado_evento = 'true' and a.habilitado = 'true'";


                cmdFiltro.Parameters.Add("id_tambo", SqlDbType.Int).Value = idtambo;
                cmdFiltro.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }

        }

        public DataTable FiltrarPorNombreSubevento(string texto, int idtambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdFiltro = Conn.CreateCommand();
                cmdFiltro.CommandType = CommandType.Text;
                cmdFiltro.CommandText = "SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e left join Evento ev on e.id_evento=ev.id_evento inner join Animal a on e.rp=a.rp left join Desc_Subevento d on e.id_desc=d.id_desc left join Tambo t on e.id_tambo=t.id_tambo left join Subevento s on d.id_subevento=s.id_subevento where e.id_tambo = @id_tambo and s.nombre_subevento like ('%" + texto + "%') and e.estado_evento = 'true' and a.habilitado='true'";
                cmdFiltro.Parameters.Add("id_tambo", SqlDbType.Int).Value = idtambo;
                cmdFiltro.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable FiltrarPorRP(int rp)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdFiltro = Conn.CreateCommand();
                cmdFiltro.CommandType = CommandType.Text;
                cmdFiltro.CommandText = "SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_inseminador,i.nombre_inseminador,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e inner join Evento ev on e.id_evento=ev.id_evento inner join Animal a on e.rp=a.rp inner join Desc_Subevento d on e.id_desc=d.id_desc inner join Subevento s on d.id_subevento=s.id_subevento inner join Inseminador i on e.id_inseminador=i.id_inseminador inner join Tambo t on e.id_tambo=t.id_tambo where a.rp like ('" + rp + "%') and e.estado_evento = 'true'";
                cmdFiltro.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
                da.Fill(dt);

                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable FiltrarPorNombreInseminador(string texto)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdFiltro = Conn.CreateCommand();
                cmdFiltro.CommandType = CommandType.Text;
                cmdFiltro.CommandText = "SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_inseminador,i.nombre_inseminador,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e inner join Evento ev on e.id_evento=ev.id_evento inner join Animal a on e.rp=a.rp inner join Desc_Subevento d on e.id_desc=d.id_desc inner join Subevento s on d.id_subevento=s.id_subevento inner join Inseminador i on e.id_inseminador=i.id_inseminador inner join Tambo t on e.id_tambo=t.id_tambo where i.nombre_inseminador like ('" + texto + "%') and e.estado_evento = 'true'";
                cmdFiltro.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
                da.Fill(dt);
                
                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable FiltrarPorNombreTambo(string texto)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdFiltro = Conn.CreateCommand();
                cmdFiltro.CommandType = CommandType.Text;
                cmdFiltro.CommandText = "SELECT e.id_desc_evento,e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_inseminador,i.nombre_inseminador,e.id_tambo,t.nombre_tambo,e.estado_evento FROM EventoAnimal_DescSubevento e inner join Evento ev on e.id_evento=ev.id_evento inner join Animal a on e.rp=a.rp inner join Desc_Subevento d on e.id_desc=d.id_desc inner join Subevento s on d.id_subevento=s.id_subevento inner join Inseminador i on e.id_inseminador=i.id_inseminador inner join Tambo t on e.id_tambo=t.id_tambo where t.nombre_tambo like ('" + texto + "%') and e.estado_evento = 'true' and a.habilitado='true'";
                cmdFiltro.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool HayEventos(int id_tambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdEventos = new SqlCommand("SELECT e.rp,e.id_evento,e.id_desc,e.fecha_desc,a.nombre_animal,ev.nombre_evento,s.nombre_subevento,d.descripcion,e.id_tambo,t.nombre_tambo,e.estado_evento,e.id_inseminador,i.nombre_inseminador FROM EventoAnimal_DescSubevento e left join Evento ev on e.id_evento=ev.id_evento left join Animal a on e.rp=a.rp left join Tambo t on e.id_tambo=t.id_tambo left join Desc_Subevento d on e.id_desc=d.id_desc left join Subevento s on d.id_subevento=s.id_subevento left join Inseminador i on e.id_inseminador=i.id_inseminador where e.id_tambo = @id_tambo and e.estado_evento = 'true' order by e.fecha_desc", Conn);
                cmdEventos.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                SqlDataReader drEventos = cmdEventos.ExecuteReader();

                if (drEventos.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool HayPartos(DateTime fechaDesde, DateTime fechaHasta,int idtambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdEventos = new SqlCommand("exec spReporteReproduccionPorFechas @fechaDesde,@fechaHasta,@idtambo;", Conn);
                cmdEventos.Parameters.Add("fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                cmdEventos.Parameters.Add("fechaHasta", SqlDbType.DateTime).Value = fechaHasta;
                cmdEventos.Parameters.Add("idtambo", SqlDbType.Int).Value = idtambo;
                SqlDataReader drEventos = cmdEventos.ExecuteReader();

                if (drEventos.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CerrarConexion();
            }
           
        }

    }
}
