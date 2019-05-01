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
    public class Subevento_Datos : Conexion
    {
        public bool HaySubeventos()
        {
            this.AbrirConexion();
            SqlCommand cmsSubevento = new SqlCommand("select id_subevento,nombre_subevento,estado_subevento from Subevento", Conn);
            SqlDataReader drSubevento = cmsSubevento.ExecuteReader();

            if (drSubevento.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Subevento> RecuperarTodos()
        {
           

            try
            {
                List<Subevento> lista = new List<Subevento>();
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("SELECT id_subevento,nombre_subevento " +
                                                      " FROM Subevento ", Conn);


                SqlDataReader dr = cmdEvento.ExecuteReader();

                while (dr.Read())
                {

                    Subevento Subevento = new Subevento();
                    Subevento.Id_subevento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_subevento"]));
                    Subevento.Nombre_subevento = dr.IsDBNull(1) ? string.Empty : dr["nombre_subevento"].ToString();


                    lista.Add(Subevento);

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
                Exception exepcionnueva = new Exception("Error al recuperar el listado de subeventos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Subevento RecuperarPorNombre(string nombre)
        {


            try
            {
                Subevento subevento = new Subevento();
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("SELECT id_subevento,nombre_subevento " +
                                                      " FROM Subevento " +
                                                      " where nombre_subevento = @nombre", Conn);
                cmdEvento.Parameters.Add("nombre", SqlDbType.VarChar, 50).Value = nombre;

                SqlDataReader dr = cmdEvento.ExecuteReader();

                if (dr.Read())
                {


                    subevento.Id_subevento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_subevento"]));
                    subevento.Nombre_subevento = dr.IsDBNull(1) ? string.Empty : dr["nombre_subevento"].ToString();


                    

                }
                dr.Close();
                return subevento;
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

        public void Insertar(Subevento subevento)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Subevento(nombre_subevento,estado_subevento) values (@nombre_subevento,@estado_subevento)", Conn);
               
                cmdInsertar.Parameters.Add("nombre_subevento", SqlDbType.VarChar, 50).Value = subevento.Nombre_subevento;
                cmdInsertar.Parameters.Add("estado_subevento", SqlDbType.Bit).Value = subevento.Estado_subevento;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar subevento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
