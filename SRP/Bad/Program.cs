namespace SRP.Bad
{
    public class SRPBad
    {
        public static void Main(string[] args)
        {
            UserService userService = new UserService();
            userService.RegisterUser("Bhavin", "bhavin.kareliya2017@gmail.com");
            Console.ReadLine();
        }
    }
}