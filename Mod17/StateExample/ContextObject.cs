using StateExample.States;

namespace StateExample
{
    /// <summary>
    /// Сам объект, поведение которого должно изменяться
    /// </summary>
    class ContextObject
    {
        public State State { get; set; }
        public ContextObject(State state)
        {
            State = state;
        }
  
        public void Switch()
        {
            State.Handle(this);
        }
    }
}