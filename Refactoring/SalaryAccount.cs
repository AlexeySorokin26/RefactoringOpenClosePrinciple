namespace Refactoring
{
    public class SalaryAccount : ICalculateInterest
    {
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }

        public SalaryAccount(string Type, double Balance, double Interest)
        {
            this.Type = Type;
            this.Balance = Balance;
            this.Interest = Interest;
        }
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
    }
}
