using System;
using Patterns.Builder;

namespace UseCases
{
    public class Builder
    {
        public static void UseBuilder()
        {
            var concreteBuilder = new ConcreteBuilder();
            var director = new Director(concreteBuilder);
            var coolObject = director.Build();
            Console.WriteLine($"First value: {coolObject.FirstField} Second value: {coolObject.SecondField} Third value: {coolObject.ThirdFiled}");
        }
    }
}
