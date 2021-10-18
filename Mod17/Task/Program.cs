using System;
using Task.Profiles;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Предпололжим что эти данные берём из базы.
            Account account1 = new Account
            {
                Type = "Обычный",
                Balance = 10000,
                Interest = 0
            };
            
            Account account2 = new Account
            {
                Type = "Зарплатный",
                Balance = 20000,
                Interest = 0
            };

            PrintAccountInterest(account1);
            PrintAccountInterest(account2);
        }

        private static void PrintAccountInterest(Account account)
        {
            var calculator = new Calculator(account);
            if (account.Type == "Обычный")
            {
                calculator.Calculate(new CalculatorGeneral());
            }
            else
            {
                calculator.Calculate(new CalculatorSalary());
            }
            Console.WriteLine( $"Account type: {account.Type}\n" +
                               $"Incoming balance: {account.Balance}\n" +
                               $"Account interest: {account.Interest}\n" +
                               $"Total Balance: {account.Balance + account.Interest}\n"
            );
        }
    }
}