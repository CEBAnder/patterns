using System;
using Patterns.Abstract_factory;

namespace UseCases
{
    public class AbstractFactory
    {
        public static void UseAbstractFactory()
        {
            var firstFactory = new FirstAbstractFactory();
            var firstObj = firstFactory.CreateProduct();

            var secondFactory = new SecondAbstractFactory();
            var secondObj = secondFactory.CreateProduct();

            Console.WriteLine(firstObj);
            Console.WriteLine(secondObj);
        }
    }
}
