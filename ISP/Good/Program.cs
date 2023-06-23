namespace ISP.Good
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cheaf cheaf = new();
            cheaf.CookFood();

            Waiter waiter = new Waiter();
            waiter.ServeCustomer();

            Console.ReadKey();
        }
    }
}