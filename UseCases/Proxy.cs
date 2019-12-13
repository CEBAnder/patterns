using Patterns.Proxy;

namespace UseCases
{
    public class Proxy
    {
        public static void UseProxy()
        {
            var elem = new ProxyElement();
            elem.Action();
        }
    }
}
