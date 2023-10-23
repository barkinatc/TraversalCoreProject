namespace TraversalCoreProject.Areas.Admin.Models
{
    public class MailRequestVM
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
