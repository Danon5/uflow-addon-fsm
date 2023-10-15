namespace UFlow.Addon.FSM.Core.Runtime {
    public interface IDeltaState : IBaseState {
        void Enter();
        void Tick(float delta);
        void Exit();
    }
}