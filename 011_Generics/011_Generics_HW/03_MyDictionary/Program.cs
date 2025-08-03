/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть клас Dictionary. Реалізуйте у найпростішому наближенні можливість використання 
 * його екземпляра аналогічно екземпляру класу Dictionary із простору імен System.Collections.Generic. 
 * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання пар елементів, 
 * індексатор для отримання значення елемента за вказаним індексом і властивість тільки для читання 
 * для отримання загальної кількості пар елементів.
 */

using System;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> customDict = new MyDictionary<string, int>();

            // Adding key-value pairs using Add method
            customDict.Add("apple", 5);
            customDict.Add("banana", 3);
            customDict.Add("orange", 8);
            Console.WriteLine($"Count: {customDict.Count}");
            Console.WriteLine($"apple = {customDict["apple"]}");
            Console.WriteLine($"banana = {customDict["banana"]}");
            Console.WriteLine($"orange = {customDict["orange"]}\n");
            
            // Trying adding the item with existing key
            customDict.Add("apple", 15); //Should be an error

            // Using indexer to add and access values
            customDict["grape"] = 12;   // Add new value
            customDict["apple"] = 10;   // Update existing value
            Console.WriteLine($"\nCount: {customDict.Count}");
            Console.WriteLine($"apple = {customDict["apple"]}");
            Console.WriteLine($"banana = {customDict["banana"]}");
            Console.WriteLine($"orange = {customDict["orange"]}");
            Console.WriteLine($"grape = {customDict["grape"]}\n");
            
            // Delay
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
