using ISP.Good.Interfaces;

namespace ISP.Good
{
    public class Waiter : IWaiter
    {
        public void ServeCustomer()
        {
            Console.WriteLine("Serving customers");
        }
    }
}
