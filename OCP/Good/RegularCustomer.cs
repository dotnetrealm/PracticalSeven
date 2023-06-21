namespace OCP.Good
{
    public class RegularCustomer : Customer
    {
        public RegularCustomer(string name, string address) : base(name, address) { }
        public override decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.05M;
        }
    }
}
