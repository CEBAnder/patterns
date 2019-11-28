using System;

namespace Patterns.Chain_of_responsibility.Implementation
{
    public class SecondHandler : Handler
    {
        protected override void InternalHandle()
        {
            Console.WriteLine("Second handler called");
        }
    }
}
