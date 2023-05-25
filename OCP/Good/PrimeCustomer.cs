namespace OCP.Good
{
    public class PrimeCustomer : Discount
    {
        public override decimal GetDiscount(decimal amount)
        {
            return amount * 0.15M;
        }
    }
}
