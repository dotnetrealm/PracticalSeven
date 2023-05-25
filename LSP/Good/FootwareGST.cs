namespace LSP.Good
{
    internal class FootwareGST: CalculateGST
    {
        public override decimal Calculate(decimal amount)
        {
            return amount + (amount * 0.05M);
        }
    }
}
