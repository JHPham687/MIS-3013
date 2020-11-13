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
            Console.WriteLine($"The area of the circle with {myCircle.Radius} radius is {myCircle.CalculateArea()}\n" +
            $" and a perimeter of {myCircle.CalculatePerimeter()}");

            Circle circle2 = new Circle();
            circle2.Radius = 8282828282;
            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();
            Console.WriteLine($"\nThe area of the circle with {circle2.Radius} radius is {areaOfCircle2}\n" +
            $" and a perimeter of {perimeterOfCircle2}");

            Rectangle rectangle1 = new Rectangle();
            rectangle1.Length = 10;
            rectangle1.Width = 5;
            Console.WriteLine($"\nThe area of the rectangle with {rectangle1.Width} width and {rectangle1.Length} length is " +
                $"{rectangle1.CalculateArea()} and the perimeter is {rectangle1.CalculatePerimeter()}");

            Rectangle rectangle2 = new Rectangle();
            rectangle2.Length = 25;
            rectangle2.Width = 15;
            double areaOfRectangle2 = rectangle2.CalculateArea();
            double perimeterOfRectangle2 = rectangle2.CalculatePerimeter();
            Console.WriteLine($"\nThe area of the rectangle with {rectangle2.Width} width and {rectangle2.Length} length is " +
                $"{areaOfRectangle2} and the perimeter is {perimeterOfRectangle2}");

            Console.ReadKey();

        }
    }
}
