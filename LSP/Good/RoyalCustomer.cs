namespace LSP.Good
{
    public class RoyalCustomer : CustomerBase
    {
        public RoyalCustomer(string name, string address) : base(name, address) { }

        public override decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.25M;
        }
        public override int CalculatePoints(decimal amount)
        {
            return Convert.ToInt32(amount * 0.25M);
        }
    }
}
