using System;

namespace Polymorphism
{
    internal class Circle : Geometry
    {
        internal double _radius;
        internal readonly double _pi = 3.141f;

        public Circle()
        {
            _radius = 5;
        }

        public override double Area()
        {
            return _radius * _radius * _pi;
        }
    }
}
