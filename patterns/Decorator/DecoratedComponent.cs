using System;

namespace Patterns.Decorator
{
    public class DecoratedComponent : IComponent
    {
        private readonly IComponent _baseComponent;

        public DecoratedComponent(IComponent baseComponent)
        {
            _baseComponent = baseComponent;
        }

        public void DoSomething()
        {
            Console.WriteLine("Decorator does something");
            _baseComponent.DoSomething();
        }
    }
}
