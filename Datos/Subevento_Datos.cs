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
    public class Subevento_Datos : Conexion
    {
        public bool HaySubeventos()
        {
            this.AbrirConexion();
            SqlCommand cmsSubevento = new SqlCommand("select id_subevento,nombre_subevento,estado_subevento from Subevento", Conn);
            SqlDataReader drSubevento = cmsSubevento.ExecuteReader();

            if (drSubevento.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar(Subevento subevento)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Subevento(nombre_subevento,estado_subevento) values (@nombre_subevento,@estado_subevento)", Conn);
               
                cmdInsertar.Parameters.Add("nombre_subevento", SqlDbType.VarChar, 50).Value = subevento.Nombre_subevento;
                cmdInsertar.Parameters.Add("estado_subevento", SqlDbType.Bit).Value = subevento.Estado_subevento;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar subevento", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
