using SRP.Models;

namespace SRP.Good
{
    public class UserService
    {
        readonly MailService _mailService = new MailService();
        readonly List<User> _users = new List<User>();
        public User RegisterUser(string name, string email)
        {
            User user = new User();
            user.Email = email;
            user.Name = name;
            user.Id = Guid.NewGuid();
            _users.Add(user);

            MailMessage mailMessage = new MailMessage();
            mailMessage.Subject = "Greeting";
            mailMessage.Message = "Hello, Greetings of the day!";
            mailMessage.To = email;
            _mailService.SendMail(mailMessage);

            return user;
        }
    }
}