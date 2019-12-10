using System;

namespace Patterns.Decorator
{
    public class Component : IComponent
    {
        public void DoSomething()
        {
            Console.WriteLine("Component does something");
        }
    }
}
