using System;
 
namespace AbstractFactoryRealExample.Movements
{
    /// <summary>
    /// Летающим монстрам доступно движение полета
    /// </summary>
    class FlyMovement : IMovement
    {
        public void Start()
        {
            Console.WriteLine("Летим");
        }
    }
}