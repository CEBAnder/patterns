namespace Patterns.Flyweight
{
    public class Context
    {
        private readonly string _uniqueState;

        private readonly Flyweight _flyweight;

        public Context(string uniqueState, Flyweight flyweight)
        {
            _flyweight = flyweight;
            _uniqueState = uniqueState;
        }

        public void Operation()
        {
            _flyweight.Operation(_uniqueState);
        }
    }
}
