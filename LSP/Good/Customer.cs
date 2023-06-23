using LSP.Good.Interfaces;

namespace LSP.Good
{
    public abstract class CustomerBase : ICustomer, ICustomerDiscount
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Point { get; set; }

        protected CustomerBase(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
            this.Point = 5;
        }

        public abstract decimal CalculateDiscount(decimal amount);

        public virtual int CalculatePoints(decimal amount)
        {
            return Convert.ToInt32(amount * 0.1M);
        }
    }
}
