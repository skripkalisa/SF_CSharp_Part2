using System;

namespace AdapterExample
{
    // Наш код, где необходимо использование класса-источника
    class Client
    {
        public void Request(DataSource dataSource)
        {
            dataSource.GetData();
        }
    }
  
    /// <summary>
    /// Класс - источник ресурса, к которому нужно подключиться
    /// </summary>
    class DataSource
    {
        public virtual void GetData()
        {}
    }
  
    /// <summary>
    /// Класс - потребитель ресурса
    /// </summary>
    class DataConsumer
    {
        public void GetSpecificData()
        {}
    }
    /// <summary>
    /// Адаптер для подключения
    /// </summary>
    class Adapter : DataSource
    {
        private DataConsumer _dataConsumer = new DataConsumer();
      
        // метод для получения ресурса
        public override void GetData()
        {
            _dataConsumer.GetSpecificData();
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