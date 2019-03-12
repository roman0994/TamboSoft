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
    public class Control_Animal_Datos : Conexion
    {
        public List<Control_Animal> RecuperarTodos()
        {
            try
            {
                List<Control_Animal> lista = new List<Control_Animal>();
                this.AbrirConexion();
                SqlCommand cmdControlAnimal = new SqlCommand("SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,c.primer_control,c.segundo_control,c.porcentaje_grasa,c.kg_grasa from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control", Conn);


                SqlDataReader dr = cmdControlAnimal.ExecuteReader();

                while (dr.Read())
                {

                    Control_Animal controlAnimal = new Control_Animal();
                    controlAnimal.Fecha_control = dr.IsDBNull(0) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_control"]));
                    controlAnimal.Id_control = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_control"]));
                    controlAnimal.Rp = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    controlAnimal.Nombre_animal = dr.IsDBNull(3) ? string.Empty : dr["nombre_animal"].ToString();
                    controlAnimal.Primer_control = dr.IsDBNull(4) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["primer_control"]));
                    controlAnimal.Segundo_control = dr.IsDBNull(5) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["segundo_control"]));
                    controlAnimal.Porcentaje_grasa = dr.IsDBNull(5) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["porcentaje_grasa"]));
                    controlAnimal.Kg_grasa = dr.IsDBNull(6) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["kg_grasa"]));

                    lista.Add(controlAnimal);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los controles", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public List<Control_Animal> RecuperarPorTambo(int id_tambo)
        {
            try
            {
                List<Control_Animal> lista = new List<Control_Animal>();
                this.AbrirConexion();
                SqlCommand cmdControlAnimal = new SqlCommand("SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.grasa_primercontrol,c.grasa_segundocontrol from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo", Conn);
                cmdControlAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

                SqlDataReader dr = cmdControlAnimal.ExecuteReader();

                while (dr.Read())
                {

                    Control_Animal controlAnimal = new Control_Animal();
                    controlAnimal.Fecha_control = dr.IsDBNull(0) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_control"]));
                    controlAnimal.Id_control = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_control"]));
                    controlAnimal.Rp = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    controlAnimal.Nombre_animal = dr.IsDBNull(3) ? string.Empty : dr["nombre_animal"].ToString();
                    controlAnimal.Id_tambo = dr.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    controlAnimal.Nombre_tambo = dr.IsDBNull(5) ? string.Empty : dr["nombre_tambo"].ToString();
                    controlAnimal.Primer_control = dr.IsDBNull(6) ? 0 : (Convert.ToDecimal(dr["primer_control"]));
                    controlAnimal.Segundo_control = dr.IsDBNull(7) ? 0 : (Convert.ToDecimal(dr["segundo_control"]));
                    controlAnimal.Grasa_primercontrol = dr.IsDBNull(8) ? 0 : (Convert.ToDecimal(dr["grasa_primercontrol"]));
                    controlAnimal.Grasa_segundocontrol = dr.IsDBNull(9) ? 0 : (Convert.ToDecimal(dr["grasa_segundocontrol"]));
                    
                    lista.Add(controlAnimal);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los controles", ex);
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
            SqlCommand cmdControl = new SqlCommand("SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.grasa_primercontrol,c.grasa_segundocontrol from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo", Conn);

            cmdControl.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdControl.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;

        }

        public List<Control_Animal> RecuperarPorTamboPorFecha(int id_tambo, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                List<Control_Animal> lista = new List<Control_Animal>();
                this.AbrirConexion();
                SqlCommand cmdControlAnimal = new SqlCommand("SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.grasa_primercontrol,c.grasa_segundocontrol FROM Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo and ca.fecha_control>=@fechaDesde and ca.fecha_control<=@fechaHasta", Conn);
                cmdControlAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdControlAnimal.Parameters.Add("fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                cmdControlAnimal.Parameters.Add("fechaHasta", SqlDbType.DateTime).Value = fechaHasta;

                SqlDataReader dr = cmdControlAnimal.ExecuteReader();

                while (dr.Read())
                {

                    Control_Animal controlAnimal = new Control_Animal();
                    controlAnimal.Fecha_control = dr.IsDBNull(0) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_control"]));
                    controlAnimal.Id_control = dr.IsDBNull(1) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_control"]));
                    controlAnimal.Rp = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["rp"]));
                    controlAnimal.Nombre_animal = dr.IsDBNull(3) ? string.Empty : dr["nombre_animal"].ToString();
                    controlAnimal.Id_tambo = dr.IsDBNull(4) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_tambo"]));
                    controlAnimal.Nombre_tambo = dr.IsDBNull(5) ? string.Empty : dr["nombre_tambo"].ToString();
                    controlAnimal.Primer_control = dr.IsDBNull(6) ? 0 : (Convert.ToDecimal(dr["primer_control"]));
                    controlAnimal.Segundo_control = dr.IsDBNull(7) ? 0 : (Convert.ToDecimal(dr["segundo_control"]));
                    controlAnimal.Grasa_primercontrol = dr.IsDBNull(8) ? 0 : (Convert.ToDecimal(dr["grasa_segundocontrol"]));
                    controlAnimal.Grasa_segundocontrol = dr.IsDBNull(9) ? 0 : (Convert.ToDecimal(dr["grasa_segundocontrol"]));

                    lista.Add(controlAnimal);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los controles", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Insertar(Control_Animal controlAnimal)
        {
            try
            {
                this.AbrirConexion();
                //Insertar control
                SqlCommand cmdInsertar1 = new SqlCommand("insert into Control(primer_control,segundo_control,grasa_primercontrol,grasa_segundocontrol) values (@primer_control,@segundo_control,@grasa_primercontrol,@grasa_segundocontrol) SELECT SCOPE_IDENTITY()", Conn);
                cmdInsertar1.Parameters.Add("primer_control", SqlDbType.Decimal).Value = controlAnimal.Primer_control;
                cmdInsertar1.Parameters.Add("segundo_control", SqlDbType.Decimal).Value = controlAnimal.Segundo_control;
                cmdInsertar1.Parameters.Add("grasa_primercontrol", SqlDbType.Decimal).Value = controlAnimal.Grasa_primercontrol;
                cmdInsertar1.Parameters.Add("grasa_segundocontrol", SqlDbType.Decimal).Value = controlAnimal.Grasa_segundocontrol;

                controlAnimal.Id_control = Convert.ToInt32(cmdInsertar1.ExecuteScalar());   //la consulta retorna el id autogenerado

                //Insertar control_animal a partir del id del control insertado arriba
                SqlCommand cmdInsertar2 = new SqlCommand("insert into Control_Animal(fecha_control,id_control,rp) values (@fecha_control,@id_control,@rp)", Conn);

                cmdInsertar2.Parameters.Add("fecha_control", SqlDbType.DateTime).Value = controlAnimal.Fecha_control;
                cmdInsertar2.Parameters.Add("id_control", SqlDbType.Int).Value = controlAnimal.Id_control;
                cmdInsertar2.Parameters.Add("rp", SqlDbType.Int).Value = controlAnimal.Rp;

                cmdInsertar2.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar control", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Actualizar(Control_Animal controlAnimal)
        {
            try
            {
                this.AbrirConexion();
                //Actualizar control
                SqlCommand cmdActualizar1 = new SqlCommand("update Control set primer_control=@primer_control,segundo_control=@segundo_control,grasa_primercontrol=@grasa_primercontrol,grasa_segundocontrol=@grasa_segundocontrol where id_control=@id_control", Conn);
                cmdActualizar1.Parameters.Add("id_control",SqlDbType.Int).Value = controlAnimal.Id_control;
                cmdActualizar1.Parameters.Add("primer_control", SqlDbType.Decimal).Value = controlAnimal.Primer_control;
                cmdActualizar1.Parameters.Add("segundo_control", SqlDbType.Decimal).Value = controlAnimal.Segundo_control;
                cmdActualizar1.Parameters.Add("grasa_primercontrol", SqlDbType.Decimal).Value = controlAnimal.Grasa_primercontrol;
                cmdActualizar1.Parameters.Add("grasa_segundocontrol", SqlDbType.Decimal).Value = controlAnimal.Grasa_segundocontrol;

                cmdActualizar1.ExecuteNonQuery();

                //Actualizar control_animal a partir del id del control insertado arriba
                SqlCommand cmdActualizar2 = new SqlCommand("update Control_Animal set fecha_control=@fecha_control,rp=@rp where id_control=@id_control", Conn);

                cmdActualizar2.Parameters.Add("fecha_control", SqlDbType.DateTime).Value = controlAnimal.Fecha_control;
                cmdActualizar2.Parameters.Add("id_control", SqlDbType.Int).Value = controlAnimal.Id_control;
                cmdActualizar2.Parameters.Add("rp", SqlDbType.Int).Value = controlAnimal.Rp;

                cmdActualizar2.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al actualizar control", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Eliminar(DateTime fecha, int id_control, int rp)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("delete from Control_Animal where fecha_control=@fecha_control and id_control=@id_control and rp=@rp", Conn);

                cmdInsertar.Parameters.Add("fecha_control", SqlDbType.DateTime).Value = fecha;
                cmdInsertar.Parameters.Add("id_control", SqlDbType.Int).Value = id_control;
                cmdInsertar.Parameters.Add("rp", SqlDbType.Int).Value = rp;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al eliminar control", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        /*public List<Control_Animal> ProduccionPorDia(int id_tambo, DateTime fecha)
        {
            try
            {
                this.AbrirConexion();
                List<Control_Animal> controlAnimales = new List<Control_Animal>();
                SqlCommand cmdControlAnimal = new SqlCommand("select (SUM(c.primer_control)+SUM(c.segundo_control)) litrostotales, (SUM(c.grasa_primercontrol) + SUM(c.grasa_segundocontrol)) grasatotal,ca.fecha_control,t.nombre_tambo from Control_Animal ca inner join Control c on ca.id_control = c.id_control inner join Animal a on ca.rp = a.rp inner join Tambo t on a.id_tambo = t.id_tambo where t.id_tambo=@id_tambo and ca.fecha_control=@fecha group by ca.fecha_control,t.nombre_tambo", Conn);

                cmdControlAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
                cmdControlAnimal.Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha;

                SqlDataReader dr = cmdControlAnimal.ExecuteReader();

                while (dr.Read())
                {
                    Control_Animal controlAnimal = new Control_Animal();
                    
                    controlAnimal.Litrostotales = dr.IsDBNull(0) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["litrostotales"]));
                    controlAnimal.Grasatotal = dr.IsDBNull(1) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["grasatotal"]));
                    controlAnimal.Fecha_control = dr.IsDBNull(2) ? Convert.ToDateTime(string.Empty) : (Convert.ToDateTime(dr["fecha_control"]));
                    controlAnimal.Nombre_tambo = dr.IsDBNull(3) ? string.Empty : dr["nombre_tambo"].ToString();
                    controlAnimales.Add(controlAnimal);
                }
                dr.Close();
                return controlAnimales;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los controles", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }

        }*/

        public DataTable ProduccionPorFecha(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdControlAnimal = new SqlCommand("select (SUM(c.primer_control)+SUM(c.segundo_control)) litrostotales, (SUM(c.grasa_primercontrol) + SUM(c.grasa_segundocontrol)) grasatotal,ca.fecha_control,t.nombre_tambo from Control_Animal ca inner join Control c on ca.id_control = c.id_control inner join Animal a on ca.rp = a.rp inner join Tambo t on a.id_tambo = t.id_tambo where t.id_tambo=@id_tambo group by ca.fecha_control,t.nombre_tambo", Conn);

            cmdControlAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdControlAnimal.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            
            dr.Close();
            this.CerrarConexion();
            return dt;
        }

        public DataTable ProduccionPorFiltroDia(int id_tambo, DateTime fecha)
        {
            this.AbrirConexion();
            SqlCommand cmdControlAnimal = new SqlCommand("select (SUM(c.primer_control)+SUM(c.segundo_control)) litrostotales, (SUM(c.grasa_primercontrol) + SUM(c.grasa_segundocontrol)) grasatotal,ca.fecha_control,t.nombre_tambo from Control_Animal ca inner join Control c on ca.id_control = c.id_control inner join Animal a on ca.rp = a.rp inner join Tambo t on a.id_tambo = t.id_tambo where t.id_tambo=@id_tambo and CONVERT(VARCHAR(10), ca.fecha_control, 103) = CONVERT(VARCHAR(10), @fecha, 103) group by ca.fecha_control,t.nombre_tambo", Conn);

            cmdControlAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
            cmdControlAnimal.Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha;

            SqlDataReader dr = cmdControlAnimal.ExecuteReader();
            DataTable dt = new DataTable();
            
            dt.Load(dr);
            
            dr.Close();
            this.CerrarConexion();
            return dt;                      
        }

        public DataTable ProduccionPorFiltroMes(int id_tambo, int mes, int año)
        {
            this.AbrirConexion();
            SqlCommand cmdControlAnimal = new SqlCommand("select (SUM(c.primer_control)+SUM(c.segundo_control)) litrostotales, (SUM(c.grasa_primercontrol) + SUM(c.grasa_segundocontrol)) grasatotal,MONTH(ca.fecha_control) Mes, YEAR(ca.fecha_control) Año,t.nombre_tambo from Control_Animal ca inner join Control c on ca.id_control = c.id_control inner join Animal a on ca.rp = a.rp inner join Tambo t on a.id_tambo = t.id_tambo where t.id_tambo = 1 and MONTH(ca.fecha_control) = @mes and YEAR(ca.fecha_control) = @año group by MONTH(ca.fecha_control), YEAR(ca.fecha_control), t.nombre_tambo", Conn);

            cmdControlAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
            cmdControlAnimal.Parameters.Add("mes", SqlDbType.Int).Value = mes;
            cmdControlAnimal.Parameters.Add("año", SqlDbType.Int).Value = año;

            SqlDataReader dr = cmdControlAnimal.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);

            dr.Close();
            this.CerrarConexion();
            return dt;
        }

        public DataTable ProduccionPorAnimal(int id_tambo)
        {
            this.AbrirConexion();
            SqlCommand cmdControlAnimal = new SqlCommand("select (SUM(c.primer_control)+SUM(c.segundo_control)) Litros_leche, (SUM(c.grasa_primercontrol) + SUM(c.grasa_segundocontrol)) Grasa_total, a.rp, a.nombre_animal, t.nombre_tambo from Control c inner join Control_Animal ca on ca.id_control = c.id_control inner join Animal a on ca.rp = a.rp inner join Tambo t on a.id_tambo = t.id_tambo where t.id_tambo=@id_tambo group by a.rp, a.nombre_animal, t.nombre_tambo", Conn);

            cmdControlAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;

            SqlDataReader dr = cmdControlAnimal.ExecuteReader();
            DataTable dt = new DataTable();
          
            dt.Load(dr);
            
            dr.Close();
            this.CerrarConexion();
            return dt;
        }

        public DataTable ProduccionPorFiltroAnimal(int id_tambo, int rp)
        {
            this.AbrirConexion();
            SqlCommand cmdControlAnimal = new SqlCommand("select (SUM(c.primer_control)+SUM(c.segundo_control)) Litros_leche, (SUM(c.grasa_primercontrol) + SUM(c.grasa_segundocontrol)) Grasa_total, a.rp, a.nombre_animal, t.nombre_tambo from Control c inner join Control_Animal ca on ca.id_control = c.id_control inner join Animal a on ca.rp = a.rp inner join Tambo t on a.id_tambo = t.id_tambo where t.id_tambo=@id_tambo and a.rp=@rp group by a.rp, a.nombre_animal, t.nombre_tambo", Conn);

            cmdControlAnimal.Parameters.Add("id_tambo", SqlDbType.Int).Value = id_tambo;
            cmdControlAnimal.Parameters.Add("rp", SqlDbType.Int).Value = rp;

            SqlDataReader dr = cmdControlAnimal.ExecuteReader();
            DataTable dt = new DataTable();
           
            dt.Load(dr);
            
            dr.Close();
            this.CerrarConexion();
            return dt;
        }

        public DataTable FiltrarPorNombre(string texto)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = Conn.CreateCommand();
            cmdFiltro.CommandType = CommandType.Text;
            cmdFiltro.CommandText = "SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.grasa_primercontrol,c.grasa_segundocontrol from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where a.nombre_animal like ('" + texto + "%')";
            cmdFiltro.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
            da.Fill(dt);
            this.CerrarConexion();
            return dt;

        }

        public DataTable FiltrarPorRP(int rp)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = Conn.CreateCommand();
            cmdFiltro.CommandType = CommandType.Text;
            cmdFiltro.CommandText = "SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.grasa_primercontrol,c.grasa_segundocontrol from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where ca.rp like ('" + rp + "%')";
            cmdFiltro.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
            da.Fill(dt);
            this.CerrarConexion();
            return dt;

        }

        public DataTable FiltrarPorFechaControl(DateTime fechaControl)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = Conn.CreateCommand();
            cmdFiltro.CommandType = CommandType.Text;
            cmdFiltro.CommandText = "SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.grasa_primercontrol,c.grasa_segundocontrol from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where ca.fecha_control like ('" + fechaControl + "%')";
            cmdFiltro.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
            da.Fill(dt);
            this.CerrarConexion();
            return dt;

        }
    }
}
