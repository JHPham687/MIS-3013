using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleAndCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.Radius = 7.5;
            Console.WriteLine($"The area of the circle with {myCircle.Radius} is {myCircle.CalculateArea()}\n" +
            $" and a perimeter of {myCircle.CalculatePerimeter()}");

            Circle circle2 = new Circle();
            circle2.Radius = 8282828282;
            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();

            Console.ReadKey();

        }
    }
}
