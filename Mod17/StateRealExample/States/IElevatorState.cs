namespace StateRealExample.States
{
    /// <summary>
    /// Интерфейс состояния лифта
    /// </summary>
    interface IElevatorState
    {
        void Up(Elevator elevator);
        void Down(Elevator elevator);
    }
}