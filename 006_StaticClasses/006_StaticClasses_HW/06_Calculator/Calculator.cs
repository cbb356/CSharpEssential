namespace Calculator
{
    internal static class Calculator
    {       
        public static int Addition(int x, int y)
        {
            return x + y;
        }

        public static int Subtraction(int x, int y)
        {
            return x - y;
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }

        public static double Division(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine($"You can't divide by zero!");
            }
            return (double)x / y;
        }
    }
}
