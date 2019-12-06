namespace Patterns.Builder
{
    public class ConcreteBuilder : Builder
    {
        public override Builder FirstVal(int val)
        {
            _coolObject.SetFirstFiel(val);
            return this;
        }

        public override Builder SecondVal(string val)
        {
            _coolObject.SetSecondValue(val);
            return this;
        }

        public override Builder ThirdVal(bool val)
        {
            _coolObject.SetThirdValue(val);
            return this;
        }
    }
}
