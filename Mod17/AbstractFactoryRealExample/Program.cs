using System;
using AbstractFactoryRealExample.Factories;
 
namespace AbstractFactoryRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание дракона через фабрику
            var dragon = new Monster(new DragonFactory());
            dragon.Move();
            dragon.Hit();
 
            Console.WriteLine();
            // Создание орка через фабрику
            var orc = new Monster(new OrcFactory());
            orc.Move();
            orc.Hit();
 
            Console.WriteLine();
            Console.WriteLine("Всем конец...");
        }
    }
}