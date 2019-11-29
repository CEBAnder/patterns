using System;

namespace Patterns.Mediator
{
    class SecondComponent : Component
    {
        public SecondComponent(IMediator mediator) : base(mediator)
        { }

        public override void Operation()
        {
            Console.WriteLine("Second component operation");

            _mediator.Notify(this);
        }

        public void ReactOnFirstComponent()
        {
            Console.WriteLine("Second component reaction");
        }
    }
}
