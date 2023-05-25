namespace LSP.Good
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CalculateGST calculateGST = new CalculateGST();
            calculateGST.Calculate(2000);
            Console.WriteLine("You have to pay " + calculateGST.Calculate(2000) + " on order of 2000");

            calculateGST = new FoodProductGST();
            calculateGST.Calculate(10000);
            Console.WriteLine("You have to pay " + calculateGST.Calculate(10000) + " on Food order of 10000");

            calculateGST = new FootwareGST();
            Console.WriteLine("You have to pay " + calculateGST.Calculate(25000) + " on Footware order of 25000");

            Console.ReadLine();

        }
    }
}
