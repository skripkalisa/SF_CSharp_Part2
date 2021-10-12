using System;
 
namespace ObserverRealExample.Observers
{
    /// <summary>
    /// Реализация банка в качестве наблюдателя
    /// </summary>
    class Bank : IObserver
    {
        readonly IObservable _stock;
        public Bank(IObservable obs)
        {
            _stock = obs;
            _stock.RegisterObserver(this);
        }
      
        public void Update(object o)
        {
            StockData sData = (StockData)o;
   
            if (sData.Euro > 85)
                Console.WriteLine($"Банк продает евро по курсу {sData.Euro}");
            else
                Console.WriteLine($"Банк покупает евро по курсу {sData.Euro}");
        }
    }
}