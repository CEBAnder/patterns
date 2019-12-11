namespace Patterns.Facade
{
    public class Facade
    {
        private readonly FirstSubsystem _firstSubsystem;

        private readonly SecondSubsystem _secondSubsystem;

        public Facade(FirstSubsystem firstSubsystem, SecondSubsystem secondSubsystem)
        {
            _firstSubsystem = firstSubsystem;
            _secondSubsystem = secondSubsystem;
        }

        public void DoCoolActions()
        {
            _firstSubsystem.Operation1();
            _firstSubsystem.Operation2();
            _secondSubsystem.Operation1();
            _secondSubsystem.Operation2();
        }
    }
}
