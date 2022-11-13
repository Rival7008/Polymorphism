using System;

namespace Polymorphism
{
    internal class Rectangle : Geometry
    {
        internal double _firstSide;
        internal double _secondSide;

        public Rectangle()
        {
            _firstSide = 5;
            _secondSide = 50;
        }

        public override double Area()
        {
            return _firstSide * _secondSide;
        }
    }
}
