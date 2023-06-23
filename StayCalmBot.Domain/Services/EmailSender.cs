using System.Net;
using System.Net.Mail;

namespace StayCalmBot.Domain.Services
{
    public class EmailSender
    {
        private readonly string _senderEmail;
        private readonly string _senderPassword;
        private readonly string _smtpHost;
        private readonly int _smtpPort;

        public EmailSender(string senderEmail, string senderPassword, string smtpHost, int smtpPort)
        {
            _senderEmail = senderEmail;
            _senderPassword = senderPassword;
            _smtpHost = smtpHost;
            _smtpPort = smtpPort;
        }

        public void SendEmail(string recipientEmail, string subject, string body)
        {
            try
            {
                MailMessage mail = new();

                mail.From = new MailAddress(_senderEmail, "Stay Calm");
                mail.To.Add(new MailAddress(recipientEmail));

                mail.Subject = subject;
                mail.Body = body;

                SmtpClient smtpClient = new (_smtpHost, _smtpPort)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(_senderEmail, _senderPassword)
                };

                smtpClient.Send(mail);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
