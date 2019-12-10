using Patterns.Decorator;

namespace UseCases
{
    public class Decorator
    {
        public static void UseDecorator()
        {
            var component = new Component();
            var decoratedComponent = new DecoratedComponent(component);

            decoratedComponent.DoSomething();
        }
    }
}
