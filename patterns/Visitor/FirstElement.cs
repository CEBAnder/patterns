using System;

namespace Patterns.Visitor
{
    public class FirstElement : IElement
    {
        public void Accept(Ivisitor visitor)
        {
            visitor.DoForFirstElement(this);
        }
    }
}
