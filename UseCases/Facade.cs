using Patterns.Facade;

namespace UseCases
{
    public class Facade
    {
        public static void UseFacade()
        {
            var firstSubsystem = new FirstSubsystem();
            var secondSubsystem = new SecondSubsystem();
            var facade = new Patterns.Facade.Facade(firstSubsystem, secondSubsystem);

            facade.DoCoolActions();
        }
    }
}
