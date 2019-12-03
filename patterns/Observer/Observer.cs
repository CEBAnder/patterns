using System;

namespace Patterns.Observer
{
    public class Observer : IObserver<Observable>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error");
        }

        public void OnNext(Observable value)
        {
            Console.WriteLine($"Next notification received. Observable value {value.SomeValue}");
        }
    }
}
