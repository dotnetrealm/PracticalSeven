namespace OCP.Good
{
    public class RoyalCustomer : Customer
    {
        public RoyalCustomer(string name, string address) : base(name, address) { }
        public override decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.25M;
        }
    }
}
