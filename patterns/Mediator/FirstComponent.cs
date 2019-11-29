using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    public class FirstComponent : Component
    {
        public FirstComponent(IMediator mediator) : base(mediator)
        { }

        public override void Operation()
        {
            Console.WriteLine("First component operation");

            _mediator.Notify(this);
        }

        public void ReactOnSecondComponent()
        {
            Console.WriteLine("First component reaction");
        }
    }
}
