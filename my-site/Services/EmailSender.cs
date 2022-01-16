using System;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using my_site.Models;

namespace my_site.Services
{
    public class EmailSender : IEmailSender
    {
        private ConfigHelper configHelper = new ConfigHelper();

        public void sendEmail(Email email)
        {
            var config = configHelper.configuration.GetSection("EmailSettings");

            email.recipientsName = config.GetValue<string>("recipientsName");
            email.recipientsEmailAddress = config.GetValue<string>("recipientsEmailAddress");
            email.host = config.GetValue<string>("host");
            email.port = config.GetValue<int>("port");
            email.useSSL = config.GetValue<bool>("useSSL");
            email.username = config.GetValue<string>("username");
            email.password = config.GetValue<string>("password");

            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress(email.sendersName, email.sendersEmailAddress));
            message.To.Add(new MailboxAddress(email.recipientsName, email.recipientsEmailAddress));
            message.Subject = email.subject;

            message.Body = new TextPart()
            {
                Text = email.emailBody
            };

            using(var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect(email.host, email.port, email.useSSL);
                client.Authenticate(email.username, email.password);
                client.Send(message);
                client.Disconnect(true);
            }

        }
    }
}
