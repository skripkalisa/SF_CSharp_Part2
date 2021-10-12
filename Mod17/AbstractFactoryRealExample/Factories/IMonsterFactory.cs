using AbstractFactoryRealExample.Movements;
using AbstractFactoryRealExample.Weapons;
 
namespace AbstractFactoryRealExample.Factories
{
    /// <summary>
    ///  Интерфейс абстрактной фабрики
    /// </summary>
    interface IMonsterFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}