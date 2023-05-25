namespace OCP.Good
{
    internal class OCPGood
    {
        static void Main(string[] args)
        {
            PrimeCustomer primeCustomer = new PrimeCustomer();
            Console.WriteLine("Discount available for Prime customer is " + primeCustomer.GetDiscount(12000));

            RegularCustomer regularCustomer = new RegularCustomer();
            Console.WriteLine("Discount available for Regular customer is " + regularCustomer.GetDiscount(12000));

            Console.ReadKey();
        }
    }
}