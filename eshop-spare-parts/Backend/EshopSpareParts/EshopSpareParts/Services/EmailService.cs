using EshopSpareParts.Models.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace EshopSpareParts.Services
{
    public class EmailService : IDisposable
    {
        string destination;
        bool _disposed = true;
        string host = "smtp.forpsi.com";
        string fromAddress = "postmaster@amadeodecay.com";
        string displayName = "Usti nahradni dily!";
        string password = "NLU9XBL6!3";

        public EmailService(string destination)
        {
            this.destination = destination;

        }
        public void SendEmail(OrderDto order)
        {
            SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("mailSettings/order");

            String renderedHTML = Controllers.EmailController.RenderViewToString("Email", "Order", order);

            SmtpClient smtp = new SmtpClient(smtpSection.Network.Host, smtpSection.Network.Port);
            smtp.Credentials = new NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password);

            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            string body = renderedHTML;

            using (var message = new MailMessage("objednavky@ndusti.cz", destination))
            {
                message.Subject = "Potvrzení objednávky";
                message.Body = body;
                message.IsBodyHtml = true;
                smtp.Send(message);
            }
        }
        public void SendQuestionEmail(QuestionDto question)
        {

            SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("mailSettings/info");


            String renderedHTML = Controllers.EmailController.RenderViewToString("Email", "Question", question);

            SmtpClient smtp = new SmtpClient(smtpSection.Network.Host, smtpSection.Network.Port);

            smtp.Host = smtpSection.Network.Host;
            smtp.Port = smtpSection.Network.Port;
            smtp.UseDefaultCredentials = smtpSection.Network.DefaultCredentials;
            smtp.Credentials = new NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password, smtpSection.Network.ClientDomain);
            smtp.EnableSsl = smtpSection.Network.EnableSsl;

            if (smtpSection.Network.TargetName != null)
                smtp.TargetName = smtpSection.Network.TargetName;


            string body = renderedHTML;

            using (var message = new MailMessage(destination, destination))
            {
                message.Subject = "Test" + " | " + question.email;
                message.Body = body;
                message.IsBodyHtml = true;
                smtp.Send(message);
            }
        }

        public async Task Send(string body, string subject)
        {
            using (SmtpClient smtp = new SmtpClient(host, 587))
            {
                smtp.Credentials = new System.Net.NetworkCredential(fromAddress, password);
                smtp.EnableSsl = true;

                using (var m = new MailMessage(fromAddress, destination))
                {
                    m.From = new MailAddress(fromAddress, displayName);
                    m.Subject = subject;
                    m.Body = body;
                    m.IsBodyHtml = true;

                    await smtp.SendMailAsync(m);
                }
            }
        }
        public async Task Send(string body, string subject, OrderDto order)
        {
            using (SmtpClient smtp = new SmtpClient(host, 587))
            {
                smtp.Credentials = new System.Net.NetworkCredential(fromAddress, password);
                smtp.EnableSsl = true;

                using (var m = new MailMessage(fromAddress, destination))
                {
                    m.From = new MailAddress(fromAddress, displayName);
                    m.Subject = subject;
                    m.Body = body;
                    m.IsBodyHtml = true;

                    await smtp.SendMailAsync(m);
                }
            }
        }
        public async Task Send(string body, string subject, string filePath)
        {
            using (SmtpClient smtp = new SmtpClient(host, 587))
            {
                smtp.Credentials = new System.Net.NetworkCredential(fromAddress, password);
                smtp.EnableSsl = true;

                using (var m = new MailMessage(fromAddress, destination))
                {
                    m.From = new MailAddress(fromAddress, displayName);
                    m.Subject = subject;
                    m.Body = body;
                    m.IsBodyHtml = true;
                    m.Attachments.Add(new Attachment(filePath));
                    
                    await smtp.SendMailAsync(m);
                }
            }
        }
        public async Task Send(string body, string subject, List<string> filePath)
        {
            using (SmtpClient smtp = new SmtpClient(host, 587))
            {
                smtp.Credentials = new System.Net.NetworkCredential(fromAddress, password);
                smtp.EnableSsl = true;

                using (var m = new MailMessage(fromAddress, destination))
                {
                    m.From = new MailAddress(fromAddress, displayName);
                    m.Subject = subject;
                    m.Body = body;
                    m.IsBodyHtml = true;
                    foreach(var item in filePath)
                    {
                        System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(item);
                        attachment.Name = Path.GetFileName(item); 
                        m.Attachments.Add(attachment);
                    }
                    await smtp.SendMailAsync(m);
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    destination = string.Empty;
                }

                _disposed = true;
            }
        }
    }
}