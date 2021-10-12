using System;
 
namespace AdapterRealExample.Devices
{
    /// <summary>
    /// Класс для работы с устройством,
    /// печатающим на холсте
    /// </summary>
    public class CanvasPainter : IPainter
    {
        public void Paint()
        {
            Console.WriteLine("Рисуем на холсте");
        }
    }
}