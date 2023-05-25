namespace DIP.Good
{
    internal class GmailService : IMailService
    {
        public bool Send()
        {
            Console.WriteLine("Gmail: mail sent");
            return true;
        }
    }
}
