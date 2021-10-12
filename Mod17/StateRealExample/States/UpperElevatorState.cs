using System;

namespace StateRealExample.States
{
    /// <summary>
    /// Реализация надземного состояния (лифт на верхних этажах)
    /// </summary>
    class UpperElevatorState : IElevatorState
    {
        public void Up(Elevator elevator)
        {
            Console.WriteLine("Перемещаемся ещё выше");
        }
 
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся на первый этаж");
            elevator.ElevatorState = new GroundElevatorState();
        }
    }
}