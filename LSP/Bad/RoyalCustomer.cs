namespace LSP.Bad
{
    public class RoyalCustomer : CustomerBase
    {
        public RoyalCustomer(string name, string address) : base(name, address) { }

        public override decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.25M;
        }
        public override decimal CalculatePoints(decimal amount)
        {
            return amount * 0.25M;
        }
    }
}
