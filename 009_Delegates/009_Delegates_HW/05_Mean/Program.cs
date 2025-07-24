/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть анонімний метод, який приймає як параметри три цілих аргументи
 * і повертає середнє арифметичне цих аргументів.
 */

namespace Mean;

public delegate double Mean (int x, int y, int z);

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int c = 4;

        Mean mean = delegate(int x, int y, int z)
        {
            return (double)(x + y + z) / 3;
        };
            
        Console.WriteLine($"The mean of numbers {a}, {b}, {c}: {mean(a, b, c):f4}");
        
        //Delay
        Console.ReadKey();
    }
}   