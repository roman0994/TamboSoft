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
    public class Usuario_Datos : Conexion
    {
        public Usuario RecuperarUno(string usu,string pass)
        {
            try
            {
                Usuario usuario = new Usuario();
                this.AbrirConexion();
                SqlCommand cmdUsuario = new SqlCommand("SELECT id_usuario,usu,password,email from Usuario where usu=@usu and password=@pass", Conn);
                cmdUsuario.Parameters.Add("usu", SqlDbType.VarChar, 50).Value = usu;
                cmdUsuario.Parameters.Add("pass", SqlDbType.VarChar, 50).Value = pass;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                while (drUsuario.Read())
                {
                    usuario.Id_usuario = drUsuario.IsDBNull(0) ? Convert.ToInt32(string.Empty) : Convert.ToInt32(drUsuario["id_usuario"]);
                    usuario.Usu = drUsuario.IsDBNull(1) ? string.Empty : drUsuario["usu"].ToString();
                    usuario.Password = drUsuario.IsDBNull(2) ? string.Empty : drUsuario["password"].ToString();
                    usuario.Email = drUsuario.IsDBNull(3) ? string.Empty : drUsuario["email"].ToString();
                    
                }
                drUsuario.Close();
                return usuario;

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar usuario", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool ExisteUsuario(string user, string password)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdUsuario = new SqlCommand("SELECT id_usuario,usu,password,email from Usuario where usu=@user and password=@password", Conn);
                cmdUsuario.Parameters.Add("user", SqlDbType.VarChar, 50).Value = user;
                cmdUsuario.Parameters.Add("password", SqlDbType.VarChar, 50).Value = password;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.Read())
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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los usuarios", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool HayUsuarios()
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT id_usuario,usu,password,email from Usuario", Conn);
                SqlDataReader drUsuario = cmdUsuarios.ExecuteReader();

                if (drUsuario.Read())
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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los usuarios", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Insertar(Usuario usuario)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdInsertar = new SqlCommand("insert into Usuario(usu,password,email) values (@usu,@password,@email)", Conn);
                cmdInsertar.Parameters.Add("usu", SqlDbType.VarChar, 50).Value = usuario.Usu;
                cmdInsertar.Parameters.Add("password", SqlDbType.VarChar, 50).Value = usuario.Password ;
                cmdInsertar.Parameters.Add("email", SqlDbType.VarChar, 100).Value = usuario.Email;

                cmdInsertar.ExecuteNonQuery();

            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al insertar usuario", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public string RecuperarContraseña(string email)
        {
            try
            {
                this.AbrirConexion();
                string contraseña;
                SqlCommand cmdUsuario = new SqlCommand("SELECT id_usuario,usu,password,email from Usuario where email=@email", Conn);
                cmdUsuario.Parameters.Add("email", SqlDbType.VarChar, 100).Value = email;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Usu = drUsuario.IsDBNull(0) ? string.Empty : drUsuario["usu"].ToString();
                    usuario.Password = drUsuario.IsDBNull(1) ? string.Empty : drUsuario["password"].ToString();
                    usuario.Email = drUsuario.IsDBNull(2) ? string.Empty : drUsuario["email"].ToString();

                    return contraseña = usuario.Password;
                }
                else
                {
                    return contraseña = null;
                }
            }
            catch (SqlException sqe)
            {
                throw sqe;
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los usuarios", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool YaExisteElEmail(string email)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdUsuario = new SqlCommand("SELECT id_usuario,usu,password,email from Usuario where email=@email", Conn);
                cmdUsuario.Parameters.Add("email", SqlDbType.VarChar, 100).Value = email;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.Read())
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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los usuarios", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public bool YaExisteElUsuario(string usu)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdUsuario = new SqlCommand("SELECT id_usuario,usu,password,email from Usuario where usu=@usu", Conn);
                cmdUsuario.Parameters.Add("usu", SqlDbType.VarChar, 50).Value = usu;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.Read())
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
                Exception exepcionnueva = new Exception("Error al recuperar los datos de los usuarios", ex);
                throw exepcionnueva;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
}
