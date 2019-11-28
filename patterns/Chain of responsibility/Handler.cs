namespace Patterns.Chain_of_responsibility.Implementation
{
    public abstract class Handler
    {
        private Handler _nextHandler { get; set; }

        public Handler SetNext(Handler nextHandler)
        {
            _nextHandler = nextHandler;
            return _nextHandler;
        }

        public void Handle()
        {
            InternalHandle();
            if (_nextHandler != null)
            {
                _nextHandler.Handle();
            }
        }

        protected abstract void InternalHandle();
    }
}
