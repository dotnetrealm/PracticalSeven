using SRP.Models;

namespace SRP.Good
{
    public class MailService
    {
        public void SendMail(MailMessage message)
        {
            Console.WriteLine("Mail sent to  on " + DateTime.Now.ToShortTimeString() +" with message:\n\n " + message.Message);
        }
    }
   
}
