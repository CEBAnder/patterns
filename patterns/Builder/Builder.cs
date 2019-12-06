namespace Patterns.Builder
{
    public abstract class Builder
    {
        protected CoolObject _coolObject = new CoolObject();

        public abstract Builder FirstVal(int val);

        public abstract Builder SecondVal(string val);

        public abstract Builder ThirdVal(bool val);

        public CoolObject GetObject()
        {
            return _coolObject;
        }
    }
}
