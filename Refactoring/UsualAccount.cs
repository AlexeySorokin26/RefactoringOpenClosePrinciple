namespace Refactoring
{
    public class UsualAccount : ICalculateInterest
    {

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }

        public UsualAccount(string Type, double Balance, double Interest)
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
