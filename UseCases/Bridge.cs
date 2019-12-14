using Patterns.Bridge;

namespace UseCases
{
    public class Bridge
    {
        public static void UseBridge()
        {
            var imp = new Implementation();
            var abstraction = new Abstraction(imp);
            abstraction.FirstAction();
            abstraction.SecondAction();
        }
    }
}
