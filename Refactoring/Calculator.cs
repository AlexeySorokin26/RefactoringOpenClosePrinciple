namespace Refactoring
{
    public static class Calculator
    {
        public static void CalculateInterest(ICalculateInterest account)
        {
            account.CalculateInterest();
        }
    }
}
