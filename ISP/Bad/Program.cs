namespace ISP.Bad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new();
            waiter.ServeCustomer();
            waiter.CookFood();

            Console.ReadKey();
        }
    }
}
