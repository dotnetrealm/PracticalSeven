namespace DIP.Bad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Notification notification = new();
            notification.GmailNotify();
            notification.HotMailNotify();

            Console.ReadKey();
        }

    }
}
