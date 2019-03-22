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
    public class Animal_Datos : Conexion
    {
        public List<Animal> RecuperarTodos()
        {

            try
            {
                List<Animal> lista = new List<Animal>();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo and a.habilitado='true'", Conn);


                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    Animal animal = new Animal();
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
                    animal.Nombre_raza = dr.IsDBNull(14) ? string.Empty : dr["nombre_raza"].ToString();
                    animal.Nombre_tambo = dr.IsDBNull(15) ? string.Empty : dr["nombre_tambo"].ToString();
                    animal.Habilitado = dr.IsDBNull(16) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["habilitado"]));

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

        public List<Animal> RecuperarPorTambo(int id_tambo)
        {
            try
            {
                List<Animal> lista = new List<Animal>();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and a.estado_animal!='Vendido'", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    Animal animal = new Animal();
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
                    animal.Nombre_raza = dr.IsDBNull(14) ? string.Empty : dr["nombre_raza"].ToString();
                    animal.Nombre_tambo = dr.IsDBNull(15) ? string.Empty : dr["nombre_tambo"].ToString();
                    animal.Habilitado = dr.IsDBNull(16) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(dr["habilitado"]));


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

        public DataTable RecuperarDTPorTambo(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and a.estado_animal!='Vendido'", Conn);

            cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdAnimal.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public List<Animal> RecuperarVacasServidasPorTambo(int id_tambo)
        {
            try
            {
                List<Animal> lista = new List<Animal>();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.estado_animal,r.nombre_raza,t.nombre_tambo FROM Animal a inner join EventoAnimal_DescSubevento ev on a.rp=ev.rp inner join Evento e on ev.id_evento = e.id_evento inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and e.nombre_evento = 'Servicio' and ev.fecha_desc > DATEADD(dd,-21,GETDATE())", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {
                    Animal animal = new Animal();
                    animal.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    animal.Fecha_nacimiento = dr.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_nacimiento"]));
                    animal.Nombre_animal = dr.IsDBNull(2) ? string.Empty : dr["nombre_animal"].ToString();
                    animal.Categoria = dr.IsDBNull(3) ? string.Empty : dr["categoria"].ToString();
                    animal.Rp_madre = dr.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_madre"]));
                    animal.Rp_padre = dr.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_padre"]));
                    animal.Hba_madre = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_madre"]));
                    animal.Hba_padre = dr.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_padre"]));
                    animal.Estado_animal = dr.IsDBNull(8) ? string.Empty : dr["estado_animal"].ToString();
                    animal.Nombre_raza = dr.IsDBNull(9) ? string.Empty : dr["nombre_raza"].ToString();
                    animal.Nombre_tambo = dr.IsDBNull(10) ? string.Empty : dr["nombre_tambo"].ToString();


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

        public DataTable RecuperarDTVacasServidasPorTambo(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.estado_animal,r.nombre_raza,t.nombre_tambo FROM Animal a inner join EventoAnimal_DescSubevento ev on a.rp=ev.rp inner join Evento e on ev.id_evento = e.id_evento inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and e.nombre_evento = 'Servicio' and ev.fecha_desc > DATEADD(dd,-21,GETDATE())", Conn);

            cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdAnimal.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public List<Animal> RecuperarVacasConPartoPorTambo(int id_tambo)
        {
            try
            {
                List<Animal> lista = new List<Animal>();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT DISTINCT a.rp,a.fecha_nacimiento,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.estado_animal,r.nombre_raza,t.nombre_tambo FROM Animal a inner join EventoAnimal_DescSubevento ev on a.rp=ev.rp inner join Evento e on ev.id_evento = e.id_evento inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and e.nombre_evento = 'Parto' and ev.fecha_desc > DATEADD(dd,-21,GETDATE())", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    Animal animal = new Animal();
                    animal.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    animal.Fecha_nacimiento = dr.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_nacimiento"]));
                    animal.Nombre_animal = dr.IsDBNull(2) ? string.Empty : dr["nombre_animal"].ToString();
                    animal.Categoria = dr.IsDBNull(3) ? string.Empty : dr["categoria"].ToString();
                    animal.Rp_madre = dr.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_madre"]));
                    animal.Rp_padre = dr.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_padre"]));
                    animal.Hba_madre = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_madre"]));
                    animal.Hba_padre = dr.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_padre"]));
                    animal.Estado_animal = dr.IsDBNull(8) ? string.Empty : dr["estado_animal"].ToString();
                    animal.Nombre_raza = dr.IsDBNull(9) ? string.Empty : dr["nombre_raza"].ToString();
                    animal.Nombre_tambo = dr.IsDBNull(10) ? string.Empty : dr["nombre_tambo"].ToString();



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

        public DataTable RecuperarDTVacasConPartoPorTambo(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdAnimal = new SqlCommand("SELECT DISTINCT a.rp,a.fecha_nacimiento,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.estado_animal,r.nombre_raza,t.nombre_tambo FROM Animal a inner join EventoAnimal_DescSubevento ev on a.rp=ev.rp inner join Evento e on ev.id_evento = e.id_evento inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and e.nombre_evento = 'Parto' and ev.fecha_desc > DATEADD(dd,-21,GETDATE())", Conn);

            cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdAnimal.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public List<Animal> RecuperarAnimalesEnfermosPorTambo(int id_tambo)
        {
            try
            {
                List<Animal> lista = new List<Animal>();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.estado_animal,r.nombre_raza,t.nombre_tambo FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and a.estado_animal = 'Enfermo'", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    Animal animal = new Animal();
                    animal.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    animal.Fecha_nacimiento = dr.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_nacimiento"]));
                    animal.Nombre_animal = dr.IsDBNull(2) ? string.Empty : dr["nombre_animal"].ToString();
                    animal.Categoria = dr.IsDBNull(3) ? string.Empty : dr["categoria"].ToString();
                    animal.Rp_madre = dr.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_madre"]));
                    animal.Rp_padre = dr.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_padre"]));
                    animal.Hba_madre = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_madre"]));
                    animal.Hba_padre = dr.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_padre"]));
                    animal.Estado_animal = dr.IsDBNull(8) ? string.Empty : dr["estado_animal"].ToString();
                    animal.Nombre_raza = dr.IsDBNull(9) ? string.Empty : dr["nombre_raza"].ToString();
                    animal.Nombre_tambo = dr.IsDBNull(10) ? string.Empty : dr["nombre_tambo"].ToString();

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

        public DataTable RecuperarDTAnimalesEnfermosPorTambo(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.estado_animal,r.nombre_raza,t.nombre_tambo FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and a.estado_animal = 'Enfermo'", Conn);

            cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdAnimal.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public List<Animal> RecuperarVacasEnCeloPorTambo(int id_tambo)
        {
            try
            {
                List<Animal> lista = new List<Animal>();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.estado_animal,r.nombre_raza,t.nombre_tambo FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and a.estado_animal = 'Celo'", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {

                    Animal animal = new Animal();
                    animal.Rp = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    animal.Fecha_nacimiento = dr.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_nacimiento"]));
                    animal.Nombre_animal = dr.IsDBNull(2) ? string.Empty : dr["nombre_animal"].ToString();
                    animal.Categoria = dr.IsDBNull(3) ? string.Empty : dr["categoria"].ToString();
                    animal.Rp_madre = dr.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_madre"]));
                    animal.Rp_padre = dr.IsDBNull(5) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp_padre"]));
                    animal.Hba_madre = dr.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_madre"]));
                    animal.Hba_padre = dr.IsDBNull(7) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["hba_padre"]));
                    animal.Estado_animal = dr.IsDBNull(8) ? string.Empty : dr["estado_animal"].ToString();
                    animal.Nombre_raza = dr.IsDBNull(9) ? string.Empty : dr["nombre_raza"].ToString();
                    animal.Nombre_tambo = dr.IsDBNull(10) ? string.Empty : dr["nombre_tambo"].ToString();


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

        public DataTable RecuperarDTVacasEnCeloPorTambo(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.estado_animal,r.nombre_raza,t.nombre_tambo FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and a.estado_animal = 'Celo'", Conn);

            cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdAnimal.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public int CantidadCriasMacho(int id_tambo)
        {
            try
            {
                int cantCriasMacho=0;
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("select COUNT(*) 'Crias_Macho' from EventoAnimal_DescSubevento ev inner join Evento e on ev.id_evento = e.id_evento inner join Tambo t on ev.id_tambo = t.id_tambo where e.nombre_evento = 'Parto' and ev.id_desc = 2 and t.id_tambo=@id_tambo", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                if (dr.Read())
                {
                    cantCriasMacho = Convert.ToInt32(dr["Crias_Macho"]);
                }
                dr.Close();
                return cantCriasMacho;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public int CantidadCriasHembra(int id_tambo)
        {
            try
            {
                int cantCriasHembra=0;
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("select COUNT(*) 'Crias Hembra' from EventoAnimal_DescSubevento ev inner join Evento e on ev.id_evento = e.id_evento inner join Tambo t on ev.id_tambo = t.id_tambo where e.nombre_evento = 'Parto' and ev.id_desc = 1 and t.id_tambo=@id_tambo", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();
                if (dr.Read())
                {
                    cantCriasHembra = Convert.ToInt32(dr["Crias Hembra"]);
                }
                dr.Close();
                return cantCriasHembra;
                
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public int CantidadCriasMuertas(int id_tambo)
        {
            try
            {
                int cantCriasMuertas=0;
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("select COUNT(*) 'Crias Muertas' from EventoAnimal_DescSubevento ev inner join Evento e on ev.id_evento = e.id_evento inner join Tambo t on ev.id_tambo = t.id_tambo where e.nombre_evento = 'Parto' and ev.id_desc = 12 and t.id_tambo=@id_tambo", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                if (dr.Read())
                {
                    cantCriasMuertas = Convert.ToInt32(dr["Crias Muertas"]);
                }
                dr.Close();
                return cantCriasMuertas;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public int CantidadCriasMachoPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                int cantCriasMacho = 0;
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("select COUNT(*) 'Crias_Macho' from EventoAnimal_DescSubevento ev inner join Evento e on ev.id_evento = e.id_evento inner join Tambo t on ev.id_tambo = t.id_tambo where e.nombre_evento = 'Parto' and ev.id_desc = 2 and t.id_tambo=@id_tambo and ev.fecha_desc>=@fechaDesde and ev.fecha_desc<=@fechaHasta", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdAnimal.Parameters.Add("fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                cmdAnimal.Parameters.Add("fechaHasta", SqlDbType.DateTime).Value = fechaHasta;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                if (dr.Read())
                {
                    cantCriasMacho = Convert.ToInt32(dr["Crias_Macho"]);
                }
                dr.Close();
                return cantCriasMacho;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public int CantidadCriasHembraPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                int cantCriasHembra = 0;
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("select COUNT(*) 'Crias Hembra' from EventoAnimal_DescSubevento ev inner join Evento e on ev.id_evento = e.id_evento inner join Tambo t on ev.id_tambo = t.id_tambo where e.nombre_evento = 'Parto' and ev.id_desc = 1 and t.id_tambo=@id_tambo and ev.fecha_desc>=@fechaDesde and ev.fecha_desc<=@fechaHasta", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdAnimal.Parameters.Add("fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                cmdAnimal.Parameters.Add("fechaHasta", SqlDbType.DateTime).Value = fechaHasta;

                SqlDataReader dr = cmdAnimal.ExecuteReader();
                if (dr.Read())
                {
                    cantCriasHembra = Convert.ToInt32(dr["Crias Hembra"]);
                }
                dr.Close();
                return cantCriasHembra;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public int CantidadCriasMuertasPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                int cantCriasMuertas = 0;
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("select COUNT(*) 'Crias Muertas' from EventoAnimal_DescSubevento ev inner join Evento e on ev.id_evento = e.id_evento inner join Tambo t on ev.id_tambo = t.id_tambo where e.nombre_evento = 'Parto' and ev.id_desc = 12 and t.id_tambo=@id_tambo and ev.fecha_desc>=@fechaDesde and ev.fecha_desc<=@fechaHasta", Conn);
                cmdAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdAnimal.Parameters.Add("fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                cmdAnimal.Parameters.Add("fechaHasta", SqlDbType.DateTime).Value = fechaHasta;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                if (dr.Read())
                {
                    cantCriasMuertas = Convert.ToInt32(dr["Crias Muertas"]);
                }
                dr.Close();
                return cantCriasMuertas;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Animal RecuperarUno(int rp)
        {
            try
            {
                Animal animal = new Animal();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.rp=@rp", Conn);
                cmdAnimal.Parameters.Add("rp", SqlDbType.Int).Value = rp;
                SqlDataReader drAnimal = cmdAnimal.ExecuteReader();

                while (drAnimal.Read())
                {
                    animal.Rp = drAnimal.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAnimal["rp"]));
                    animal.Fecha_nacimiento = drAnimal.IsDBNull(1) ? Convert.ToDateTime(string.Empty) : (DateTime)drAnimal["fecha_nacimiento"];
                    animal.Edad = drAnimal.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (int)drAnimal["edad"];
                    animal.Foto = drAnimal.IsDBNull(3) ? string.Empty : drAnimal["foto"].ToString();
                    animal.Nombre_animal = drAnimal.IsDBNull(4) ? string.Empty : drAnimal["nombre_animal"].ToString();
                    animal.Estado_animal = drAnimal.IsDBNull(5) ? string.Empty : drAnimal["estado_animal"].ToString();
                    animal.Hba = drAnimal.IsDBNull(6) ? Convert.ToInt32(string.Empty) : (int)drAnimal["hba"];
                    animal.Categoria = drAnimal.IsDBNull(7) ? string.Empty : drAnimal["categoria"].ToString();
                    //animal.Sexo = drAnimal.IsDBNull(8) ? string.Empty : drAnimal["sexo"].ToString();
                    animal.Rp_madre = drAnimal.IsDBNull(8) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAnimal["rp_madre"]));
                    animal.Rp_padre = drAnimal.IsDBNull(9) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAnimal["rp_padre"]));
                    animal.Hba_madre = drAnimal.IsDBNull(10) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAnimal["hba_madre"]));
                    animal.Hba_padre = drAnimal.IsDBNull(11) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAnimal["hba_padre"]));
                    animal.Id_tambo = drAnimal.IsDBNull(12) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAnimal["id_tambo"]));
                    animal.Id_raza = drAnimal.IsDBNull(13) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drAnimal["id_raza"]));
                    animal.Nombre_raza = drAnimal.IsDBNull(14) ? string.Empty : drAnimal["nombre_raza"].ToString();
                    animal.Nombre_tambo = drAnimal.IsDBNull(15) ? string.Empty : drAnimal["nombre_tambo"].ToString();
                    animal.Habilitado = drAnimal.IsDBNull(16) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drAnimal["habilitado"]));
                }
                drAnimal.Close();
                return animal;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar animal", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Insertar(Animal animal)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Animal(fecha_nacimiento,edad,nombre_animal,estado_animal,hba,categoria,rp_madre,rp_padre,hba_madre,hba_padre,id_tambo,id_raza,habilitado) values (@fecha_nacimiento,@edad,@nombre_animal,@estado_animal,@hba,@categoria,@rp_madre,@rp_padre,@hba_madre,@hba_padre,@id_tambo,@id_raza,@habilitado)", Conn);
                cmdInsertar.Parameters.Add("fecha_nacimiento", SqlDbType.DateTime).Value = animal.Fecha_nacimiento;
                cmdInsertar.Parameters.Add("edad", SqlDbType.Int).Value = animal.Edad; ;
                cmdInsertar.Parameters.Add("nombre_animal", SqlDbType.VarChar, 50).Value = animal.Nombre_animal;
                cmdInsertar.Parameters.Add("estado_animal", SqlDbType.VarChar, 50).Value = animal.Estado_animal;
                cmdInsertar.Parameters.Add("hba", SqlDbType.Int).Value = animal.Hba;
                cmdInsertar.Parameters.Add("categoria", SqlDbType.VarChar, 20).Value = animal.Categoria;
                cmdInsertar.Parameters.Add("rp_madre", SqlDbType.Int).Value = animal.Rp_madre;
                cmdInsertar.Parameters.Add("rp_padre", SqlDbType.Int).Value = animal.Rp_padre;
                cmdInsertar.Parameters.Add("hba_madre", SqlDbType.Int).Value = animal.Hba_madre;
                cmdInsertar.Parameters.Add("hba_padre", SqlDbType.Int).Value = animal.Hba_padre;
                cmdInsertar.Parameters.Add("id_tambo", SqlDbType.Int).Value = animal.Id_tambo;
                cmdInsertar.Parameters.Add("id_raza", SqlDbType.Int).Value = animal.Id_raza;
                cmdInsertar.Parameters.Add("habilitado", SqlDbType.Bit).Value = animal.Habilitado;
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

        public void Actualizar(Animal animal)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdActualizar = new SqlCommand("update Animal set fecha_nacimiento=@fecha_nacimiento,edad=@edad,nombre_animal=@nombre_animal,estado_animal=@estado_animal,hba=@hba,categoria=@categoria,rp_madre=@rp_madre,rp_padre=@rp_padre,hba_madre=@hba_madre,hba_padre=@hba_padre,id_tambo=@id_tambo,id_raza=@id_raza,habilitado=@habilitado where rp = @rp", Conn);
                cmdActualizar.Parameters.Add("rp", SqlDbType.Int).Value = animal.Rp;
                cmdActualizar.Parameters.Add("fecha_nacimiento", SqlDbType.DateTime).Value = animal.Fecha_nacimiento;
                cmdActualizar.Parameters.Add("edad", SqlDbType.Int).Value = animal.Edad; ;
                cmdActualizar.Parameters.Add("nombre_animal", SqlDbType.VarChar, 50).Value = animal.Nombre_animal;
                cmdActualizar.Parameters.Add("estado_animal", SqlDbType.VarChar, 50).Value = animal.Estado_animal;
                cmdActualizar.Parameters.Add("hba", SqlDbType.Int).Value = animal.Hba;
                cmdActualizar.Parameters.Add("categoria", SqlDbType.VarChar, 20).Value = animal.Categoria;
                cmdActualizar.Parameters.Add("rp_madre", SqlDbType.Int).Value = animal.Rp_madre;
                cmdActualizar.Parameters.Add("rp_padre", SqlDbType.Int).Value = animal.Rp_padre;
                cmdActualizar.Parameters.Add("hba_madre", SqlDbType.Int).Value = animal.Hba_madre;
                cmdActualizar.Parameters.Add("hba_padre", SqlDbType.Int).Value = animal.Hba_padre;
                cmdActualizar.Parameters.Add("id_tambo", SqlDbType.Int).Value = animal.Id_tambo;
                cmdActualizar.Parameters.Add("id_raza", SqlDbType.Int).Value = animal.Id_raza;
                cmdActualizar.Parameters.Add("habilitado", SqlDbType.Bit).Value = animal.Habilitado;

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

        public void ActualizarEstado(string estado, int rp)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdActualizar = new SqlCommand("update Animal set estado_animal=@estado_animal where rp = @rp", Conn);

                cmdActualizar.Parameters.Add("rp", SqlDbType.Int).Value = rp;
                cmdActualizar.Parameters.Add("estado_animal", SqlDbType.VarChar, 50).Value = estado;

                cmdActualizar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al actualizar estado de animal", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void ActualizarEstadoMuerto(string estado, int rp)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdActualizar = new SqlCommand("update Animal set estado_animal=@estado_animal, habilitado = 'false' where rp = @rp", Conn);

                cmdActualizar.Parameters.Add("rp", SqlDbType.Int).Value = rp;
                cmdActualizar.Parameters.Add("estado_animal", SqlDbType.VarChar, 50).Value = estado;

                cmdActualizar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al actualizar estado de animal", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Eliminar(int rp)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdEliminar = new SqlCommand("update Animal set habilitado = 'false' where rp = @rp", Conn);
                cmdEliminar.Parameters.Add("rp", SqlDbType.Int).Value = rp;

                cmdEliminar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al dar de baja el animal", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Animal RecuperarPorRP(int rp)
        {

            try
            {
                Animal animal = new Animal();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.rp=@rp", Conn);
                cmdAnimal.Parameters.Add("rp",SqlDbType.Int).Value = rp;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {
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
                    animal.Nombre_raza = dr.IsDBNull(14) ? string.Empty : dr["nombre_raza"].ToString();
                    animal.Nombre_tambo = dr.IsDBNull(15) ? string.Empty : dr["nombre_tambo"].ToString();
                    animal.Habilitado = dr.IsDBNull(16) ? Convert.ToBoolean(string.Empty) : Convert.ToBoolean(dr["habilitado"]);
                }
                dr.Close();
                return animal;
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

        public Animal RecuperarPorNombre(string nombre)
        {

            try
            {
                Animal animal = new Animal();
                this.AbrirConexion();
                SqlCommand cmdAnimal = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.nombre_animal=@nombre_animal", Conn);
                cmdAnimal.Parameters.Add("nombre_animal", SqlDbType.VarChar,50).Value = nombre;

                SqlDataReader dr = cmdAnimal.ExecuteReader();

                while (dr.Read())
                {
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
                    animal.Nombre_raza = dr.IsDBNull(14) ? string.Empty : dr["nombre_raza"].ToString();
                    animal.Nombre_tambo = dr.IsDBNull(15) ? string.Empty : dr["nombre_tambo"].ToString();
                    animal.Habilitado = dr.IsDBNull(16) ? Convert.ToBoolean(string.Empty) : Convert.ToBoolean(dr["habilitado"]);

                }
                dr.Close();
                return animal;
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

        public DataTable FiltrarPorNombre(string texto, int idtambo)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.nombre_animal like ('%" + texto + "%') and a.id_tambo=@idtambo and a.habilitado='true'  and a.estado_animal!='Vendido'", Conn);

            cmdFiltro.Parameters.Add("idtambo", SqlDbType.Int).Value = idtambo;

            SqlDataReader dr = cmdFiltro.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public DataTable FiltrarPorRP(int rp)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = Conn.CreateCommand();
            cmdFiltro.CommandType = CommandType.Text;
            cmdFiltro.CommandText = "SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where rp like ('" + rp + "%')";
            cmdFiltro.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
            da.Fill(dt);
            this.CerrarConexion();
            return dt;

        }

        public DataTable FiltrarPorEstado(string texto, int idtambo)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = new SqlCommand("SELECT a.rp,a.fecha_nacimiento,a.edad,a.foto,a.nombre_animal,a.estado_animal,a.hba,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,a.id_tambo,a.id_raza,r.nombre_raza,t.nombre_tambo,a.habilitado FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where estado_animal like ('%" + texto + "%') and a.id_tambo=@idtambo and a.habilitado='true'  and a.estado_animal!='Vendido'", Conn);
            cmdFiltro.Parameters.Add("idtambo", SqlDbType.Int).Value = idtambo;

            SqlDataReader dr = cmdFiltro.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public DataTable FiltrarPorAnimalesEnCeloPorTambo(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = Conn.CreateCommand();
            cmdFiltro.CommandType = CommandType.Text;
            cmdFiltro.CommandText = "SELECT a.rp,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,r.nombre_raza FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.habilitado='true' and a.estado_animal = 'Celo' and a.id_tambo = ('" + id_tambo + "')";
            cmdFiltro.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
            da.Fill(dt);
            this.CerrarConexion();
            return dt;

        }

        public DataTable FiltrarPorAnimalesEnfermosPorTambo(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = Conn.CreateCommand();
            cmdFiltro.CommandType = CommandType.Text;
            cmdFiltro.CommandText = "SELECT a.rp,a.nombre_animal,a.categoria,a.rp_madre,a.rp_padre,a.hba_madre,a.hba_padre,r.nombre_raza FROM Animal a inner join Raza r on a.id_raza=r.id_raza inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and a.habilitado='true' and a.estado_animal = 'Enfermo'";
            cmdFiltro.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
            da.Fill(dt);
            this.CerrarConexion();
            return dt;

        }
    }
}
