/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть метод, що розширює: public static T[ ] GetArray(this IEnumerable list){…} 
 * Застосуйте розширюючий метод до екземпляра типу MyList, розробленого в домашньому 
 * завданні 2 для даного уроку. Виведіть на екран значення елементів масиву, 
 * який повернув метод GetArray(), що розширює метод.
 */

using System.Collections;
using System.Collections.Generic;

namespace MyListExtended
{
    internal class Program
    {
        internal static void ShowArray<T>(T[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }
            bool isFirst = true;
            foreach (var item in array)
            {
                if (isFirst)
                {
                    Console.Write(item);
                    isFirst = false;
                }
                else
                {
                    Console.Write($", {item}");
                }
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            MyList<char> charList = new MyList<char>();
            charList.Add('a');
            charList.Add('b');
            charList.Add('c');
            ShowArray(charList.GetArray());

            MyList<string> stringList = new MyList<string>("first", "second");
            stringList.Add("third");
            ShowArray(stringList.GetArray());

            MyList<int> intList = new MyList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            ShowArray(intList.GetArray());

            MyList<long> longList = new MyList<long>();
            ShowArray(longList.GetArray());

            // Delay.
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
