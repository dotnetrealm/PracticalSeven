namespace OCP.Good
{
    public class Discount
    {
        public virtual decimal GetDiscount(decimal amount)
        {
            return amount * 0.02M;
        }
    }
}
