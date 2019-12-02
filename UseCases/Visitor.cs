using Patterns.Visitor;
using System.Collections.Generic;

namespace UseCases
{
    public class Visitor
    {
        public static void UseVisitor()
        {
            var elements = new List<IElement>
            {
                new FirstElement(),
                new SecondElement()
            };

            foreach(var elem in elements)
            {
                elem.Accept(new ConcreteVisitor());
            }
        }
    }
}
