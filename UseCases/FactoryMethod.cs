using System;
using Patterns.Factory_method;

namespace UseCases
{
    public class FactoryMethod
    {
        public static void UseFactoryMethod()
        {
            var firstCreator = new FirstCreator();
            var product = firstCreator.FactoryMethod();
            Console.WriteLine(product.GetType());

            var secondCreator = new SecondCreator();
            var anotherProduct = secondCreator.FactoryMethod();
            Console.WriteLine(anotherProduct.GetType());
        }
    }
}
