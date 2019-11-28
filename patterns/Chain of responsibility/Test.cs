using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Chain_of_responsibility.Implementation
{
    class Test
    {
        void Do()
        {
            var handler1 = new FirstHandler();
            var handler2 = new SecondHandler();
            var handler3 = new ThirdHandler();

            handler1.SetNext(handler2).SetNext(handler3);

            handler1.Handle();
        }
    }
}
