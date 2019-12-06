﻿using System;

namespace UseCases
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterator.IterateTree();

            Command.UseCommand();

            Visitor.UseVisitor();

            Observer.UseObserver();

            State.UseState();

            FactoryMethod.UseFactoryMethod();

            Builder.UseBuilder();

            Console.ReadKey();
        }
    }
}
