using Patterns.Command;

namespace UseCases
{
    public class Command
    {
        public static void UseCommand()
        {
            var firstCommand = new FirstCommand(1);
            var secondCommand = new SecondCommand(2);

            firstCommand.Execute();
            secondCommand.Execute();
        }
    }
}
