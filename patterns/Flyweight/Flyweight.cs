using System;

namespace Patterns.Flyweight
{
    public class Flyweight
    {
        private readonly string _repeatableState;

        public Flyweight(string repeatableState)
        {
            _repeatableState = repeatableState;
        }

        public void Operation(string uniqueState)
        {
            Console.WriteLine($"Unique: {uniqueState}. Repeatable: {_repeatableState}");
        }
    }
}
