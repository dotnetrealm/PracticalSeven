namespace OCP.Good
{
    public class RegularCustomer : Discount
    {
        public override decimal GetDiscount(decimal amount)
        {
            return amount * 0.05M;
        }
    }
}
