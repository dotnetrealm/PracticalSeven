namespace DIP.Good
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Notification notification = new(new GmailService());
            notification.SendMail();

            notification = new(new HotMailService());
            notification.SendMail();

            Console.ReadKey();
        }
    }
}