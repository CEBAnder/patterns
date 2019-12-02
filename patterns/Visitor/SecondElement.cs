using System;

namespace Patterns.Visitor
{
    public class SecondElement : IElement
    {
        public void Accept(Ivisitor visitor)
        {
            visitor.DoForSecondElement(this);
        }
    }
}
