using System;

namespace Patterns.Chain_of_responsibility.Implementation
{
    public class ThirdHandler : Handler
    {
        protected override void InternalHandle()
        {
            Console.WriteLine("Third handler called");
        }
    }
}
