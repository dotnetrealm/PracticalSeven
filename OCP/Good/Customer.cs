namespace OCP.Good
{
    public abstract class Customer
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;

        public Customer() { }

        public Customer(string name, string address) { 
            this.Name = name;
            this.Address = address; 
        }

        // Here we make this method to close for modification,
        // and each time we create new class and extend override this method
        public abstract decimal CalculateDiscount(decimal amount);
    }
}
