using System;
 
namespace AdapterRealExample.Devices
{
    /// <summary>
    /// Класс для работы с принтером
    /// </summary>
    class PaperPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Печатаем на бумаге");
        }
    }
}