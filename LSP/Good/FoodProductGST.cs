namespace LSP.Good
{
    internal class FoodProductGST : CalculateGST
    {
        public override decimal Calculate(decimal amount)
        {
            return amount + (amount * 0.18M);

        }
    }
}
