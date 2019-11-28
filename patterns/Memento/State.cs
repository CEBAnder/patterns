namespace Patterns.Memento
{
    public class State
    {
        private readonly string _stateInfo;

        private State(string stateImfo)
        {
            _stateInfo = stateImfo;
        }

        public State FillState(string info)
        {
            return new State(info);
        }
    }
}
