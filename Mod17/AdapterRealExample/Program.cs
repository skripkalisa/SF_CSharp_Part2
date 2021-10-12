using System;
using AdapterRealExample.Devices;
 
namespace AdapterRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Нам надо отрисовать изображение на бумаге и холсте
            // Запускаем класс для отрисовки
            var imageDrawer = new ImageDrawer();
          
            // Создаем класс для работы с бумажным принтером
            PaperPrinter paperPrinter = new PaperPrinter();
            // Запускаем отрисовку на бумаге
            imageDrawer.DrawWith(paperPrinter);
          
            // Теперь нужна печать на холсте
            CanvasPainter canvasPainter = new CanvasPainter();
          
            // используем адаптер
            IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
            // Запускаем печать на холсте
            imageDrawer.DrawWith(imagePrinter);
            Console.Read();
        }
    }


}