using Microsoft.AspNetCore.Mvc;
using my_site.Models;
using my_site.Services;

namespace my_site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private IEmailSender _emailSender;

        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public void SendEmail(Email email)
        {
            _emailSender.sendEmail(email);
        }
    }
}
