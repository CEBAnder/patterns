using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Mediator
{
    public abstract class Component
    {
        protected readonly IMediator _mediator;

        public Component(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Operation();
    }
}
