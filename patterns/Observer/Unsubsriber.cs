using System;
using System.Collections.Generic;

namespace Patterns.Observer
{
    public class Unsubsriber : IDisposable
    {
        private List<IObserver<Observable>> _subscribers;
        private IObserver<Observable> _subscriber;

        public Unsubsriber(List<IObserver<Observable>> subscribers, IObserver<Observable> subscriber)
        {
            _subscribers = subscribers;
            _subscriber = subscriber;
        }

        public void Dispose()
        {
            if (_subscriber != null)
            {
                _subscribers.Remove(_subscriber);
            }
        }
    }
}
