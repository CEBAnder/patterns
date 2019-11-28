using System;

namespace Patterns.Template_method.Implementation
{
    public class ChildTwo : Parent
    {
        protected override void StepOne()
        {
            Console.WriteLine("Child2.Step1");
        }

        protected override void StepTwo()
        {
            Console.WriteLine("Child2.Step2");
        }

        protected override void StepThree()
        {
            Console.WriteLine("Child2.Step3");
        }
    }
}
