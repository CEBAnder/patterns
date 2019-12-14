namespace Patterns.Bridge
{
    public class Abstraction
    {
        private readonly IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public void FirstAction()
        {
            _implementation.Actioin1();
        }

        public void SecondAction()
        {
            _implementation.Action2();
            _implementation.Action3();
        }
    }
}
