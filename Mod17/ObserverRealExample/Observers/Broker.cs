using System;
 
namespace ObserverRealExample.Observers
{
    /// <summary>
    /// Реализация брокера в качестве наблюдателя
    /// </summary>
    class Broker : IObserver
    {
        IObservable _stock;
 
        public Broker(IObservable obs)
        {
            _stock = obs;
            _stock.RegisterObserver(this);
        }
 
        public void Update(object o)
        {
            StockData sData = (StockData) o;
 
            if (sData.USD > 85)
                Console.WriteLine($"Брокер продает доллары  по курсу {sData.USD}");
            else
                Console.WriteLine($"Брокер покупает доллары  по курсу {sData.USD}");
        }
 
        public void StopTrade()
        {
            _stock.RemoveObserver(this);
            _stock = null;
        }
    }
}