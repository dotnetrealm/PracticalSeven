namespace LSP.Good
{
    internal class CalculateGST
    {
        public virtual decimal Calculate(decimal amount) {
            return amount + (amount * 0.09M);
        }
    }
}
