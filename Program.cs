using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object type of geometry
            Geometry myGeometry;

            //Use Geometry object to create a circle and print to the console
            myGeometry = new Circle();
            Console.WriteLine($"Circle area {myGeometry.Area()}");

            //Use Geomtery object to create a Rectangle and print to the console
            myGeometry = new Rectangle();
            Console.WriteLine($"Rectangle area : {myGeometry.Area()}");

            //Use Geometry object to create a square and print to console
            myGeometry = new Square();
            Console.WriteLine($"Square area : {myGeometry.Area()}");
        }
    }
}
