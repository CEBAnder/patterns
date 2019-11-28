namespace Patterns.Memento.Implementation
{
    public class Originator
    {
        private State _state { get; set; }

        public Memento SaveState()
        {
            return new Memento(_state);
        }

        public State GetState(Memento memento)
        {
            return memento._state;
        }
    }
}
