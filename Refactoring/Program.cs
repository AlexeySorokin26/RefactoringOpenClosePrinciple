namespace Refactoring
{
    using System;
    

    class Program
    {
        static void Main(string[] args)
        {
            UsualAccount usualAcc = new UsualAccount("usual", 100.00, 10.0);
            Console.WriteLine($"interest {usualAcc.Interest} and balance {usualAcc.Balance} for {usualAcc.Type}");
            Calculator.CalculateInterest(usualAcc);
            Console.WriteLine("after");
            Console.WriteLine($"interest {usualAcc.Interest} and balance {usualAcc.Balance} for {usualAcc.Type}");

            SalaryAccount salaryAcc = new SalaryAccount("usual", 100.00, 10.0);
            Console.WriteLine($"interest {salaryAcc.Interest} and balance {salaryAcc.Balance} for {salaryAcc.Type}");
            Calculator.CalculateInterest(salaryAcc);
            Console.WriteLine("after");
            Console.WriteLine($"interest {salaryAcc.Interest} and balance {salaryAcc.Balance} for {salaryAcc.Type}");
        }
    }
}
