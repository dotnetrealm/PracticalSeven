namespace ISP.Good
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cheaf cheaf = new();
            cheaf.CookFood();

            Waiter waiter = new Waiter();
            waiter.ServeCustomer();

            Console.ReadKey();
        }
    }
}