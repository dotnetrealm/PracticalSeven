namespace LSP.Bad
{
    public abstract class CustomerBase
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;

        public int Point { get; set; }

        public CustomerBase(string name, string address)
        {
            Name = name;
            Address = address;
            Point = 5;
        }

        // Here we make this method to close for modification,
        // and each time we create new class and extend override this method
        /// <summary>
        /// Calculate discount on final amount base on customer subscription
        /// </summary>
        /// <param name="amount">invoice amount</param>
        /// <returns>discount on given amount</returns>
        public abstract decimal CalculateDiscount(decimal amount);

        /// <summary>
        /// Calculate loyalty point base on purchase amount
        /// </summary>
        /// <param name="amount">invoice amount</param>
        /// <returns>loyalty point given on invoice amount(According to customer type it will change like for regular it's 10%, for Prime it's 20%, etc..)</returns>
        public virtual decimal CalculatePoints(decimal amount)
        {
            return amount * 0.1M;
        }
    }
}
