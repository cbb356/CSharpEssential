﻿using System;

namespace Classes
{
    internal class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        { 
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double Area
        { 
            get 
            {
                return AreaCalculator(); 
            } 
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
}
