namespace DIP.Good
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new(new GmailService());
            notification.SendMail();

            notification = new(new HotMailService());
            notification.SendMail();

            Console.ReadKey();
        }
    }
}