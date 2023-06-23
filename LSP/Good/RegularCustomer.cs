using LSP.Good.Interfaces;

namespace LSP.Good
{
    public class RegularCustomer : ICustomer
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Point { get; set; }

        public RegularCustomer(string name, string address)
        {
            Name = name;
            Address = address;
            Point = 5;
        }
        public int CalculatePoints(decimal amount)
        {
            return Convert.ToInt32(amount * 0.15M);
        }
    }
}
