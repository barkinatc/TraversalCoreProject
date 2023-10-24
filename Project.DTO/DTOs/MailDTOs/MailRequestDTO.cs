using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.DTOs.MailDTOs
{
   public class MailRequestDTO
    {
        public string Name { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string MailSender { get; set; }
        public string Password { get; set; }
        public string Body { get; set; }
        public string MailReceiver { get; set; }
        public string Subject { get; set; }
    }
}
