namespace OCP.Bad
{
    public class OCPBad
    {
        static void Main(string[] args)
        {
            CustomerDiscounts customerDiscounts = new CustomerDiscounts();
            Console.WriteLine("Discount available for Regular customer is " + customerDiscounts.GetCustomerDiscount(12000, CustomerType.Prime));
            Console.WriteLine("Discount available for Regular customer is " + customerDiscounts.GetCustomerDiscount(12000, CustomerType.Regular));
            Console.ReadKey();
        }
    }
}
