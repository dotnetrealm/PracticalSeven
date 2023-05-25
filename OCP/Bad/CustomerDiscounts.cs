namespace OCP.Bad
{
    public enum CustomerType
    {
        Prime,
        Royal,
        Regular
    };
    public class CustomerDiscounts
    {
        public decimal GetCustomerDiscount(decimal amount, CustomerType customerType)
        {
            decimal finalAmount = 0;
            if (customerType == CustomerType.Prime)
            {
                finalAmount = amount * 0.15M;
            }
            else if (customerType == CustomerType.Royal)
            {
                finalAmount = amount * 0.25M;
            }
            else if (customerType == CustomerType.Regular)
            {
                finalAmount = amount * 0.05M;
            }
            return finalAmount;
        }
    }
}
