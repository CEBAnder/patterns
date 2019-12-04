using System;

namespace Patterns.State
{
    public class FirstState : IState
    {
        public void DoFirstAction(Context context)
        {
            Console.WriteLine("First state do nothing");
        }

        public void DoSecondAction(Context context)
        {
            Console.WriteLine("1 -> 2");
            context.State = new SecondState();
        }

        public void DoThirdAction(Context context)
        {
            Console.WriteLine("1 -> 3");
            context.State = new ThirdState();
        }
    }
}
