using System;

namespace Patterns.Proxy
{
    public class RealElement : IElement
    {
        public void Action()
        {
            Console.WriteLine("Real element action");
        }
    }
}
