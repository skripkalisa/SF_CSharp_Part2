namespace StateExample.States
{
    /// <summary>
    /// Второе состояние
    /// </summary>
    class StateTwo : State
    {
        public override void Handle(ContextObject contextObject)
        {
            contextObject.State = new StateOne();
        }
    }
}