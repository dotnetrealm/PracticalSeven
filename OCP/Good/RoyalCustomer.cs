namespace OCP.Good
{
    public class RoyalCustomer : Discount
    {
        public override decimal GetDiscount(decimal amount)
        {
            return amount * 0.25M;
        }
    }
}
