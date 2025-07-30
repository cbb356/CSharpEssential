/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть клас MyList. Реалізуйте у найпростішому наближенні можливість використання 
 * його екземпляра аналогічно екземпляру класу List. Мінімально необхідний інтерфейс 
 * взаємодії з екземпляром повинен включати метод додавання елемента, індексатор для отримання 
 * значення елемента за вказаним індексом і властивість тільки для читання 
 * для отримання загальної кількості елементів.
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
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < (list.Count - 1))
                {
                    Console.Write(", ");
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

            MyList<string> stringList = new MyList<string>();
            stringList.Add("first");
            stringList.Add("second");
            stringList.Add("third");
            ShowArray(stringList);

            MyList<int> intList = new MyList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            ShowArray(intList);

            MyList<long> longList = new MyList<long>();
            ShowArray(longList);
        }
    }
}
