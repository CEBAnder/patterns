using Patterns.Flyweight;

namespace UseCases
{
    public class Flyweight
    {
        public static void UseFlyweight()
        {
            var flyweight = new Patterns.Flyweight.Flyweight("repeatable state");

            var context1 = new Context("unique state 1", flyweight);
            context1.Operation();

            var context2 = new Context("unique state 2", flyweight);
            context2.Operation();
        }
    }
}
