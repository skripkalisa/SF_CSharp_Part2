using System;
 
namespace FacadeRealExample.Components
{
    /// <summary>
    /// Класс для вызовов среды выполнения CLR
    /// </summary>
    class Runtime
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }
}