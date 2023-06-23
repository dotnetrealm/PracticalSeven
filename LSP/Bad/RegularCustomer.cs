namespace LSP.Bad
{
    public class RegularCustomer : CustomerBase
    {
        public RegularCustomer(string name, string address) : base(name, address) { }


        //Suppose here regular customer is not applicable for the discount 
        //then also we have to override this method and changing behaviour of method
        //like instead of return decimal it'll throw exception so here it broke this LSP principle
        public override decimal CalculateDiscount(decimal amount)
        {
            throw new NotImplementedException("regular customer is not applicable for discount");
        }
        public override decimal CalculatePoints(decimal amount)
        {
            return amount * 0.15M;
        }
    }
}
