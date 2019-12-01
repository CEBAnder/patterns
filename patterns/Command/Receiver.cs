using System;

namespace Patterns.Command
{
    public class Receiver
    {
        public void ActionForCommand(ICommand command)
        {
            if (command is FirstCommand)
                Console.WriteLine("Action for first command");
            if (command is SecondCommand)
                Console.WriteLine("Action for second command");
        }
    }
}
