// ПРАКТИКА
//
// Напишите свой вариант рефакторинга кода из задания 4
// в соответствии с Принципом открытости-закрытости.

using System;

namespace Task
{
    public class Account
    {
        // тип учетной записи
        public string Type { get; set; }
  
        // баланс учетной записи
        public double Balance { get; set; }
  
        // процентная ставка
        public double Interest { get; set; }
    }
    
    public static class Calculator 
    { 
        // Метод для расчета процентной ставки
        public static void CalculateInterest(Account account) 
        { 
            if (account.Type == "Обычный") 
            { 
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;
 
                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;
              
                if (account.Balance < 50000)
                    account.Interest -= account.Balance * 0.4;
            } 
            else if(account.Type == "Зарплатный") 
            { 
                // расчет процентной ставк зарплатного аккаунта по правилам банка
                account.Interest = account.Balance * 0.5;
            } 
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            account1.Type = "Обычный";
            account1.Balance = 10000;
            account1.Interest = 4.5;            
            Account account2 = new Account();
            account2.Type = "Зарплатный";
            account2.Balance = 20000;
            account2.Interest = 7.75;

            Calculator.CalculateInterest(account1);
            Console.WriteLine(account1.Interest);
            Calculator.CalculateInterest(account2);
            Console.WriteLine(account2.Interest);

        }
    }
}