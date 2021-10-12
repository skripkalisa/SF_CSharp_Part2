namespace StateExample.States
{
    /// <summary>
    /// Общий интерфейс, определяющий состояния
    /// </summary>
    abstract class State
    {
        public abstract void Handle(ContextObject contextObject);
    }
}