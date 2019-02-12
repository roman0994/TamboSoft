using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private SqlConnection _Conn;

        public SqlConnection Conn
        {
            get { return _Conn; }
            set { _Conn = value; }
        }

        const string consKeyDefaultCnnString = "ConnStringLocal";

        protected void AbrirConexion()
        {
            Conn = new SqlConnection();
            Conn.ConnectionString = "data source=DESKTOP-NTVG4HI\\SQLEXPRESS; initial catalog=tambosoft1.0; integrated security=true; UID=; password=;";
            Conn.Open();
        }

        protected void CerrarConexion()
        {

            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn = null;
            }

        }
    }
}
