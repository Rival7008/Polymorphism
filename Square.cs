using System;

namespace Polymorphism
{
    internal class Square : Geometry
    {
        internal double _side;

        public Square()
        {
            _side = 50;
        }

        public override double Area()
        {
            return _side * _side;
        }
    }
}
