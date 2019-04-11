using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class AnimalApi_Datos : Conexion
    {
        public List<AnimalApi> RecuperarTodos()
        {

            try
            {
                List<AnimalApi> lista = new List<AnimalApi>();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT rp,fecha_nacimiento,edad,foto,nombre_animal,estado_animal,hba,categoria,rp_madre,rp_padre,hba_madre,hba_padre,id_tambo,id_raza,habilitado FROM Animal where habilitado='true'", Conn);


                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    AnimalApi animal = new AnimalApi();
                    animal.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    animal.Fecha_nacimiento = dr.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (DateTime)dr["fecha_nacimiento"];
                    animal.Edad = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (int)dr["edad"];
                    animal.Foto = dr.IsDBNull(3) ? string.Empty : dr["foto"].ToString();
                    animal.Nombre_animal = dr.IsDBNull(4) ? string.Empty : dr["nombre_animal"].ToString();
                    animal.Estado_animal = dr.IsDBNull(5) ? string.Empty : dr["estado_animal"].ToString();
                    animal.Hba = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (int)dr["hba"];
                    animal.Categoria = dr.IsDBNull(7) ? string.Empty : dr["categoria"].ToString();
                    animal.Rp_madre = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_madre"]));
                    animal.Rp_padre = dr.IsDBNull(9) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_padre"]));
                    animal.Hba_madre = dr.IsDBNull(10) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_madre"]));
                    animal.Hba_padre = dr.IsDBNull(11) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_padre"]));
                    animal.Id_tambo = dr.IsDBNull(12) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    animal.Id_raza = dr.IsDBNull(13) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_raza"]));
                    animal.Habilitado = dr.IsDBNull(14) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["habilitado"]));

                    lista.Add(animal);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos del animal", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<AnimalApi> RecuperarPorTambo(int id_tambo)
        {
            try
            {
                List<AnimalApi> lista = new List<AnimalApi>();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT rp,fecha_nacimiento,edad,foto,nombre_animal,estado_animal,hba,categoria,rp_madre,rp_padre,hba_madre,hba_padre,id_tambo,id_raza,habilitado FROM Animal where id_tambo=@id_tambo and habilitado='true' and estado_animal!='Vendido' and estado_animal!='Muerto' order by nombre_animal", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    AnimalApi animal = new AnimalApi();
                    animal.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    animal.Fecha_nacimiento = dr.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (DateTime)dr["fecha_nacimiento"];
                    animal.Edad = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (int)dr["edad"];
                    animal.Foto = dr.IsDBNull(3) ? string.Empty : dr["foto"].ToString();
                    animal.Nombre_animal = dr.IsDBNull(4) ? string.Empty : dr["nombre_animal"].ToString();
                    animal.Estado_animal = dr.IsDBNull(5) ? string.Empty : dr["estado_animal"].ToString();
                    animal.Hba = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (int)dr["hba"];
                    animal.Categoria = dr.IsDBNull(7) ? string.Empty : dr["categoria"].ToString();
                    animal.Rp_madre = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_madre"]));
                    animal.Rp_padre = dr.IsDBNull(9) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_padre"]));
                    animal.Hba_madre = dr.IsDBNull(10) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_madre"]));
                    animal.Hba_padre = dr.IsDBNull(11) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_padre"]));
                    animal.Id_tambo = dr.IsDBNull(12) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    animal.Id_raza = dr.IsDBNull(13) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_raza"]));
                    animal.Habilitado = dr.IsDBNull(14) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["habilitado"]));


                    lista.Add(animal);

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
