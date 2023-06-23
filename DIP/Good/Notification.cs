namespace DIP.Good
{
    public class Notification
    {
        readonly IMailService _mailService;
        public Notification(IMailService mailService)
        {
            this._mailService = mailService;
        }

        public bool SendMail()
        {
            return _mailService.Send();
        }
    }
}
