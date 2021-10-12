using System;
 
namespace AbstractFactoryRealExample.Weapons
{
    /// <summary>
    /// Оружие драконов - огненное дыхание
    /// </summary>
    class FireBreath : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Дышим огнем");
        }
    }
}