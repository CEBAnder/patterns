using System;

namespace Patterns.Adapter
{
    public class Target
    {
        public virtual void Request(int argument)
        {
            Console.WriteLine($"Target method. Int arg: {argument}");
        }
    }
}
