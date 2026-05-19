public class StateMachine
{
    public State currentState;

    public void InitializeState(State newState)
    {
        currentState = newState;

        currentState.OnEnter();
    }

    public void ChangeState(State newState)
    {
        currentState.OnExit();

        currentState = newState;

        currentState.OnEnter();
    }
}
