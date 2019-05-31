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
    public class EventoAnimal_Datos : Conexion
    {

        public void Insertar(Evento_Animal eventoAnimal)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("INSERT INTO Evento_Animal "+
                                                        "(rp, id_evento,fecha_desc) "+
                                                       "VALUES (@rp,@id_evento,@fecha_desc)", Conn);
                cmdInsertar.Parameters.Add("rp", SqlDbType.Int).Value = eventoAnimal.Rp;
                cmdInsertar.Parameters.Add("id_evento", SqlDbType.Int).Value = eventoAnimal.Id_evento;
                cmdInsertar.Parameters.Add("fecha_desc", SqlDbType.DateTime).Value = eventoAnimal.Fecha_desc;               
                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar evento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool TieneEventos(int rp)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdEventos = new SqlCommand("SELECT e.rp,e.id_evento,e.fecha_desc FROM Evento_Animal e inner join Animal a on a.rp=e.rp where e.rp=@rp and a.habilitado = 'true'", Conn);
                cmdEventos.Parameters.Add("rp", SqlDbType.Int).Value = rp;
                SqlDataReader drEventos = cmdEventos.ExecuteReader();

                if (drEventos.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }

        }

    }
}
