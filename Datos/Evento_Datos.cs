using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class Evento_Datos : Conexion
    {
        public List<Evento> RecuperarTodos()
        {

            try
            {
                List<Evento> lista = new List<Evento>();
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("SELECT id_evento,nombre_evento FROM Evento", Conn);


                SqlDataReader dr = cmdEvento.ExecuteReader();

                while (dr.Read())
                {

                    Evento evento = new Evento();
                    evento.Id_evento = dr.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(dr["id_evento"]));
                    evento.Nombre_evento = dr.IsDBNull(1) ? string.Empty : dr["nombre_evento"].ToString();


                    lista.Add(evento);

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
                Exception exepcionnueva = new Exception("Error al recuperar los datos del evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public Evento RecuperarUno(int id)
        {
            try
            {
                Evento evento = new Evento();
                this.AbrirConexion();
                SqlCommand cmdEvento = new SqlCommand("select * from Evento where id_evento=@id_evento", Conn);
                cmdEvento.Parameters.Add("id_evento", SqlDbType.Int).Value = id;
                SqlDataReader drEvento = cmdEvento.ExecuteReader();

                while (drEvento.Read())
                {
                    evento.Id_evento = drEvento.IsDBNull(0) ? Convert.ToInt32(string.Empty) : (Convert.ToInt32(drEvento["id_evento"]));
                    evento.Nombre_evento = drEvento.IsDBNull(1) ? string.Empty : drEvento["nombre_evento"].ToString();
                }
                drEvento.Close();
                return evento;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

    }
}
