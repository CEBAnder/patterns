using Patterns.Factory_method;

namespace Patterns.Abstract_factory
{
    public class FirstAbstractFactory : IAbstractFactory
    {
        public IProduct CreateProduct()
        {
            var firstCreator = new FirstCreator();
            return firstCreator.FactoryMethod();
        }
    }
}
