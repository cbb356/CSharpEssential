namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first side of the rectangle (positive double): ");
            if (!double.TryParse(Console.ReadLine(), out double side1) || side1 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive double.");
                return;
            }

            Console.Write("Enter the second side of the rectangle (positive double): ");
            if (!double.TryParse(Console.ReadLine(), out double side2) || side2 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive double.");
                return;
            }

            Rectangle rectangle = new Rectangle (side1, side2);

            Console.WriteLine($"The perimeter of the rectangle with sides {side1} and {side2} " +
                $"is: {rectangle.Perimeter:F2}");
            Console.WriteLine($"The area of the rectangle with sides {side1} and {side2} " +
                $"is: {rectangle.Area:F2}");

            // Delay.
            Console.ReadKey();
        }
    }
}
