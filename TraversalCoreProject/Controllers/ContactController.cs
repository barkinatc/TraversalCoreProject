using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MimeKit;
using Project.Business.Abstract;
using Project.ENTITIES.Concrete;
using Project.VM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;
        private readonly IOptions<SendMailToUsVM> _emailConfig;

        public ContactController(IOptions<SendMailToUsVM> emailConfig, IContactService contactService)
        {
            _emailConfig = emailConfig;
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SuccessMail()
        {
            return View();
        }

        public IActionResult SendMail(SendMailToUsVM p)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress(p.Name, _emailConfig.Value.MailSender);
            mimeMessage.From.Add(mailboxAddressFrom);


            MailboxAddress mailboxAddressTo = new MailboxAddress("User", "brknatici@hotmail.com");
            mimeMessage.To.Add(mailboxAddressTo);
            mimeMessage.Body = new TextPart("plain")
            {
                Text = p.Body
            };

            mimeMessage.Subject = p.Subject;
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect(_emailConfig.Value.SmtpServer, _emailConfig.Value.SmtpPort, SecureSocketOptions.StartTls);
                client.Authenticate(_emailConfig.Value.MailSender, _emailConfig.Value.Password);
                client.Send(mimeMessage);
                client.Disconnect(true);
            }
            Contact contact = new Contact
            {
                Body = p.Body,
                Mail = p.UserMail,
                Subject = p.Subject,
                Name = p.Name
            };
            _contactService.TAdd(contact);
            return RedirectToAction("SuccessMail");
        }
    }
}
