namespace LSP.Good.Interfaces
{
    internal interface ICustomer
    {
        string Name { get; set; }
        string Address { get; set; }
        int Point { get; set; }

        /// <summary>
        /// Calculate loyalty point base on purchase amount
        /// </summary>
        /// <param name="amount">invoice amount</param>
        /// <returns>loyalty point given on invoice amount(According to customer type it will change like for regular it's 10%, for Prime it's 20%, etc..)</returns>
        int CalculatePoints(decimal amount);

    }
}
