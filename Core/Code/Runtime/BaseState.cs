namespace UFlow.Addon.FSM.Core.Runtime {
    public abstract class BaseState : IState {
        public virtual void Enter() { }
        public virtual void Tick() { }
        public virtual void Exit() { }
    }
}