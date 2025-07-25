/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Створіть анонімний метод, який приймає як аргумент масив делегатів
 * і повертає середнє арифметичне значення значень методів, повідомлених з делегатами в масиві.
 * Методи, повідомлені з делегатами з масиву, повертають випадкове значення типу int. 
 */

namespace DelegatesArray;

class Program
{
    static void Main(string[] args)
    {
        //Get random number using delegate
        Random random = new Random();
        Func<int> getRandom = () => random.Next(1, 101);

        //Array of random numbers from delegates 
        Func<int>[] randomNumbers = new Func<int>[10];
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = getRandom;
        }

        //Get average of random numbers from array
        Func<Func<int>[], double> getAverage = delegate (Func<int>[] array)
        {
            int a = 0;
            int b;
            foreach (var item in array)
            {
                b = item();
                Console.WriteLine($"The random number is: {b}");
                a += b;
            }
            return (double)a / array.Length;
        };

        Console.WriteLine($"The average of {randomNumbers.Length} random numbers is: {getAverage(randomNumbers)}");

        // Delay.
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}