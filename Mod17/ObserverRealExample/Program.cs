using ObserverRealExample.Observers;

namespace ObserverRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
          
            var bank = new Bank(stock);
            var broker = new Broker(stock);
          
            // имитация торгов
            stock.Market();
            // брокер прекращает наблюдать за торгами
            broker.StopTrade();
            // имитация торгов
            stock.Market();
        }
    }
}