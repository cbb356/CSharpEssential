/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть клас ArrayList. Реалізуйте у найпростішому наближенні можливість використання 
 * його екземпляра аналогічно екземпляру класу ArrayList із простору імен System.Collections. 
 */

using System;
using System.Collections;

namespace MyArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArrayList arrayList = new MyArrayList();
            arrayList.Add(1);
            arrayList.Add(1.25);
            arrayList.Add("test");
            arrayList.Add(new Person("Alice", 25));

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"The array element at index {i} has type '{arrayList[i].GetType().Name}' and value '{arrayList[i].ToString()}'");
            }

            // Delay.
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
