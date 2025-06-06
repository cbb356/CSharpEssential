namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Triangle
            Point tA = new Point(1, 1, "A");
            Point tB = new Point(5, 3, "B");
            Point tC = new Point(0, 2, "C");
            Figure triangle = new Figure(tA, tB, tC);
            triangle.PerimeterCalculator();

            //Quadrilateral
            Point qA = new Point(2, 2, "A");
            Point qB = new Point(5, 6, "B");
            Point qC = new Point(3, 8, "C");
            Point qD = new Point(0, 3, "D");
            Figure quadrilateral = new Figure(qA, qB, qC, qD);
            quadrilateral.PerimeterCalculator();

            //Pentagon
            Point pA = new Point(2, 2, "A");
            Point pB = new Point(5, 6, "B");
            Point pC = new Point(3, 8, "C");
            Point pD = new Point(0, 3, "D");
            Point pE = new Point(-1, 0, "E");
            Figure pentagon = new Figure(pA, pB, pC, pD, pE);
            pentagon.PerimeterCalculator();

            // Delay.
            Console.ReadKey();
        }
    }
}
