/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть чотири лямбда оператора для виконання арифметичних дій:
 * (Add – додавання, Sub – віднімання, Mul – множення, Div – поділ).
 * Кожен лямбда оператор повинен приймати два аргументи та повертати результат обчислення.
 * Лямбда оператор поділу повинен перевірити поділ на нуль.
 * Написати програму, яка виконуватиме арифметичні дії, вказані користувачем. 
 */

namespace Arithmetic;

class Program
{
    static void Main(string[] args)
    {
        int x, y;

        //First number
        Console.WriteLine("Enter first number:");
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("You entered a wrong number:");
            Console.WriteLine("Enter first number:");
        }

        //Second number
        Console.WriteLine("Enter second number:");
        while (!int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("You entered a wrong number:");
            Console.WriteLine("Enter second number:");
        }

        //Operation
        Console.WriteLine("Enter the arithmetic operation (+, -, *, /):");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine($"{x} + {y} = {Calculator.Add(x, y)}");
                break;
            case "-":
                Console.WriteLine($"{x} - {y} = {Calculator.Sub(x, y)}");
                break;
            case "*":
                Console.WriteLine($"{x} * {y} = {Calculator.Mul(x, y)}");
                break;
            case "/":
                if (y != 0)
                {
                    Console.WriteLine($"{x} / {y} = {Calculator.Div(x, y)}");
                }
                else
                {
                    Calculator.Div(x, y);
                }
                break;
            default:
                Console.WriteLine("Unknown operation");
                Console.WriteLine("Enter the arithmetic operation (+, -, *, /) or exit:");
                break;
        }

        // Delay.
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }
}