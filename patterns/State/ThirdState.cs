using System;

namespace Patterns.State
{
    public class ThirdState : IState
    {
        public void DoFirstAction(Context context)
        {
            Console.WriteLine("3 -> 1");
            context.State = new FirstState();
        }

        public void DoSecondAction(Context context)
        {
            Console.WriteLine("3 -> 2");
            context.State = new SecondState();
        }

        public void DoThirdAction(Context context)
        {
            Console.WriteLine("Third state do nothing");
        }
    }
}
