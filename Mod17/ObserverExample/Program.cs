using System;
using System.Collections.Generic;

namespace ObserverExample
{
    
       /// <summary>
   /// Представляет объект - источник событий
   /// ( Иначе говоря, наблюдаемый объект )
   /// </summary>
   interface IPublisher
   {
       void AddSubscriber(ISubscriber sub);
       void RemoveSubscriber(ISubscriber o);
       void Publish();
   }
  
   /// <summary>
   /// Конкретная реализация источника событий
   /// ( наблюдаемого объекта )
   /// </summary>
   class ConcretePublisher : IPublisher
   {
       private List<ISubscriber> subscribers;
      
       public ConcretePublisher()
       {
           subscribers = new List<ISubscriber>();
       }
       public void AddSubscriber(ISubscriber sub)
       {
           subscribers.Add(sub);
       }
       public void RemoveSubscriber(ISubscriber o)
       {
           subscribers.Remove(o);
       }
       public void Publish()
       {
           foreach (ISubscriber subscriber in subscribers)
               subscriber.Update();
       }
   }
  
   /// <summary>
   /// Тот, кто подписан на события, наблюдаемого объекта
   /// ( иначе говоря, наблюдатель )
   /// </summary>
   interface ISubscriber
   {
       void Update();
   }
  
   /// <summary>
   /// Конкретная реализация наблюдателя
   /// </summary>
   class ConcreteSubscriber :ISubscriber
   {
       public void Update()
       {
       }
   }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}