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
using Negocio;
using System.Net.Mail;

namespace Escritorio
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            bool validaremail = validaciones.ValidarEmail(txtEmail.Text);

            if(validaremail == true)
            { 
                Usuario_Negocio usuarioNegocio = new Usuario_Negocio();
                string pass = usuarioNegocio.RecuperarContraseña(txtEmail.Text);
                if (pass != null)
                {
                    EnviarEmail(txtEmail.Text, pass);
                }
                else
                {
                    MessageBox.Show("El Mail indicado no está registrado. Intente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo Email no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EnviarEmail(string email, string pass)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(new MailAddress(email));
            mail.From = new MailAddress("romanbressan1@gmail.com");
            mail.Subject = "Reestablecimiento de contraseña";
            mail.Body = "Su contraseña del sistema TamboSoft es: "+ pass;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("romanbressan1@gmail.com", "televisor2");

            try
            {
                smtp.Send(mail);
                mail.Dispose();
                MessageBox.Show("El correo electrónico fue enviado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Exception exepcionnueva = new Exception("Error al enviar correo electrónico", ex);
                MessageBox.Show("Error al enviar correo electrónico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw exepcionnueva;
            }
        }
    }
}
