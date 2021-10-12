using System;

namespace AbstractFactoryRealExample.Movements
{
    /// <summary>
    /// Большинству наземных монстров доступен бег
    /// </summary>
    public class RunMovement : IMovement
    {
        public void Start()
        {
            Console.WriteLine("Бежим");
        }
    }
}