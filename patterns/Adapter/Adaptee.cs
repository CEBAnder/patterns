using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Adapter
{
    public class Adaptee
    {
        public void SpecificRequest(string argument)
        {
            Console.WriteLine($"Adaptee method. String arg: {argument}");
        }
    }
}
