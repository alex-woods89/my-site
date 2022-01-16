using System;
using my_site.Models;

namespace my_site.Services
{
    public interface IEmailSender
    {
        public void sendEmail(Email email);
    }
}
