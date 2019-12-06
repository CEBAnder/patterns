namespace Patterns.Builder
{
    public class CoolObject
    {
        public int FirstField { get; private set; }

        public string SecondField { get; private set; }

        public bool ThirdFiled { get; private set; }

        public void SetFirstFiel(int value)
        {
            FirstField = value;
        }

        public void SetSecondValue(string value)
        {
            SecondField = value;
        }

        public void SetThirdValue(bool value)
        {
            ThirdFiled = value;
        }
    }
}
