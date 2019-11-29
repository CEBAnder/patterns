using System;

namespace Patterns.Mediator
{
    class Mediator : IMediator
    {
        public void Notify(Component component)
        {
            switch (component)
            {
                case FirstComponent firstComponent : 
                    firstComponent.ReactOnSecondComponent(); 
                    break;

                case SecondComponent secondComponent :
                    secondComponent.ReactOnFirstComponent();
                    break;

                default :
                    Console.WriteLine("Unsupported component");
                    return;
            }
                
        }
    }
}
