using LSP.Good.Interfaces;

namespace LSP.Good
{
    internal class LSPGood
    {
        static void Main(string[] args)
        {
            CustomerBase royalcustomer = new RoyalCustomer("Bhavin", "Rajkot");
            CustomerBase primeCustomer = new PrimeCustomer("Vipul", "Ahmedabad");
            ICustomer regularCustomer = new RegularCustomer("Jil", "Anand");

            Console.WriteLine("Discount available for Royal customer is " + royalcustomer.CalculateDiscount(10000));
            Console.WriteLine("Discount available for Prime customer is " + primeCustomer.CalculateDiscount(10000));
            Console.WriteLine("Point available for Regular customer is " + regularCustomer.CalculatePoints(10000));

            Console.ReadKey();
        }
    }
}