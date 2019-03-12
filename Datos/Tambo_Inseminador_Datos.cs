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
    public class Tambo_Inseminador_Datos : Conexion
    {
        public List<Tambo_Inseminador> RecuperarTodos()
        {

            try
            {
                List<Tambo_Inseminador> lista = new List<Tambo_Inseminador>();
                this.AbrirConexion();
                SqlCommand cmdTamboInseminador = new SqlCommand("SELECT ti.id_tambo,ti.id_inseminador,t.nombre_tambo,i.nombre_inseminador,i.estado_inseminador,i.telefono,i.direccion,i.dni,i.id_localidad,l.nombre_localidad FROM Tambo_Inseminador ti inner join Tambo t on ti.id_tambo=t.id_tambo inner join Inseminador i on i.id_inseminador=ti.id_inseminador inner join Localidad l on i.id_localidad=l.id_localidad", Conn);

                SqlDataReader dr = cmdTamboInseminador.ExecuteReader();

                while (dr.Read())
                {

                    Tambo_Inseminador tamboInseminador = new Tambo_Inseminador();
                    tamboInseminador.Id_tambo = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    tamboInseminador.Id_inseminador = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_inseminador"]));
                    tamboInseminador.Nombre_tambo = dr.IsDBNull(2) ? string.Empty : dr["nombre_tambo"].ToString();
                    tamboInseminador.Nombre_inseminador = dr.IsDBNull(3) ? string.Empty : dr["nombre_inseminador"].ToString();
                    tamboInseminador.Estado_inseminador = dr.IsDBNull(4) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["estado_inseminador"]));
                    tamboInseminador.Telefono = dr.IsDBNull(5) ? string.Empty : dr["telefono"].ToString();
                    tamboInseminador.Direccion = dr.IsDBNull(6) ? string.Empty : dr["direccion"].ToString();
                    tamboInseminador.Dni = dr.IsDBNull(7) ? string.Empty : dr["dni"].ToString();
                    tamboInseminador.Id_localidad = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_localidad"]));
                    tamboInseminador.Nombre_localidad = dr.IsDBNull(9) ? string.Empty : dr["nombre_localidad"].ToString();

                    lista.Add(tamboInseminador);

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

        public List<Tambo_Inseminador> RecuperarPorTambo(int id_tambo)
        {

            try
            {
                List<Tambo_Inseminador> lista = new List<Tambo_Inseminador>();
                this.AbrirConexion();
                SqlCommand cmdTamboInseminador = new SqlCommand("SELECT ti.id_tambo,ti.id_inseminador,t.nombre_tambo,i.nombre_inseminador,i.estado_inseminador,i.telefono,i.direccion,i.dni,i.id_localidad,l.nombre_localidad FROM Tambo_Inseminador ti inner join Tambo t on ti.id_tambo=t.id_tambo inner join Inseminador i on i.id_inseminador=ti.id_inseminador inner join Localidad l on i.id_localidad=l.id_localidad where ti.id_tambo=@id_tambo and i.estado_inseminador='true'", Conn);
                cmdTamboInseminador.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdTamboInseminador.ExecuteReader();

                while (dr.Read())
                {

                    Tambo_Inseminador tamboInseminador = new Tambo_Inseminador();
                    tamboInseminador.Id_tambo = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    tamboInseminador.Id_inseminador = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_inseminador"]));
                    tamboInseminador.Nombre_tambo = dr.IsDBNull(2) ? string.Empty : dr["nombre_tambo"].ToString();
                    tamboInseminador.Nombre_inseminador = dr.IsDBNull(3) ? string.Empty : dr["nombre_inseminador"].ToString();
                    tamboInseminador.Estado_inseminador = dr.IsDBNull(4) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["estado_inseminador"]));
                    tamboInseminador.Telefono = dr.IsDBNull(5) ? string.Empty : dr["telefono"].ToString();
                    tamboInseminador.Direccion = dr.IsDBNull(6) ? string.Empty : dr["direccion"].ToString();
                    tamboInseminador.Dni = dr.IsDBNull(7) ? string.Empty : dr["dni"].ToString();
                    tamboInseminador.Id_localidad = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_localidad"]));
                    tamboInseminador.Nombre_localidad = dr.IsDBNull(9) ? string.Empty : dr["nombre_localidad"].ToString();

                    lista.Add(tamboInseminador);

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

        public DataTable RecuperarDTPorTambo(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdInseminador = new SqlCommand("SELECT ti.id_tambo,ti.id_inseminador,t.nombre_tambo,i.nombre_inseminador,i.estado_inseminador,i.telefono,i.direccion,i.dni,i.id_localidad,l.nombre_localidad FROM Tambo_Inseminador ti inner join Tambo t on ti.id_tambo=t.id_tambo inner join Inseminador i on i.id_inseminador=ti.id_inseminador inner join Localidad l on i.id_localidad=l.id_localidad where ti.id_tambo=@id_tambo and i.estado_inseminador='true'", Conn);

            cmdInseminador.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdInseminador.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public void Eliminar(int id_inseminador)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdEliminar = new SqlCommand("update Inseminador set estado_inseminador = 'false' where id_inseminador=@id_inseminador", Conn);
                //cmdEliminar.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdEliminar.Parameters.Add("id_inseminador", SqlDbType.Int).Value = id_inseminador;

                cmdEliminar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al dar de baja el inseminador", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

    }
}
