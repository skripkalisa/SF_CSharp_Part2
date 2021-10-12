using AdapterRealExample.Devices;

namespace AdapterRealExample
{
    public class CanvasPainterToPrinterAdapter : IPrinter
    {
        private CanvasPainter _canvasPainter;


        public CanvasPainterToPrinterAdapter(CanvasPainter canvasPainter)
        {
            _canvasPainter = canvasPainter;
        }

        public void Print()
        {
            _canvasPainter.Paint();
        }
    }
}