using System;

namespace Patterns.Visitor
{
    public class ConcreteVisitor : Ivisitor
    {
        public void DoForFirstElement(FirstElement element)
        {
            Console.WriteLine("Do for element A");
        }

        public void DoForSecondElement(SecondElement element)
        {
            Console.WriteLine("Do for element B");
        }
    }
}