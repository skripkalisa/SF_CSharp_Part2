using Task.Profiles;

namespace Task
{
    public class Calculator
    {
        private readonly Account _account;
        public Calculator(Account account)
        {
            _account = account;
        }

        public void Calculate(ICalculatorProfile calculatorProfile)
        {
            calculatorProfile.CalculateInterest(_account);
        }
    }
}