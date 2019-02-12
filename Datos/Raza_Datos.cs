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
    public class Raza_Datos : Conexion
    {
        public List<Raza> RecuperarTodos()
        {

            try
            {
                List<Raza> lista = new List<Raza>();
                this.AbrirConexion();
                SqlCommand cmdRaza = new SqlCommand("SELECT r.id_raza,r.nombre_raza,r.estado_raza from Raza r", Conn);


                SqlDataReader drRaza = cmdRaza.ExecuteReader();

                while (drRaza.Read())
                {

                    Raza raza = new Raza();
                    raza.Id_raza = drRaza.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drRaza["id_raza"]));
                    raza.Nombre_raza = drRaza.IsDBNull(1) ? string.Empty : drRaza["nombre_raza"].ToString();
                    raza.Estado_raza = drRaza.IsDBNull(2) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drRaza["estado_raza"]));

                    lista.Add(raza);

                }
                drRaza.Close();
                return lista;
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos de las razas", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Raza RecuperarUno(int id)
        {
            try
            {
                Raza raza = new Raza();
                this.AbrirConexion();
                SqlCommand cmdRaza = new SqlCommand("select * from Raza where id_raza=@id_raza", Conn);
                cmdRaza.Parameters.Add("id_raza", SqlDbType.Int).Value = id;
                SqlDataReader drRaza = cmdRaza.ExecuteReader();

                while (drRaza.Read())
                {
                    raza.Id_raza = drRaza.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drRaza["id_raza"]));
                    raza.Nombre_raza = drRaza.IsDBNull(1) ? string.Empty : drRaza["nombre_raza"].ToString();
                    raza.Estado_raza = drRaza.IsDBNull(2) ? Convert.ToBoolean(string.Empty) : (Convert.ToBoolean(drRaza["estado_raza"]));
                }
                drRaza.Close();
                return raza;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar raza", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
