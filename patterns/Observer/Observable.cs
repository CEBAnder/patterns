using System;
using System.Collections.Generic;

namespace Patterns.Observer
{
    public class Observable : IObservable<Observable>
    {
        private List<IObserver<Observable>> _subscribers { get; set; }

        public int SomeValue { get; set; }

        public Observable()
        {
            _subscribers = new List<IObserver<Observable>>();
        }

        public IDisposable Subscribe(IObserver<Observable> observer)
        {
            _subscribers.Add(observer);

            return new Unsubsriber(_subscribers, observer);
        }

        public void NotifySubscribers()
        {
            var rnd = new Random();
            SomeValue = rnd.Next(0, 100);

            foreach(var subscriber in _subscribers)
            {
                subscriber.OnNext(this);
            }
        }
    }
}
