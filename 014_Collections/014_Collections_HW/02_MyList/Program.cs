/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть колекцію MyList. Реалізуйте у найпростішому наближенні можливість 
 * використання її екземпляра аналогічно екземпляру класу List. 
 * Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, 
 * індексатор для отримання значення елемента за вказаним індексом і властивість 
 * тільки для читання для отримання загальної кількості елементів. 
 * Реалізуйте можливість перебору елементів колекції у циклі наперед.
 */

namespace MyList
{
    internal class Program
    {
        internal static void ShowArray<T>(MyList<T> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }
            bool isFirst = true;
            foreach (var item in list)
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
            ShowArray(charList);

            MyList<string> stringList = new MyList<string>("first", "second");
            stringList.Add("third");
            ShowArray(stringList);

            MyList<int> intList = new MyList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            ShowArray(intList);

            MyList<long> longList = new MyList<long>();
            ShowArray(longList);

            // Delay.
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
