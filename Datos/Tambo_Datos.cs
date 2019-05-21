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
    public class Tambo_Datos : Conexion
    {
        public List<Tambo> RecuperarTodos(int id_usuario)
        {
            try
            {
                List<Tambo> lista = new List<Tambo>();
                this.AbrirConexion();
                SqlCommand cmdTambos = new SqlCommand("select t.id_tambo,t.nombre_tambo,t.superficie,t.estado_tambo,t.id_usuario,l.id_localidad," +
                    " l.nombre_localidad,p.nombre_provincia " +
                    " from Tambo t " +
                    " inner join Localidad l on t.id_localidad=l.id_localidad " +
                    " inner join Provincia p on l.id_provincia=p.id_provincia " +
                    " where t.estado_tambo = 'true' and t.id_usuario = @id_usuario ", Conn);
                cmdTambos.Parameters.Add("id_usuario", SqlDbType.Int).Value = id_usuario;
                SqlDataReader drTambo = cmdTambos.ExecuteReader();

                while (drTambo.Read())
                {
                    Tambo tambo = new Tambo();
                    tambo.Id_tambo = drTambo.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_tambo"]));
                    tambo.Nombre_tambo = drTambo.IsDBNull(1) ? string.Empty : drTambo["nombre_tambo"].ToString();
                    tambo.Superficie = drTambo.IsDBNull(2) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(drTambo["superficie"]));
                    tambo.Estado_tambo = drTambo.IsDBNull(3) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drTambo["estado_tambo"]));
                    tambo.Id_usuario = drTambo.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_usuario"]));
                    tambo.Id_localidad = drTambo.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_localidad"]));
                    tambo.Nombre_localidad = drTambo.IsDBNull(6) ? string.Empty : drTambo["nombre_localidad"].ToString();
                    tambo.Nombre_provincia = drTambo.IsDBNull(7) ? string.Empty : drTambo["nombre_provincia"].ToString();

                    lista.Add(tambo);
                }
                drTambo.Close();
                return lista;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos del tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<Tambo> RecuperarOtrosTambos(int id_tambo,int id_usuario)
        {
            try
            {
                List<Tambo> lista = new List<Tambo>();
                this.AbrirConexion();
                SqlCommand cmdTambos = new SqlCommand("select t.id_tambo,t.nombre_tambo,t.superficie,t.estado_tambo,t.id_usuario,l.id_localidad,l.nombre_localidad,p.nombre_provincia from Tambo t inner join Localidad l on t.id_localidad=l.id_localidad inner join Provincia p on l.id_provincia=p.id_provincia where t.estado_tambo = 'true' and t.id_tambo != @id_tambo and t.id_usuario=@id_usuario", Conn);
                cmdTambos.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdTambos.Parameters.Add("id_usuario", SqlDbType.Int).Value = id_usuario;
                SqlDataReader drTambo = cmdTambos.ExecuteReader();

                while (drTambo.Read())
                {
                    Tambo tambo = new Tambo();
                    tambo.Id_tambo = drTambo.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_tambo"]));
                    tambo.Nombre_tambo = drTambo.IsDBNull(1) ? string.Empty : drTambo["nombre_tambo"].ToString();
                    tambo.Superficie = drTambo.IsDBNull(2) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(drTambo["superficie"]));
                    tambo.Estado_tambo = drTambo.IsDBNull(3) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drTambo["estado_tambo"]));
                    tambo.Id_usuario = drTambo.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_usuario"]));
                    tambo.Id_localidad = drTambo.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_localidad"]));
                    tambo.Nombre_localidad = drTambo.IsDBNull(6) ? string.Empty : drTambo["nombre_localidad"].ToString();
                    tambo.Nombre_provincia = drTambo.IsDBNull(7) ? string.Empty : drTambo["nombre_provincia"].ToString();

                    lista.Add(tambo);
                }
                drTambo.Close();

                return lista;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos del tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Tambo RecuperarUno(int id)
        {
            try
            {
                Tambo tambo = new Tambo();
                this.AbrirConexion();
                SqlCommand cmdTambo = new SqlCommand("select t.id_tambo,t.nombre_tambo,t.superficie,t.estado_tambo,t.id_usuario,l.id_localidad,l.nombre_localidad,p.nombre_provincia from Tambo t inner join Localidad l on t.id_localidad=l.id_localidad inner join Provincia p on l.id_provincia=p.id_provincia where id_tambo=@id_tambo", Conn);
                cmdTambo.Parameters.Add("id_tambo", SqlDbType.Int).Value = id;
                SqlDataReader drTambo = cmdTambo.ExecuteReader();

                while (drTambo.Read())
                {
                    tambo.Id_tambo = drTambo.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_tambo"]));
                    tambo.Nombre_tambo = drTambo.IsDBNull(1) ? string.Empty : drTambo["nombre_tambo"].ToString();
                    tambo.Superficie = drTambo.IsDBNull(2) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(drTambo["superficie"]));
                    tambo.Estado_tambo = drTambo.IsDBNull(3) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drTambo["estado_tambo"]));
                    tambo.Id_usuario = drTambo.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_usuario"]));
                    tambo.Id_localidad = drTambo.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_localidad"]));
                    tambo.Nombre_localidad = drTambo.IsDBNull(6) ? string.Empty : drTambo["nombre_localidad"].ToString();
                    tambo.Nombre_provincia = drTambo.IsDBNull(7) ? string.Empty : drTambo["nombre_provincia"].ToString();
                }
                drTambo.Close();
                return tambo;
                
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Tambo RecuperarPorNombre(string nombre_tambo)
        {
            try
            {
                Tambo tambo = new Tambo();
                this.AbrirConexion();
                SqlCommand cmdTambo = new SqlCommand("select t.id_tambo,t.nombre_tambo,t.superficie,t.estado_tambo,t.id_usuario,l.id_localidad,l.nombre_localidad,p.nombre_provincia from Tambo t inner join Localidad l on t.id_localidad=l.id_localidad inner join Provincia p on l.id_provincia=p.id_provincia where nombre_tambo=@nombre_tambo", Conn);
                cmdTambo.Parameters.Add("nombre_tambo", SqlDbType.VarChar, 50).Value = nombre_tambo;
                SqlDataReader drTambo = cmdTambo.ExecuteReader();

                while (drTambo.Read())
                {
                    tambo.Id_tambo = drTambo.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_tambo"]));
                    tambo.Nombre_tambo = drTambo.IsDBNull(1) ? string.Empty : drTambo["nombre_tambo"].ToString();
                    tambo.Superficie = drTambo.IsDBNull(2) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(drTambo["superficie"]));
                    tambo.Estado_tambo = drTambo.IsDBNull(3) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drTambo["estado_tambo"]));
                    tambo.Id_usuario = drTambo.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_usuario"]));
                    tambo.Id_localidad = drTambo.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drTambo["id_localidad"]));
                    tambo.Nombre_localidad = drTambo.IsDBNull(6) ? string.Empty : drTambo["nombre_localidad"].ToString();
                    tambo.Nombre_provincia = drTambo.IsDBNull(7) ? string.Empty : drTambo["nombre_provincia"].ToString();
                }
                drTambo.Close();
                return tambo;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool HayTambos(int id_usuario)
        {
            try
            { 
                this.AbrirConexion();
                SqlCommand cmdTambos = new SqlCommand("select t.id_tambo,t.nombre_tambo,t.superficie,t.estado_tambo,t.id_usuario,l.id_localidad,l.nombre_localidad,p.nombre_provincia from Tambo t inner join Localidad l on t.id_localidad=l.id_localidad inner join Provincia p on l.id_provincia=p.id_provincia where t.estado_tambo = 'true' and t.id_usuario=@id_usuario", Conn);
                cmdTambos.Parameters.Add("id_usuario", SqlDbType.Int).Value = id_usuario;
                SqlDataReader drTambo = cmdTambos.ExecuteReader();
            
                if(drTambo.Read())
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
                Exception exepcionnueva = new Exception("Error al recuperar los datos del tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool HayOtrosTambos(int id_tambo, int id_usuario)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdTambos = new SqlCommand("select t.id_tambo,t.nombre_tambo,t.superficie,t.estado_tambo,l.id_localidad,l.nombre_localidad,p.nombre_provincia from Tambo t inner join Localidad l on t.id_localidad=l.id_localidad inner join Provincia p on l.id_provincia=p.id_provincia where t.estado_tambo = 'true' and t.id_tambo != @id_tambo and t.id_usuario=@id_usuario", Conn);
                cmdTambos.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdTambos.Parameters.Add("id_usuario", SqlDbType.Int).Value = id_usuario;
                SqlDataReader drTambo = cmdTambos.ExecuteReader();

                if (drTambo.Read())
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
                Exception exepcionnueva = new Exception("Error al recuperar los datos del tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Actualizar(Tambo tambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdActualizar = new SqlCommand("update Tambo set nombre_tambo=@nombre_tambo,superficie=@superficie,estado_tambo=@estado_tambo,id_localidad=@id_localidad where id_tambo= @id_tambo", Conn);
                cmdActualizar.Parameters.Add("id_tambo", SqlDbType.Int).Value = tambo.Id_tambo;
                cmdActualizar.Parameters.Add("nombre_tambo", SqlDbType.VarChar, 50).Value = tambo.Nombre_tambo;
                cmdActualizar.Parameters.Add("superficie", SqlDbType.Decimal).Value = tambo.Superficie;
                cmdActualizar.Parameters.Add("estado_tambo", SqlDbType.Bit).Value = tambo.Estado_tambo;
                cmdActualizar.Parameters.Add("id_localidad", SqlDbType.Int).Value = tambo.Id_localidad;

                cmdActualizar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al actualizar tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Insertar(Tambo tambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Tambo(nombre_tambo,superficie,estado_tambo,id_localidad,id_usuario) values (@nombre_tambo,@superficie,@estado_tambo,@id_localidad,@id_usuario)", Conn);
                cmdInsertar.Parameters.Add("nombre_tambo", SqlDbType.VarChar, 50).Value = tambo.Nombre_tambo;
                cmdInsertar.Parameters.Add("superficie", SqlDbType.Decimal).Value = tambo.Superficie;
                cmdInsertar.Parameters.Add("estado_tambo", SqlDbType.Bit).Value = tambo.Estado_tambo;       
                cmdInsertar.Parameters.Add("id_localidad", SqlDbType.Int).Value = tambo.Id_localidad;
                cmdInsertar.Parameters.Add("id_usuario", SqlDbType.Int).Value = tambo.Id_usuario;
                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public int InsertarDevolviendoID(Tambo tambo)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Tambo(nombre_tambo,superficie,estado_tambo,id_usuario,id_localidad) values (@nombre_tambo,@superficie,@estado_tambo,@id_usuario,@id_localidad) SELECT SCOPE_IDENTITY()", Conn);
                cmdInsertar.Parameters.Add("nombre_tambo", SqlDbType.VarChar, 50).Value = tambo.Nombre_tambo;
                cmdInsertar.Parameters.Add("superficie", SqlDbType.Decimal).Value = tambo.Superficie;
                cmdInsertar.Parameters.Add("estado_tambo", SqlDbType.Bit).Value = tambo.Estado_tambo;
                cmdInsertar.Parameters.Add("id_usuario",SqlDbType.Int).Value = tambo.Id_usuario;
                cmdInsertar.Parameters.Add("id_localidad", SqlDbType.Int).Value = tambo.Id_localidad;

                int id_tambo = Convert.ToInt32(cmdInsertar.ExecuteScalar());   //la consulta retorna el id autogenerado
                return id_tambo;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdEliminar = new SqlCommand("update Tambo set estado_tambo = 'false' where id_tambo=@id_tambo", Conn);
                cmdEliminar.Parameters.Add("id_tambo", SqlDbType.Int).Value = id;

                cmdEliminar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al eliminar tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable FiltrarPorNombre(string texto,int idtambo, int id_usuario)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdFiltro = new SqlCommand("select t.id_tambo,t.nombre_tambo,t.superficie,t.estado_tambo,t.id_usuario,l.id_localidad,l.nombre_localidad,p.nombre_provincia from Tambo t inner join Localidad l on t.id_localidad=l.id_localidad inner join Provincia p on l.id_provincia=p.id_provincia where t.estado_tambo = 'true' and t.id_tambo != @idtambo and t.id_usuario=@id_usuario and t.nombre_tambo like ('%" + texto + "%')", Conn);
                cmdFiltro.Parameters.Add("idtambo", SqlDbType.Int).Value = idtambo;
                cmdFiltro.Parameters.Add("id_usuario", SqlDbType.Int).Value = id_usuario;

                SqlDataReader dr = cmdFiltro.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(dr);

                dr.Close();
                return dt;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos del tambo", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
