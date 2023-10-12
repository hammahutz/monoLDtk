namespace MonoLDtk.Shared.States
{
    public abstract class StateManager<EState> where EState : Enum
    {
        public State<EState> CurrentState { get; private set; }

        protected abstract State<EState> GetState(EState state);

        public virtual void TransitionToState(EState nextState)
        {
            UnloadCurrentState();
            LoadNextState(nextState);
        }
        private void LoadNextState(EState nextState)
        {
            CurrentState = GetState(nextState);
            CurrentState.OnChangeState += TransitionToState;
            CurrentState.Enter();
        }
        private void UnloadCurrentState()
        {
            if (CurrentState != null)
            {
                CurrentState.Exit();
                CurrentState.OnChangeState -= TransitionToState;
            }
        }
    }
}