using SRP.Models;

namespace SRP.Bad
{
    public class UserService
    {
        public User RegisterUser(string name, string email)
        {
            User user = new User();
            user.Email = email;
            user.Name = name;
            user.Id = Guid.NewGuid();

            MailMessage message = new MailMessage();
            message.Subject = "Greetings";
            message.Message = "Hello, Greetings of the day!";
            message.To = "Test@gmail.com";

            SendMail(message);
            return user;
        }

        public static void SendMail(MailMessage mailMessage)
        {
            Console.WriteLine($"Mail sent to {mailMessage.To} on {DateTime.Now.ToShortTimeString()} with message: {mailMessage.Message}");
        }
    }
}