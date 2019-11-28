namespace Patterns.Memento.Implementation
{
    public class Memento
    {
        public State _state { get; private set; }

        public Memento(State state)
        {
            _state = state;
        }
    }
}
