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
    public class Provincia_Datos : Conexion
    {
        public List<Provincia> RecuperarTodos()
        {

            try
            {
                List<Provincia> lista = new List<Provincia>();
                this.AbrirConexion();
                SqlCommand cmdProvincia = new SqlCommand("SELECT id_provincia,nombre_provincia from Provincia", Conn);


                SqlDataReader drProvincia = cmdProvincia.ExecuteReader();

                while (drProvincia.Read())
                {

                    Provincia provincia = new Provincia();
                    provincia.Id_provincia = drProvincia.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drProvincia["id_provincia"]));
                    provincia.Nombre_provincia = drProvincia.IsDBNull(1) ? string.Empty : drProvincia["nombre_provincia"].ToString();

                    lista.Add(provincia);

                }
                drProvincia.Close();
                return lista;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos de las provincias", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Provincia RecuperarUno(int id)
        {
            try
            {
                Provincia provincia = new Provincia();
                this.AbrirConexion();
                SqlCommand cmdProvincia = new SqlCommand("SELECT id_provincia,nombre_provincia FROM Provincia where id_provincia=@id_provincia", Conn);
                cmdProvincia.Parameters.Add("id_provincia", SqlDbType.Int).Value = id;
                SqlDataReader drProvincia = cmdProvincia.ExecuteReader();

                while (drProvincia.Read())
                {
                    provincia.Id_provincia = drProvincia.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drProvincia["id_provincia"]));
                    provincia.Nombre_provincia = drProvincia.IsDBNull(1) ? string.Empty : drProvincia["nombre_provincia"].ToString();

                }
                drProvincia.Close();
                return provincia;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar provincia", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
