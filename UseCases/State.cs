using Patterns.State;

namespace UseCases
{
    public class State
    {
        public static void UseState()
        {
            var firstState = new FirstState();
            var context = new Context(firstState);

            context.FirstAction();
            context.SecondAction();
            context.ThirdAction();
            context.SecondAction();
            context.FirstAction();
            context.ThirdAction();
        }
    }
}
