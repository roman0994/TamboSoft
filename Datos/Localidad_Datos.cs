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
    public class Localidad_Datos : Conexion
    {
        public List<Localidad> RecuperarPorProvincia(int id_provincia)
        {
            try
            {
                List<Localidad> lista = new List<Localidad>();
                this.AbrirConexion();
                SqlCommand cmdLocalidad = new SqlCommand("SELECT l.id_localidad,l.nombre_localidad,l.id_provincia,p.nombre_provincia FROM Localidad l inner join Provincia p on l.id_provincia=p.id_provincia where l.id_provincia=@id_provincia", Conn);
                cmdLocalidad.Parameters.Add("id_provincia", SqlDbType.Int).Value = id_provincia;

                SqlDataReader dr = cmdLocalidad.ExecuteReader();

                while (dr.Read())
                {

                    Localidad localidad = new Localidad();
                    localidad.Id_localidad = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_localidad"]));
                    localidad.Nombre_localidad = dr.IsDBNull(1) ? string.Empty : dr["nombre_localidad"].ToString();
                    localidad.Id_provincia = dr.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (int)dr["id_provincia"];
                    localidad.Nombre_provincia = dr.IsDBNull(3) ? string.Empty : dr["nombre_provincia"].ToString();
                   
                    lista.Add(localidad);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de las localidades", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Localidad RecuperarUno(int id)
        {
            try
            {
                Localidad localidad = new Localidad();
                this.AbrirConexion();
                SqlCommand cmdLocalidad = new SqlCommand("SELECT l.id_localidad,l.nombre_localidad,l.id_provincia,p.nombre_provincia FROM Localidad l inner join Provincia p on l.id_provincia=p.id_provincia where l.id_localidad=@id_localidad", Conn);
                cmdLocalidad.Parameters.Add("id_localidad", SqlDbType.Int).Value = id;
                SqlDataReader drLocalidad = cmdLocalidad.ExecuteReader();

                while (drLocalidad.Read())
                {
                    localidad.Id_localidad = drLocalidad.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drLocalidad["id_localidad"]));
                    localidad.Nombre_localidad = drLocalidad.IsDBNull(1) ? string.Empty : drLocalidad["nombre_localidad"].ToString();
                    localidad.Id_provincia = drLocalidad.IsDBNull(2) ? Convert.ToInt32(string.Empty) : (int)drLocalidad["id_provincia"];
                    localidad.Nombre_provincia = drLocalidad.IsDBNull(3) ? string.Empty : drLocalidad["nombre_provincia"].ToString();
                }
                drLocalidad.Close();
                return localidad;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar localidad", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Insertar(Localidad localidad)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Localidad(nombre_localidad,id_provincia) values (@nombre_localidad,@id_provincia)", Conn);
               
                cmdInsertar.Parameters.Add("nombre_localidad", SqlDbType.VarChar, 50).Value = localidad.Nombre_localidad;
                cmdInsertar.Parameters.Add("id_provincia", SqlDbType.Int).Value = localidad.Id_provincia;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar localidad", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool HayLocalidades()
        {
            Localidad localidad = new Localidad();
            this.AbrirConexion();
            SqlCommand cmdLocalidad = new SqlCommand("SELECT l.id_localidad,l.nombre_localidad,l.id_provincia,p.nombre_provincia FROM Localidad l inner join Provincia p on l.id_provincia=p.id_provincia", Conn);
            SqlDataReader drTambo = cmdLocalidad.ExecuteReader();

            if (drTambo.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
