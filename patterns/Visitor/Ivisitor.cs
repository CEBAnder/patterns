namespace Patterns.Visitor
{
    public interface Ivisitor
    {
        void DoForFirstElement(FirstElement element);

        void DoForSecondElement(SecondElement element);
    }
}
