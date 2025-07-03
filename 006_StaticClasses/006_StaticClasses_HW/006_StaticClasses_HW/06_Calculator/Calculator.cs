namespace Calculator
{
    internal static class Calculator
    {       
        public static void Addition(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {(x + y)}");
        }

        public static void Subtraction(int X, int Y)
        {
            Console.WriteLine($"{X} - {Y} = {(X - Y)}");
        }

        public static void Multiplication(int X, int Y)
        {
            Console.WriteLine($"{X} * {Y} = {(X * Y)}");
        }

        public static void Division(int X, int Y)
        {
            if (Y == 0)
            {
                Console.WriteLine($"You cannot divide by zero!");
                return;
            }
            Console.WriteLine($"{X} / {Y} = {((double)X / (double)Y)}");
        }
    }
}
