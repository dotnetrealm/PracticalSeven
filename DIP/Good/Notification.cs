namespace DIP.Good
{
    internal class Notification
    {
        readonly IMailService mailService;
        public Notification(IMailService mailService)
        {
            this.mailService = mailService;
        }

        public bool SendMail()
        {
            return mailService.Send();
        }
    }
}
