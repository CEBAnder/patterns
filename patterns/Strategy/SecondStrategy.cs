using System;

namespace Patterns.Strategy.Implementation
{
    public class SecondStrategy : IStrategy
    {
        public void DoSomeAction()
        {
            Console.WriteLine("Second strategy made some action");
        }
    }
}
