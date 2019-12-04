namespace Patterns.State
{
    public class Context
    {
        public IState State { get; set; }

        public Context(IState state)
        {
            State = state;
        }

        public void FirstAction()
        {
            State.DoFirstAction(this);
        }

        public void SecondAction()
        {
            State.DoSecondAction(this);
        }

        public void ThirdAction()
        {
            State.DoThirdAction(this);
        }
    }
}
