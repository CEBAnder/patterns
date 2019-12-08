using System;

namespace Patterns.Prototype
{
    public class Prototype : ICloneable
    {
        private int _firstVal { get; set; }

        private string _secondVal { get; set; }

        public object _thirdVal { get; set; }

        public Prototype(int firstVal, string secondVal, object thirdVal)
        {
            _firstVal = firstVal;
            _secondVal = secondVal;
            _thirdVal = thirdVal;
        }

        public object Clone()
        {
            return new Prototype(_firstVal, _secondVal, _thirdVal);
        }

        public object DeepCopy()
        {

            var obj = new Object();
            return new Prototype(_firstVal, _secondVal, obj);
        }
    }
}
