namespace DIP.Good
{
    internal class HotMailService : IMailService
    {
        public bool Send()
        {
            Console.WriteLine("Hotmail: mail sent.");
            return true;
        }
    }
}
