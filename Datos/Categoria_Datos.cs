using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Categoria_Datos:Conexion
    {

        public List<Categoria> RecuperarTodos()
        {

            try
            {
                List<Categoria> lista = new List<Categoria>();
                this.AbrirConexion();
                SqlCommand cmd = new SqlCommand("SELECT id_categoria,descripcion" +
                                                    " FROM Categoria ", Conn);


                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    
                    Categoria categoria = new Categoria();
                    
                    categoria.Id_Categoria = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_categoria"]));
                    categoria.Descripcion = dr.IsDBNull(1) ? string.Empty : dr["descripcion"].ToString();
                    
                    lista.Add(categoria);

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
                Exception exepcionnueva = new Exception("Error al recuperar el listado de categorias ", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }


        public Categoria RecuperarUno(int id_categoria)
        {
            try
            {
                Categoria Categoria = new Categoria();
                this.AbrirConexion();
                SqlCommand cmd = new SqlCommand("select id_categoria,descripcion from Categoria where id_categoria=@id_categoria", Conn);
                cmd.Parameters.Add("id_categoria", SqlDbType.Int).Value = id_categoria;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Categoria.Id_Categoria = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_categoria"]));
                    Categoria.Descripcion = dr.IsDBNull(1) ? string.Empty : dr["descripcion"].ToString();
                    
                }
                dr.Close();
                return Categoria;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar la categoria", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }


    }
}
