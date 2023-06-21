namespace OCP.Good
{
    internal class OCPGood
    {
        static void Main(string[] args)
        {
            Customer royalcustomer = new RoyalCustomer("Bhavin","Rajkot");
            Customer primeCustomer = new PrimeCustomer("Vipul", "Ahmedabad");
            Customer regularCustomer = new RegularCustomer("Jil", "Anand");

            Console.WriteLine("Discount available for Royal customer is " + royalcustomer.CalculateDiscount(10000));
            Console.WriteLine("Discount available for Prime customer is " + primeCustomer.CalculateDiscount(10000));
            Console.WriteLine("Discount available for Regular customer is " + regularCustomer.CalculateDiscount(10000));

            Console.ReadKey();
        }
    }
}