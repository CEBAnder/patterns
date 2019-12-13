using System;

namespace Patterns.Proxy
{
    public class ProxyElement : IElement
    {
        private readonly Lazy<RealElement> _realElement = new Lazy<RealElement>();
        
        public void Action()
        {
            _realElement.Value.Action();
        }
    }
}
