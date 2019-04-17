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
                SqlCommand cmdAnimal = new SqlCommand("SELECT rp,fecha_nacimiento,edad,foto,nombre_animal,estado_animal,hba,categoria,rp_madre,rp_padre,hba_madre,hba_padre,id_tambo,id_raza,habilitado,caravana FROM Animal where habilitado='true'", Conn);


                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    AnimalApi animal = new AnimalApi();
                    animal.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    animal.FechaNacimiento = dr.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (DateTime)dr["fecha_nacimiento"];
                    animal.Edad = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (int)dr["edad"];
                    animal.Foto = dr.IsDBNull(3) ? string.Empty : dr["foto"].ToString();
                    animal.NombreAnimal = dr.IsDBNull(4) ? string.Empty : dr["nombre_animal"].ToString();
                    animal.EstadoAnimal = dr.IsDBNull(5) ? string.Empty : dr["estado_animal"].ToString();
                    animal.Hba = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (int)dr["hba"];
                    animal.Categoria = dr.IsDBNull(7) ? string.Empty : dr["categoria"].ToString();
                    animal.RpMadre = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_madre"]));
                    animal.RpPadre = dr.IsDBNull(9) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_padre"]));
                    animal.HbaMadre = dr.IsDBNull(10) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_madre"]));
                    animal.HbaPadre = dr.IsDBNull(11) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_padre"]));
                    animal.IdTambo = dr.IsDBNull(12) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    animal.IdRaza = dr.IsDBNull(13) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_raza"]));
                    animal.Habilitado = dr.IsDBNull(14) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["habilitado"]));
                    animal.Caravana = dr.IsDBNull(15) ? string.Empty : dr["caravana"].ToString();
                    //animal.FechaNacimiento = DateTime.Now;
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
                SqlCommand cmdAnimal = new SqlCommand("SELECT rp,fecha_nacimiento,edad,foto,nombre_animal,estado_animal,hba,categoria,rp_madre,rp_padre,hba_madre,hba_padre,id_tambo,id_raza,habilitado,caravana FROM Animal where id_tambo=@id_tambo and habilitado='true' and estado_animal!='Vendido' and estado_animal!='Muerto' order by nombre_animal", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    AnimalApi animal = new AnimalApi();
                    animal.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    animal.FechaNacimiento = dr.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (DateTime)dr["fecha_nacimiento"];
                    animal.Edad = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (int)dr["edad"];
                    animal.Foto = dr.IsDBNull(3) ? string.Empty : dr["foto"].ToString();
                    animal.NombreAnimal = dr.IsDBNull(4) ? string.Empty : dr["nombre_animal"].ToString();
                    animal.EstadoAnimal = dr.IsDBNull(5) ? string.Empty : dr["estado_animal"].ToString();
                    animal.Hba = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (int)dr["hba"];
                    animal.Categoria = dr.IsDBNull(7) ? string.Empty : dr["categoria"].ToString();
                    animal.RpMadre = dr.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_madre"]));
                    animal.RpPadre = dr.IsDBNull(9) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_padre"]));
                    animal.HbaMadre = dr.IsDBNull(10) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_madre"]));
                    animal.HbaPadre = dr.IsDBNull(11) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_padre"]));
                    animal.IdTambo = dr.IsDBNull(12) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    animal.IdRaza = dr.IsDBNull(13) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_raza"]));
                    animal.Habilitado = dr.IsDBNull(14) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["habilitado"]));
                    animal.Caravana = dr.IsDBNull(15) ? string.Empty : dr["caravana"].ToString();
                    //animal.FechaNacimiento = DateTime.Now;

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

        public void Insertar(AnimalApi animal)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Animal(fecha_nacimiento,edad,nombre_animal,estado_animal,hba,categoria,rp_madre,rp_padre,hba_madre,hba_padre,id_tambo,id_raza,habilitado,caravana) values (@fecha_nacimiento,@edad,@nombre_animal,@estado_animal,@hba,@categoria,@rp_madre,@rp_padre,@hba_madre,@hba_padre,@id_tambo,@id_raza,@habilitado,@caravana)", Conn);
                cmdInsertar.Parameters.Add("fecha_nacimiento", SqlDbType.DateTime).Value = animal.FechaNacimiento;
                cmdInsertar.Parameters.Add("edad", SqlDbType.Int).Value = animal.Edad; ;
                cmdInsertar.Parameters.Add("nombre_animal", SqlDbType.VarChar, 50).Value = animal.NombreAnimal;
                cmdInsertar.Parameters.Add("estado_animal", SqlDbType.VarChar, 50).Value = animal.EstadoAnimal;
                cmdInsertar.Parameters.Add("hba", SqlDbType.Int).Value = animal.Hba;
                cmdInsertar.Parameters.Add("categoria", SqlDbType.VarChar, 20).Value = animal.Categoria;
                cmdInsertar.Parameters.Add("rp_madre", SqlDbType.Int).Value = animal.RpMadre;
                cmdInsertar.Parameters.Add("rp_padre", SqlDbType.Int).Value = animal.RpPadre;
                cmdInsertar.Parameters.Add("hba_madre", SqlDbType.Int).Value = animal.HbaMadre;
                cmdInsertar.Parameters.Add("hba_padre", SqlDbType.Int).Value = animal.HbaPadre;
                cmdInsertar.Parameters.Add("id_tambo", SqlDbType.Int).Value = animal.IdTambo;
                cmdInsertar.Parameters.Add("id_raza", SqlDbType.Int).Value = animal.IdRaza;
                cmdInsertar.Parameters.Add("habilitado", SqlDbType.Bit).Value = animal.Habilitado;
                cmdInsertar.Parameters.Add("caravana", SqlDbType.VarChar, 50).Value = animal.Caravana;
                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar animal", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Actualizar(AnimalApi animal)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdActualizar = new SqlCommand("update Animal set fecha_nacimiento=@fecha_nacimiento,edad=@edad,nombre_animal=@nombre_animal,estado_animal=@estado_animal,hba=@hba,categoria=@categoria,rp_madre=@rp_madre,rp_padre=@rp_padre,hba_madre=@hba_madre,hba_padre=@hba_padre,id_tambo=@id_tambo,id_raza=@id_raza,habilitado=@habilitado,caravana=@caravana where rp = @rp", Conn);
                cmdActualizar.Parameters.Add("rp", SqlDbType.Int).Value = animal.Rp;
                cmdActualizar.Parameters.Add("fecha_nacimiento", SqlDbType.DateTime).Value = animal.FechaNacimiento;
                cmdActualizar.Parameters.Add("edad", SqlDbType.Int).Value = animal.Edad; ;
                cmdActualizar.Parameters.Add("nombre_animal", SqlDbType.VarChar, 50).Value = animal.NombreAnimal;
                cmdActualizar.Parameters.Add("estado_animal", SqlDbType.VarChar, 50).Value = animal.EstadoAnimal;
                cmdActualizar.Parameters.Add("hba", SqlDbType.Int).Value = animal.Hba;
                cmdActualizar.Parameters.Add("categoria", SqlDbType.VarChar, 20).Value = animal.Categoria;
                cmdActualizar.Parameters.Add("rp_madre", SqlDbType.Int).Value = animal.RpMadre;
                cmdActualizar.Parameters.Add("rp_padre", SqlDbType.Int).Value = animal.RpPadre;
                cmdActualizar.Parameters.Add("hba_madre", SqlDbType.Int).Value = animal.HbaMadre;
                cmdActualizar.Parameters.Add("hba_padre", SqlDbType.Int).Value = animal.HbaPadre;
                cmdActualizar.Parameters.Add("id_tambo", SqlDbType.Int).Value = animal.IdTambo;
                cmdActualizar.Parameters.Add("id_raza", SqlDbType.Int).Value = animal.IdRaza;
                cmdActualizar.Parameters.Add("habilitado", SqlDbType.Bit).Value = animal.Habilitado;
                cmdActualizar.Parameters.Add("caravana", SqlDbType.VarChar, 50).Value = animal.Caravana;

                cmdActualizar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al actualizar animal", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
