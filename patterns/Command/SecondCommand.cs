using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Command
{
    public class SecondCommand : ICommand
    {
        private Receiver _receiver = new Receiver();

        private int _value;

        public SecondCommand(int value)
        {
            _value = value;
        }

        public void Execute()
        {
            Console.WriteLine($"Value for second command: {_value}");
            _receiver.ActionForCommand(this);
        }
    }
}
