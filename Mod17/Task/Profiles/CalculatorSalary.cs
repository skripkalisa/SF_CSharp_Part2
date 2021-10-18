namespace Task.Profiles
{
    public  class CalculatorSalary : ICalculatorProfile
    { 
        // Метод для расчета процентной ставки
        public void CalculateInterest(Account account) 
        {
            account.Interest += account.Balance * 0.5;
        }
    } 
}