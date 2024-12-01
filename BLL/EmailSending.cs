using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmailSending
    {
        public void MandarGmail(string gmail, string subject, string body)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("taskmaster3751@gmail.com");
                mensaje.To.Add(new MailAddress(gmail));
                mensaje.Subject = subject;
                mensaje.Body = body;

                mensaje.IsBodyHtml = true;

                var SmtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("taskmaster3751@gmail.com", "qqhf vgbq qhpf qfzm"),
                    EnableSsl = true,

                };

                SmtpClient.Send(mensaje);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
