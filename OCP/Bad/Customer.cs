namespace OCP.Bad
{
    public enum CustomerType
    {
        Prime,
        Royal,
        Regular
    };
    public class Customer
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public CustomerType Type { get; set; }
        public Customer(string name, string address, CustomerType customerType)
        {
            this.Name = name;
            this.Address = address;
            this.Type = customerType;
        }

        // Here each time we updating this method if any new customertype is added,
        // so it's break the rule of OCP principle
        /// <summary>
        /// Calculate discount on final amount base on customer subscription
        /// </summary>
        /// <param name="amount">invoice amount</param>
        /// <returns>discount on given amount</returns>
        public decimal CalculateDiscount(decimal amount)
        {
            if (this.Type == CustomerType.Royal) {
                return amount * 0.25M;
            } else if (this.Type == CustomerType.Prime) {
                return amount * 0.15M;
            } else if (this.Type == CustomerType.Regular) {
                return amount * 0.05M;
            } else { return amount; }
        }
    }

}
