using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Entidades;
using Negocio;

namespace Escritorio
{
    public partial class AltaUsuarios : Form
    {
        Usuario_Negocio usuarioNegocio = new Usuario_Negocio();
        public AltaUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validar = validaciones.ValidarCargaUsuarios(txtUsuario.Text, txtPass.Text, txtRepitePass.Text, txtEmail.Text);
            

            if (validar == true)
            {
                bool validaremail = validaciones.ValidarEmail(txtEmail.Text);

                if (txtUsuario.Text.Length >= 8)
                {
                    if (txtUsuario.Text.Length <= 20)
                    {
                        if (txtPass.Text.Length >= 8)
                        {
                            if (txtPass.Text.Length <= 20)
                            {
                                if (txtPass.Text == txtRepitePass.Text)
                                {
                                    if (validaremail == true)
                                    {
                                        if (usuarioNegocio.YaExisteElUsuario(txtUsuario.Text)==false)
                                        {
                                            if (usuarioNegocio.YaExisteElEmail(txtEmail.Text) == false)
                                            {
                                                Usuario_Negocio usuarioNegocio = new Usuario_Negocio();
                                                Usuario usuario = new Usuario();
                                                usuario = MapearAUsuario();
                                                usuarioNegocio.Insertar(usuario);
                                                MessageBox.Show("El usuario fue dado de alta exitosamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                LoginUsuario login = new LoginUsuario();
                                                login.Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya existe una cuenta asociada a este Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ya existe el nombre de usuario. Intente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo Email no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El valor del campo Contraseña no puede ser mayor a 20 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El valor del campo Contraseña no puede ser menor a 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del campo Usuario no puede ser mayor a 20 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El valor del campo Usuario no puede ser menor a 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos vacíos", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Usuario MapearAUsuario()
        {
            Usuario usuario = new Usuario();

            usuario.Usu = txtUsuario.Text.ToLower();
            usuario.Password = txtPass.Text;
            usuario.Email = txtEmail.Text;

            return usuario;
        }
    }
}
