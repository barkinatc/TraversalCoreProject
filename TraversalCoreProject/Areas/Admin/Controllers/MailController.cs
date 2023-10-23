using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MimeKit;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        private readonly IOptions<MailRequestVM> _emailConfig;

        public MailController(IOptions<MailRequestVM> emailConfig)
        {
            _emailConfig = emailConfig;
        }
        [HttpGet]
        public IActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMail(MailRequestVM p)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress(p.Name, _emailConfig.Value.MailSender);
            mimeMessage.From.Add(mailboxAddressFrom);


            MailboxAddress mailboxAddressTo = new MailboxAddress("User", p.MailReceiver);
            mimeMessage.To.Add(mailboxAddressTo);
            mimeMessage.Body = new TextPart("plain")
            {
                Text = p.Body
            };

            mimeMessage.Subject = p.Subject;
            SmtpClient client = new SmtpClient();

            client.Connect(_emailConfig.Value.SmtpServer, _emailConfig.Value.SmtpPort, SecureSocketOptions.StartTls);
            client.Authenticate(_emailConfig.Value.MailSender, _emailConfig.Value.Password);

            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
