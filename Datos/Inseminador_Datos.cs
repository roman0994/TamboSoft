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
    public class Inseminador_Datos : Conexion
    {
        public List<Inseminador> RecuperarTodos()
        {

            try
            {
                List<Inseminador> lista = new List<Inseminador>();
                this.AbrirConexion();
                SqlCommand cmdInseminador = new SqlCommand("SELECT i.id_inseminador,i.nombre_inseminador,i.estado_inseminador,i.telefono,i.direccion,i.dni,i.id_localidad,l.nombre_localidad FROM Inseminador i inner join Localidad l on i.id_localidad=l.id_localidad where i.estado_inseminador = 'true'", Conn);


                SqlDataReader dr = cmdInseminador.ExecuteReader();

                while (dr.Read())
                {

                    Inseminador inseminador = new Inseminador();
                    inseminador.Id_inseminador = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_inseminador"]));
                    inseminador.Nombre_inseminador = dr.IsDBNull(1) ? string.Empty : dr["nombre_inseminador"].ToString();
                    inseminador.Estado_inseminador = dr.IsDBNull(2) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["estado_inseminador"]));
                    inseminador.Telefono = dr.IsDBNull(3) ? string.Empty : dr["telefono"].ToString();
                    inseminador.Direccion = dr.IsDBNull(4) ? string.Empty : dr["direccion"].ToString();
                    inseminador.Dni = dr.IsDBNull(5) ? string.Empty : dr["dni"].ToString();
                    inseminador.Id_localidad = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_localidad"]));
                    inseminador.Nombre_localidad = dr.IsDBNull(7) ? string.Empty : dr["nombre_localidad"].ToString();

                    lista.Add(inseminador);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los inseminadores", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Inseminador RecuperarUno(int id)
        {
            try
            {
                Inseminador inseminador = new Inseminador();
                this.AbrirConexion();
                SqlCommand cmdInseminador = new SqlCommand("SELECT i.id_inseminador,i.nombre_inseminador,i.estado_inseminador,i.telefono,i.direccion,i.dni,i.id_localidad,l.nombre_localidad FROM Inseminador i inner join Localidad l on i.id_localidad=l.id_localidad where i.id_inseminador=@id_inseminador", Conn);
                cmdInseminador.Parameters.Add("id_inseminador", SqlDbType.Int).Value = id;
                SqlDataReader drInseminador = cmdInseminador.ExecuteReader();

                while (drInseminador.Read())
                {
                    inseminador.Id_inseminador = drInseminador.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drInseminador["id_inseminador"]));
                    inseminador.Nombre_inseminador = drInseminador.IsDBNull(1) ? string.Empty : drInseminador["nombre_inseminador"].ToString();
                    inseminador.Estado_inseminador = drInseminador.IsDBNull(2) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drInseminador["estado_inseminador"]));
                    inseminador.Telefono = drInseminador.IsDBNull(3) ? string.Empty : drInseminador["telefono"].ToString();
                    inseminador.Direccion = drInseminador.IsDBNull(4) ? string.Empty : drInseminador["direccion"].ToString();
                    inseminador.Dni = drInseminador.IsDBNull(5) ? string.Empty : drInseminador["dni"].ToString();
                    inseminador.Id_localidad = drInseminador.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drInseminador["id_localidad"]));
                    inseminador.Nombre_localidad = drInseminador.IsDBNull(7) ? string.Empty : drInseminador["nombre_localidad"].ToString();
                }
                drInseminador.Close();
                return inseminador;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar inseminador", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Actualizar(Inseminador inseminador)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdActualizar = new SqlCommand("update Inseminador set nombre_inseminador=@nombre_inseminador,estado_inseminador=@estado_inseminador,telefono=@telefono,direccion=@direccion,dni=@dni,id_localidad=@id_localidad where id_inseminador= @id_inseminador", Conn);
                cmdActualizar.Parameters.Add("id_inseminador", SqlDbType.Int).Value = inseminador.Id_inseminador;
                cmdActualizar.Parameters.Add("nombre_inseminador", SqlDbType.VarChar, 50).Value = inseminador.Nombre_inseminador;
                cmdActualizar.Parameters.Add("estado_inseminador", SqlDbType.Bit).Value = inseminador.Estado_inseminador;
                cmdActualizar.Parameters.Add("telefono", SqlDbType.VarChar, 50).Value = inseminador.Telefono;
                cmdActualizar.Parameters.Add("direccion", SqlDbType.VarChar, 100).Value = inseminador.Direccion;
                cmdActualizar.Parameters.Add("dni", SqlDbType.VarChar, 9).Value = inseminador.Dni;
                cmdActualizar.Parameters.Add("id_localidad", SqlDbType.Int).Value = inseminador.Id_localidad;

                cmdActualizar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al actualizar inseminador", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Insertar(Inseminador inseminador, Tambo_Inseminador tamboInseminador)
        {
            try
            {
                this.AbrirConexion();
                //Insertar inseminador
                SqlCommand cmdInsertar1 = new SqlCommand("insert into Inseminador(nombre_inseminador,estado_inseminador,telefono,direccion,dni,id_localidad) values (@nombre_inseminador,@estado_inseminador,@telefono,@direccion,@dni,@id_localidad) SELECT SCOPE_IDENTITY()", Conn);
                cmdInsertar1.Parameters.Add("nombre_inseminador", SqlDbType.VarChar, 50).Value = inseminador.Nombre_inseminador;
                cmdInsertar1.Parameters.Add("estado_inseminador", SqlDbType.Bit).Value = inseminador.Estado_inseminador;
                cmdInsertar1.Parameters.Add("telefono", SqlDbType.VarChar, 50).Value = inseminador.Telefono;
                cmdInsertar1.Parameters.Add("direccion", SqlDbType.VarChar, 100).Value = inseminador.Direccion;
                cmdInsertar1.Parameters.Add("dni", SqlDbType.VarChar, 9).Value = inseminador.Dni;
                cmdInsertar1.Parameters.Add("id_localidad", SqlDbType.Int).Value = inseminador.Id_localidad;

                tamboInseminador.Id_inseminador = Convert.ToInt32(cmdInsertar1.ExecuteScalar());   //la consulta retorna el id autogenerado

                //Insertar tambo_inseminador a partir del id del inseminador insertado arriba
                SqlCommand cmdInsertar2 = new SqlCommand("insert into Tambo_Inseminador(id_tambo,id_inseminador) values (@id_tambo,@id_inseminador)", Conn);
                
                cmdInsertar2.Parameters.Add("id_tambo", SqlDbType.Int).Value = tamboInseminador.Id_tambo;
                cmdInsertar2.Parameters.Add("id_inseminador", SqlDbType.Int).Value = tamboInseminador.Id_inseminador;

                cmdInsertar2.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar inseminador", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable FiltrarPorNombre(string texto,int idtambo)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = new SqlCommand("SELECT i.id_inseminador,i.nombre_inseminador,i.estado_inseminador,i.telefono,i.direccion,i.dni,i.id_localidad,l.nombre_localidad FROM Inseminador i inner join Localidad l on i.id_localidad=l.id_localidad where i.nombre_inseminador like ('" + texto + "%') and a.id_tambo=@idtambo", Conn);
            cmdFiltro.Parameters.Add("idtambo", SqlDbType.Int).Value = idtambo;

            SqlDataReader dr = cmdFiltro.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }
    }
}
