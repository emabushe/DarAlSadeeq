using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace DarAlSadeeq.DA
{
    public class Mail
    {
        public static bool SendEmail(string Sender, string Receipient,string Subject, string Body)
        {
            MailAddress from = new MailAddress(Sender, "Website Contact Us");
            MailAddress to = new MailAddress(Receipient);
            MailMessage message = new MailMessage(from, to);
            // message.Subject = "Using the SmtpClient class.";
            message.Subject = Subject;
            message.Body = Body;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("SMTP.webhost4life.com");
            client.Credentials= new NetworkCredential("info@daralsadeeq.com", "P@s5w0rd");
            // Include credentials if the server requires them.
            try
            {
                client.Send(message);
                return true;
            }
            catch (Exception ex)
                {
                return false;
            }
        }
    }
}