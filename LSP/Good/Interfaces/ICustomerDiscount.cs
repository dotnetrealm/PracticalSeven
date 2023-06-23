namespace LSP.Good.Interfaces
{
    public interface ICustomerDiscount
    {
        /// <summary>
        /// Calculate discount on given amount base on customer subscription
        /// </summary>
        /// <param name="amount">invoice amount</param>
        /// <returns>discount on given amount</returns>
        decimal CalculateDiscount(decimal amount);
    }
}
