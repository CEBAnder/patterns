using System;

namespace Patterns.Chain_of_responsibility.Implementation
{
    public class FirstHandler : Handler
    {
        protected override void InternalHandle()
        {
            Console.WriteLine("First handler called");
        }
    }
}
