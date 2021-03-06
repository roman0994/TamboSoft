﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Desc_Subevento_Datos : Conexion
    {
        public List<Desc_Subevento> RecuperarPorSubevento (int id_subevento)
        {
            try
            {
                List<Desc_Subevento> lista = new List<Desc_Subevento>();
                this.AbrirConexion();
                SqlCommand cmdDesc = new SqlCommand("SELECT d.id_desc,d.descripcion,d.abreviacion,d.estado_desc,d.id_subevento,s.nombre_subevento FROM Desc_Subevento d inner join Subevento s on d.id_subevento=s.id_subevento where s.id_subevento=@id_subevento", Conn);
                cmdDesc.Parameters.Add("id_subevento", SqlDbType.Int).Value = id_subevento;

                SqlDataReader dr = cmdDesc.ExecuteReader();

                while (dr.Read())
                {

                    Desc_Subevento descSubevento = new Desc_Subevento();
                    descSubevento.Id_desc = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_desc"]));
                    descSubevento.Descripcion = dr.IsDBNull(1) ? string.Empty : dr["descripcion"].ToString();
                    descSubevento.Abreviacion = dr.IsDBNull(2) ? string.Empty : dr["abreviacion"].ToString();
                    descSubevento.Estado_desc = dr.IsDBNull(3) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["estado_desc"]));
                    descSubevento.Id_subevento = dr.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_subevento"]));
                    descSubevento.Nombre_subevento = dr.IsDBNull(5) ? string.Empty : dr["nombre_subevento"].ToString();

                    lista.Add(descSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar las descripciones del subevento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Desc_Subevento RecuperarUno(int id)
        {
            try
            {
                Desc_Subevento descSubvento = new Desc_Subevento();
                this.AbrirConexion();
                SqlCommand cmdSubevento = new SqlCommand("select d.id_desc,d.descripcion,d.abreviacion,d.estado_desc,d.id_subevento," +
                    " s.nombre_subevento from Desc_Subevento d inner join Subevento s on d.id_subevento=s.id_subevento where id_desc=@id_desc", Conn);
                cmdSubevento.Parameters.Add("id_desc", SqlDbType.Int).Value = id;
                SqlDataReader drSubevento = cmdSubevento.ExecuteReader();

                while (drSubevento.Read())
                {
                    descSubvento.Id_desc = drSubevento.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSubevento["id_desc"]));
                    descSubvento.Descripcion = drSubevento.IsDBNull(1) ? string.Empty : drSubevento["descripcion"].ToString();
                    descSubvento.Abreviacion = drSubevento.IsDBNull(1) ? string.Empty : drSubevento["abreviacion"].ToString();
                    descSubvento.Estado_desc = drSubevento.IsDBNull(1) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drSubevento["estado_desc"]));
                    descSubvento.Id_subevento = drSubevento.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drSubevento["id_subevento"]));
                    descSubvento.Nombre_subevento = drSubevento.IsDBNull(1) ? string.Empty : drSubevento["nombre_subevento"].ToString();
                }
                drSubevento.Close();
                return descSubvento;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar descripcion subevento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<Desc_Subevento> RecuperarTodos()
        {
            try
            {
                List<Desc_Subevento> lista = new List<Desc_Subevento>();
                this.AbrirConexion();
                SqlCommand cmdDesc = new SqlCommand("select id_desc,descripcion,abreviacion,id_subevento " +
                                                       "from Desc_Subevento ", Conn);

                SqlDataReader dr = cmdDesc.ExecuteReader();

                while (dr.Read())
                {

                    Desc_Subevento descSubevento = new Desc_Subevento();
                    descSubevento.Id_desc = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_desc"]));
                    descSubevento.Descripcion = dr.IsDBNull(1) ? string.Empty : dr["descripcion"].ToString();
                    descSubevento.Abreviacion = dr.IsDBNull(2) ? string.Empty : dr["abreviacion"].ToString();                   
                    descSubevento.Id_subevento = dr.IsDBNull(3) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_subevento"]));
                   
                    lista.Add(descSubevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar las descripciones del subevento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }



           
        }

        public Desc_Subevento RecuperarPorNombre(string nombre)
        {

            try
            {
                Desc_Subevento descSubvento = new Desc_Subevento();
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("SELECT  id_desc,descripcion,abreviacion,estado_desc,id_subevento " +
                                                      " FROM Desc_Subevento " +
                                                      " where descripcion = @nombre", Conn);
                cmdEvento.Parameters.Add("nombre", SqlDbType.VarChar, 50).Value = nombre;

                SqlDataReader dr = cmdEvento.ExecuteReader();

                if (dr.Read())
                {


                    descSubvento.Id_desc = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_desc"]));
                    descSubvento.Descripcion = dr.IsDBNull(1) ? string.Empty : dr["descripcion"].ToString();
                    descSubvento.Abreviacion = dr.IsDBNull(1) ? string.Empty : dr["abreviacion"].ToString();
                    descSubvento.Estado_desc = dr.IsDBNull(1) ? true : (Convert.ToBoolean(dr["estado_desc"]));
                    descSubvento.Id_subevento = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_subevento"]));




                }
                dr.Close();
                return descSubvento;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar el listado de subeventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Insertar(Desc_Subevento desc_Subevento)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Desc_Subevento(descripcion,abreviacion,estado_desc,id_subevento) values (@descripcion,@abreviacion,@estado_desc,@id_subevento)", Conn);
                cmdInsertar.Parameters.Add("descripcion", SqlDbType.VarChar, 100).Value = desc_Subevento.Descripcion;
                cmdInsertar.Parameters.Add("abreviacion", SqlDbType.VarChar, 10).Value = desc_Subevento.Abreviacion; ;
                cmdInsertar.Parameters.Add("estado_desc", SqlDbType.Bit).Value = desc_Subevento.Estado_desc;
                cmdInsertar.Parameters.Add("id_subevento", SqlDbType.Int).Value = desc_Subevento.Id_subevento;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar descripción", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool HayDescripciones()
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdDesc = new SqlCommand("select d.id_desc,d.descripcion,d.abreviacion,d.estado_desc,d.id_subevento from Desc_Subevento d", Conn);
                SqlDataReader drDescripcion = cmdDesc.ExecuteReader();

                if (drDescripcion.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar las descripciones del subevento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
