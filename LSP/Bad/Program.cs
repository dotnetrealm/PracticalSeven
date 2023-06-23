namespace LSP.Bad
{
    public class LSPBad
    {
        public static void Main(string[] args)
        {
            CustomerBase royalcustomer = new RoyalCustomer("Bhavin", "Rajkot");
            CustomerBase primeCustomer = new PrimeCustomer("Vipul", "Ahmedabad");
            CustomerBase regularCustomer = new RegularCustomer("Jil", "Anand");

            Console.WriteLine("Discount available for Royal customer is " + royalcustomer.CalculateDiscount(10000));
            Console.WriteLine("Discount available for Prime customer is " + primeCustomer.CalculateDiscount(10000));
            Console.WriteLine("Discount available for Regular customer is " + regularCustomer.CalculateDiscount(10000));

            Console.ReadKey();
        }
    }
}