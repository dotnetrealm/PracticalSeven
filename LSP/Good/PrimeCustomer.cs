namespace LSP.Good
{
    public class PrimeCustomer : CustomerBase
    {
        public PrimeCustomer(string name, string address) : base(name, address) { }

        public override decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.15M;
        }

        public override int CalculatePoints(decimal amount)
        {
            return Convert.ToInt32(amount * 0.2M);
        }
    }
}
