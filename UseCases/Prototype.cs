using System;

namespace UseCases
{
    public class Prototype
    {
        public static void UsePrototype()
        {
            var prototype = new Patterns.Prototype.Prototype(1, "2", new Object());

            var clone = (Patterns.Prototype.Prototype) prototype.Clone();

            var deepClone = (Patterns.Prototype.Prototype) prototype.DeepCopy();

            Console.WriteLine(clone._thirdVal.Equals(prototype._thirdVal));
            Console.WriteLine(clone._thirdVal.Equals(deepClone._thirdVal));
        }
    }
}
