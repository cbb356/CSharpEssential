/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Напишіть програму, в якій метод викликатиметься рекурсивно. 
 * Кожен новий виклик методу виконується окремому потоці.
 */

using System.Diagnostics.Metrics;

namespace Recursion
{

    internal class Program
    {
        private static readonly int MaxDepth = 5;
        static void Recursive(int depth)
        {
            int hash = Thread.CurrentThread.GetHashCode();

            Console.WriteLine($"Entering {depth} on Thread {hash}");
            if (depth > 1)
            {
                Thread newThread = new Thread(() => Recursive(depth - 1));
                newThread.Start();
                newThread.Join();
            }
            Console.WriteLine($"Exiting {depth} on Thread {hash}");
        }
        static void Main(string[] args)
        {
            Recursive(MaxDepth);

            // Delay
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
