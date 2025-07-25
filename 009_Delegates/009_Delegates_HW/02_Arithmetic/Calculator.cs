namespace Arithmetic
{
    internal static class Calculator
    {
        public static Func<int, int, int> Add = (x, y) =>
        {
            return x + y;
        };

        public static Func<int, int, int> Sub = (x, y) =>
        {
            return x - y;
        };

        public static Func<int, int, int> Mul = (x, y) =>
        {
            return x * y;
        };

        public static Func<int, int, double> Div = (x, y) =>
        {
            if (y == 0)
            {
                Console.WriteLine($"You can't divide by zero!");
            }
            return (double)x / y;
        };
    }
}
