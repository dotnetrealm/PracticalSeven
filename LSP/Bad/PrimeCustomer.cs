namespace LSP.Bad
{
    public class PrimeCustomer : CustomerBase
    {
        public PrimeCustomer(string name, string address) : base(name, address) { }

        public override decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.15M;
        }

        public override decimal CalculatePoints(decimal amount)
        {
            return amount * 0.2M;
        }
    }
}
