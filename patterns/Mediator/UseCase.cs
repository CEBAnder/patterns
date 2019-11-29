namespace Patterns.Mediator
{
    class UseCase
    {
        private void Use()
        {
            var mediator = new Mediator();

            var firstComponent = new FirstComponent(mediator);

            var secondComponent = new SecondComponent(mediator);

            firstComponent.Operation();
            secondComponent.Operation();
        }
    }
}
