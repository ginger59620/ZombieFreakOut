public class State
{
    public StateMachine machine;
    public JayVision jay;

    public State(StateMachine machine, JayVision jay)
    {
        this.machine = machine;
        this.jay = jay;
    }

    public virtual void OnEnter()
    {
    }

    public virtual void LogicUpdate()
    {
    }

    public virtual void OnExit()
    {
    }
}
