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
    public class Evento_Subevento_Datos : Conexion
    {
        public bool HayEventos_Subeventos()
        {
            this.AbrirConexion();
            SqlCommand cmdEventoSubevento = new SqlCommand("select id_evento,id_subevento from Evento_Subevento", Conn);
            SqlDataReader drEventoSubevento = cmdEventoSubevento.ExecuteReader();

            if (drEventoSubevento.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar(Evento_Subevento evento_Subevento)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Evento_Subevento(id_evento,id_subevento) values (@id_evento,@id_subevento)", Conn);
                cmdInsertar.Parameters.Add("id_evento", SqlDbType.Int).Value = evento_Subevento.Id_evento;
                cmdInsertar.Parameters.Add("id_subevento", SqlDbType.Int).Value = evento_Subevento.Id_subevento ;
                
                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar evento subevento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
