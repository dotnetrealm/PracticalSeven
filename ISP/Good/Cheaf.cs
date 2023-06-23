using ISP.Good.Interfaces;

namespace ISP.Good
{
    public class Cheaf : ICheaf
    {
        public void CookFood()
        {
            ICheaf cheaf = new Cheaf();
            cheaf.CutVeggies();
            Console.WriteLine("Cooking food");
            Thread.Sleep(3000);
            Console.WriteLine("Food is ready!!");
        }

        public void CutVeggies()
        {
            Console.WriteLine("Cutting Veggies");
            Thread.Sleep(2000);
        }
    }
}
