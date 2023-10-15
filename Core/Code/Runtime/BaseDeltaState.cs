namespace UFlow.Addon.FSM.Core.Runtime {
    public abstract class BaseDeltaState : IDeltaState {
        public virtual void Enter() { }
        public virtual void Tick(float delta) { }
        public virtual void Exit() { }
    }
}