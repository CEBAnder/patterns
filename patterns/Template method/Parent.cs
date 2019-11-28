using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Template_method.Implementation
{
    public abstract class Parent
    {
        protected abstract void StepOne();

        protected abstract void StepTwo();

        protected abstract void StepThree();

        public void TemplateMethod()
        {
            StepOne();
            StepTwo();
            StepThree();
        }
    }
}
