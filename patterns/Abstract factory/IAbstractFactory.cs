using Patterns.Factory_method;

namespace Patterns.Abstract_factory
{
    //Contains factory methods
    public interface IAbstractFactory
    {
        IProduct CreateProduct();
    }
}
