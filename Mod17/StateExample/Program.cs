using StateExample.States;

namespace StateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем объет сразу в каким-то состоянии
            var contextObject = new ContextObject(new StateOne());
      
            contextObject.Switch(); // Переход в состояние StateTwo
            contextObject.Switch(); // Переход в состояние StateOne
        }
    }
}