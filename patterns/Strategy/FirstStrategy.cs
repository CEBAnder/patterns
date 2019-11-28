using System;

namespace Patterns.Strategy.Implementation
{
    public class FirstStrategy : IStrategy
    {
        public void DoSomeAction()
        {
            Console.WriteLine("First strategy made some action");
        }
    }
}
