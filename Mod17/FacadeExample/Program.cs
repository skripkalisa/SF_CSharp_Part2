using System;

namespace FacadeExample
{
    /// <summary>
    /// Клиентский код
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Создание фасада
            Facade facade = new Facade(new SystemOne(), new SystemTwo(), new SystemThree());
      
            // Вызовы
            facade.OperationOne();
            facade.OperationTwo();
        }
    }
}