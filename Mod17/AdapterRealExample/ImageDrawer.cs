using AdapterRealExample.Devices;
 
namespace AdapterRealExample
{
    /// <summary>
    /// Класс для отрисовки изображений
    /// </summary>
    class ImageDrawer
    {
        // Метод, запускающий печать с помощью внешнего устройства
        public void DrawWith(IPrinter printer)
        {
            printer.Print();
        }
    }
}