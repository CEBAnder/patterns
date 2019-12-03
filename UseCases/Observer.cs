using Patterns.Observer;

namespace UseCases
{
    public class Observer
    {
        public static void UseObserver()
        {
            var observable = new Observable();

            var firstObserver = new Patterns.Observer.Observer();
            observable.Subscribe(firstObserver);

            var secondObserver = new Patterns.Observer.Observer();
            observable.Subscribe(secondObserver);

            observable.NotifySubscribers();

            observable.NotifySubscribers();
        }
    }
}
