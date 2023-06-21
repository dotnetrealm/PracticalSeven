namespace OCP.Bad
{
    public class OCPBad
    {
        public static void Main(string[] args)
        {
            Customer royalCustomer = new Customer("Bhavin", "Rajkot", CustomerType.Royal);
            Customer primeCustomer = new Customer("Vipul", "Ahmedabad", CustomerType.Prime);
            Customer regularCustomer = new Customer("Jil", "Anand", CustomerType.Regular);
            Console.WriteLine("Discount available for Royal customer is " + royalCustomer.CalculateDiscount(10000));
            Console.WriteLine("Discount available for Prime customer is " + primeCustomer.CalculateDiscount(10000));
            Console.WriteLine("Discount available for Regular customer is " + regularCustomer.CalculateDiscount(10000));
            Console.ReadKey();
        }
    }
}
