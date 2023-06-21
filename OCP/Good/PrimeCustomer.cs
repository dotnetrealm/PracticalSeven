namespace OCP.Good
{
    public class PrimeCustomer : Customer
    {
        public PrimeCustomer(string name, string address) : base(name, address) { }
        public override decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.15M;
        }
    }
}
