﻿using System;

namespace UseCases
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterator.IterateTree();

            Command.UseCommand();

            Console.ReadKey();
        }
    }
}
