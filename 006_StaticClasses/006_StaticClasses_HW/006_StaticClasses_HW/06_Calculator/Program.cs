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
            Calculator.Addition(5, 10);
            Calculator.Subtraction(5, 10);
            Calculator.Multiplication(5, -10);
            Calculator.Division(5, 10);
            Calculator.Division(5, 0);

            // Delay.
            Console.ReadKey();
        }
    }
}
