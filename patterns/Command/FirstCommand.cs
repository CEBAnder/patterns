using System;

namespace Patterns.Command
{
    public class FirstCommand : ICommand
    {
        private int _value;

        public FirstCommand(int value)
        {
            _value = value;
        }

        public void Execute()
        {
            Console.WriteLine($"Executed command with value: {_value}");
        }
    }
}
