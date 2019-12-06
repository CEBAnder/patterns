namespace Patterns.Builder
{
    public class Director
    {
        Builder _builder { get; set; }

        public Director(Builder builder)
        {
            _builder = builder;
        }

        public CoolObject Build()
        {
            return _builder.
                FirstVal(10).
                SecondVal("Hello").
                ThirdVal(true).
                GetObject();
        }
    }
}
