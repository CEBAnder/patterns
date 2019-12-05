namespace Patterns.Factory_method
{
    public class FirstCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new FirstProduct();
        }
    }
}
