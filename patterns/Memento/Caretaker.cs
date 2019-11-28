using System.Collections.Generic;

namespace Patterns.Memento.Implementation
{
    public class Caretaker
    {
        private List<Memento> _mementos { get; set; }

        private Originator _originator { get; set; }

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void AddMemento()
        {
            _mementos.Add(_originator.SaveState());
        }

        public State GetState(int index)
        {
            return _mementos[index]._state;
        }
    }
}
