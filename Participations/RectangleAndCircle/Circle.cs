﻿using System;

namespace RectangleAndCircle
{
    class Circle
    {
        //private double _Radius;

        //public double GetRadius()
        //{
        //    return _Radius;
        //}

        public double Radius { get; set; }


        public Circle()
        {
            Radius = 0;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        
            

    }
}
