using Patterns.Adapter;

namespace UseCases
{
    public class Adapter
    {
        public static void UseAdapter()
        {
            var adaptee = new Adaptee();
            var adapter = new Patterns.Adapter.Adapter(adaptee);
            adapter.Request(1);

            var target = new Target();
            target.Request(2);
        }
    }
}
