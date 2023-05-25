namespace DIP.Bad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new();
            notification.GmailNotify();
            notification.HotMailNotify();

            Console.ReadKey();
        }

    }
}
