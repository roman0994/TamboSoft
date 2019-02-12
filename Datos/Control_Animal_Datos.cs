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
                SqlCommand cmdControlAnimal = new SqlCommand("SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.porcentaje_grasa,c.kg_grasa from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where a.id_tambo=@id_tambo", Conn);
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
                    controlAnimal.Primer_control = dr.IsDBNull(6) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["primer_control"]));
                    controlAnimal.Segundo_control = dr.IsDBNull(7) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["segundo_control"]));
                    controlAnimal.Porcentaje_grasa = dr.IsDBNull(8) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["porcentaje_grasa"]));
                    controlAnimal.Kg_grasa = dr.IsDBNull(9) ? Convert.ToDecimal(string.Empty) : (Convert.ToDecimal(dr["kg_grasa"]));

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
                SqlCommand cmdInsertar1 = new SqlCommand("insert into Control(primer_control,segundo_control,porcentaje_grasa,kg_grasa) values (@primer_control,@segundo_control,@porcentaje_grasa,@kg_grasa) SELECT SCOPE_IDENTITY()", Conn);
                cmdInsertar1.Parameters.Add("primer_control", SqlDbType.Decimal).Value = controlAnimal.Primer_control;
                cmdInsertar1.Parameters.Add("segundo_control", SqlDbType.Decimal).Value = controlAnimal.Segundo_control;
                cmdInsertar1.Parameters.Add("porcentaje_grasa", SqlDbType.Decimal).Value = controlAnimal.Porcentaje_grasa;
                cmdInsertar1.Parameters.Add("kg_grasa", SqlDbType.Decimal).Value = controlAnimal.Kg_grasa;

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
                SqlCommand cmdActualizar1 = new SqlCommand("update Control set primer_control=@primer_control,segundo_control=@segundo_control,porcentaje_grasa=@porcentaje_grasa,kg_grasa=@kg_grasa where id_control=@id_control", Conn);
                cmdActualizar1.Parameters.Add("id_control",SqlDbType.Int).Value = controlAnimal.Id_control;
                cmdActualizar1.Parameters.Add("primer_control", SqlDbType.Decimal).Value = controlAnimal.Primer_control;
                cmdActualizar1.Parameters.Add("segundo_control", SqlDbType.Decimal).Value = controlAnimal.Segundo_control;
                cmdActualizar1.Parameters.Add("porcentaje_grasa", SqlDbType.Decimal).Value = controlAnimal.Porcentaje_grasa;
                cmdActualizar1.Parameters.Add("kg_grasa", SqlDbType.Decimal).Value = controlAnimal.Kg_grasa;

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

        public DataTable FiltrarPorNombre(string texto)
        {
            this.AbrirConexion();
            SqlCommand cmdFiltro = Conn.CreateCommand();
            cmdFiltro.CommandType = CommandType.Text;
            cmdFiltro.CommandText = "SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.porcentaje_grasa,c.kg_grasa from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where a.nombre_animal like ('" + texto + "%')";
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
            cmdFiltro.CommandText = "SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.porcentaje_grasa,c.kg_grasa from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where ca.rp like ('" + rp + "%')";
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
            cmdFiltro.CommandText = "SELECT ca.fecha_control,ca.id_control,ca.rp,a.nombre_animal,a.id_tambo,t.nombre_tambo,c.primer_control,c.segundo_control,c.porcentaje_grasa,c.kg_grasa from Control_Animal ca inner join Animal a on ca.rp=a.rp inner join Control c on ca.id_control=c.id_control inner join Tambo t on a.id_tambo=t.id_tambo where ca.fecha_control like ('" + fechaControl + "%')";
            cmdFiltro.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdFiltro);
            da.Fill(dt);
            this.CerrarConexion();
            return dt;

        }
    }
}
