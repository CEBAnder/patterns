namespace Patterns.Factory_method
{
    public class SecondCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new SecondProduct();
        }
    }
}
