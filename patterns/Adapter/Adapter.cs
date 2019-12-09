namespace Patterns.Adapter
{
    public class Adapter : Target
    {
        private Adaptee _adaptee { get; set; }

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public override void Request(int argument)
        {
            _adaptee.SpecificRequest(argument.ToString());
        }
    }
}
