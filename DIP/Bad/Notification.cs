namespace DIP.Bad
{
    public class Notification
    {
        public bool GmailNotify()
        {
            GmailService gmailService = new();
            gmailService.Send();
            return true;
        }
        public bool HotMailNotify()
        {
            HotMailService hotMailService = new();
            hotMailService.Send();
            return true;
        }
    }
}
