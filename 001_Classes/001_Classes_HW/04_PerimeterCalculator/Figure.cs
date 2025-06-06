﻿namespace Classes
{
    internal class Figure
    {
        private string figureName;
        private Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3};
            figureName = "triangle";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
            figureName = "quadrilateral";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
            figureName = "pentagon";
        }

        //Calculates length of the figure side
        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }

        //Calculates and displays perimeter of the figure
        public void PerimeterCalculator()
        {
            //Calculation
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                Point currentPoint = points[i];
                Point nextPoint = points[i + 1];
                perimeter += LengthSide(currentPoint, nextPoint);
            }
            perimeter += LengthSide(points[(points.Length - 1)], points[0]);

            //Displaying
            Console.Write($"The perimeter of the {figureName} with points ");
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write($"{points[i].Name}({points[i].X}, {points[i].Y})");
                if ( i < points.Length - 1 )
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine($" is {perimeter:F2}");
        }
    }
}
