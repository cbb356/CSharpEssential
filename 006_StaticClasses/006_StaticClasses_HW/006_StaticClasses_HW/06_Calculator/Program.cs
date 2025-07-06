namespace Calculator
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити статичний клас Calculator, з методами виконання основних арифметичних операцій. 
     * Написати програму, яка виводить на екран основні арифметичні операції.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"{x} + {y} = {Calculator.Addition(x, y)}");
            Console.WriteLine($"{x} - {y} = {Calculator.Subtraction(x, y)}");
            Console.WriteLine($"{x} * {y} = {Calculator.Multiplication(x, y)}");
            Console.WriteLine($"{x} / {y} = {Calculator.Division(x, y)}");

            // Delay.
            Console.ReadKey();
        }
    }
}
