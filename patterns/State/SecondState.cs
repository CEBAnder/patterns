using System;

namespace Patterns.State
{
    public class SecondState : IState
    {
        public void DoFirstAction(Context context)
        {
            Console.WriteLine("2 -> 1");
            context.State = new FirstState();
        }

        public void DoSecondAction(Context context)
        {
            Console.WriteLine("Second state do nothing");
        }

        public void DoThirdAction(Context context)
        {
            Console.WriteLine("2 -> 3");
            context.State = new ThirdState();
        }
    }
}
