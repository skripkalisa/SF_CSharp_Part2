namespace StateExample.States
{
    /// <summary>
    /// Первое состояние
    /// </summary>
    class StateOne : State
    {
        public override void Handle(ContextObject contextObject)
        {
            contextObject.State = new StateTwo();
        }
    }
}