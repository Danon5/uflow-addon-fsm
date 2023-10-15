namespace UFlow.Addon.FSM.Core.Runtime {
    public interface IState : IBaseState {
        void Enter();
        void Tick();
        void Exit();
    }
}