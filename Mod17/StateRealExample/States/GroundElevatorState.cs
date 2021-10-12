using System;

namespace StateRealExample.States
{
    /// <summary>
    /// Реализация наземного состояния (лифт на первом этаже)
    /// </summary>
    class GroundElevatorState : IElevatorState
    {
        public void Up(Elevator elevator)
        {
            Console.WriteLine("Поднимаемся на верхний этаж");
            elevator.ElevatorState = new UpperElevatorState();
        }
 
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся на подвальный этаж");
            elevator.ElevatorState = new LowerElevatorState();
        }
    }
}