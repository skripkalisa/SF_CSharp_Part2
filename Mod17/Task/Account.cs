namespace Task
{
    public class Account
    {
        // тип учетной записи
        public string Type { get; set; }
  
        // баланс учетной записи
        public double Balance { get; init; }
  
        // процентная ставка
        public double Interest { get; set; }
    }
}