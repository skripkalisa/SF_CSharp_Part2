namespace Task.Profiles
{
    public class CalculatorGeneral : ICalculatorProfile
    { 
        // Метод для расчета процентной ставки
        public void CalculateInterest(Account account) 
        { 
            if (account.Balance < 1000)
                account.Interest += account.Balance * 0.2;
            
            else if (account.Balance < 50000)
                account.Interest += account.Balance * 0.4;
        }
    }
}