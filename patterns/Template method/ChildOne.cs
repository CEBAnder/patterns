using System;

namespace Patterns.Template_method.Implementation
{
    class ChildOne : Parent
    {
        protected override void StepOne()
        {
            Console.WriteLine("Child1.Step1");
        }

        protected override void StepTwo()
        {
            Console.WriteLine("Child1.Step2");
        }

        protected override void StepThree()
        {
            Console.WriteLine("Child1.Step3");
        }
    }
}
