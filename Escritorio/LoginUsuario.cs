﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using Datos;

namespace Escritorio
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty || string.IsNullOrWhiteSpace(txtUser.Text) || txtPass.Text == string.Empty || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Debe completar los campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario_Negocio usuarioNegocio = new Usuario_Negocio();
                Usuario usuario = new Usuario();
                bool validar = usuarioNegocio.ExisteUsuario((txtUser.Text).ToLower(),txtPass.Text);

                if (validar == true)
                {
                    usuario = usuarioNegocio.RecuperarUno(txtUser.Text.ToLower(),txtPass.Text);

                    MessageBox.Show("Ingreso correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTablas cargarTablas = new CargarTablas();
                    Tambo_Negocio tamboNegocio = new Tambo_Negocio();
                    if (tamboNegocio.HayTambos(usuario.Id_usuario))
                    {
                        cargarTablas.CargaTablasData();
                        Login login = new Login();
                        login.id_usuario = usuario.Id_usuario;
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        cargarTablas.CargaTablasData();
                        LoginAltaTambos loginAltaTambos = new LoginAltaTambos();
                        loginAltaTambos.id_usuario = usuario.Id_usuario;
                        loginAltaTambos.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña no existen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Si ingresó correctamente, seguir con esto
            /*CargarTablas cargarTablas = new CargarTablas();
            Tambo_Negocio tamboNegocio = new Tambo_Negocio();
            if (tamboNegocio.HayTambos())
            {
                cargarTablas.CargaTablasData();
                Application.Run(new Login());
            }
            else
            {
                cargarTablas.CargaTablasData();
                Application.Run(new LoginAltaTambos());
            }*/
        }

        private void lnkOlvidePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña recuperar = new RecuperarContraseña();
            recuperar.Show();
        }

        private void lnkNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AltaUsuarios altaUsuarios = new AltaUsuarios();
            altaUsuarios.Show();
            this.Hide();
        }
    }
}