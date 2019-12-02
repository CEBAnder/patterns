namespace Patterns.Visitor
{
    public interface IElement
    {
        void Accept(Ivisitor visitor);
    }
}
