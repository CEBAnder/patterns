using System;

namespace Patterns.Bridge
{
    public class Implementation : IImplementation
    {
        public void Actioin1()
        {
            Console.WriteLine("Action 1");
        }

        public void Action2()
        {
            Console.WriteLine("Action 2");
        }

        public void Action3()
        {
            Console.WriteLine("Action 3");
        }
    }
}
