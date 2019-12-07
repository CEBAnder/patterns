using Patterns.Factory_method;

namespace Patterns.Abstract_factory
{
    public class SecondAbstractFactory : IAbstractFactory
    {
        public IProduct CreateProduct()
        {
            var secondCreator = new SecondCreator();
            return secondCreator.FactoryMethod();
        }
    }
}
