/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть анонімний метод, який приймає як параметри три цілих аргументи
 * і повертає середнє арифметичне цих аргументів.
 */

namespace Average;

public delegate double Average (int x, int y, int z);

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int c = 4;

        Average average = delegate(int x, int y, int z)
        {
            return (double)(x + y + z) / 3;
        };
            
        Console.WriteLine($"The average of numbers {a}, {b}, {c}: {average(a, b, c):f}");

        // Delay.
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}   