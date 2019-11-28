using Patterns.Strategy.Implementation;

namespace Patterns.Strategy
{
    class StrategyUser
    {
        private IStrategy _strategy { get; set; }

        public StrategyUser(IStrategy strategy)
        {
            _strategy = strategy;
        }

        private void DoSomeStuff()
        {
            _strategy.DoSomeAction();
        }
    }
}
