namespace ISP.Bad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Waiter waiter = new();
            waiter.ServeCustomer();
            waiter.CookFood();

            Console.ReadKey();
        }
    }
}
