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
            for (int i = 0; i < list.ArrayLength; i++)
            {
                Console.Write(list[i]);
                if (i < (list.ArrayLength - 1))
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            MyList<char> charList = new MyList<char>();
            charList.AddItem('a');
            charList.AddItem('b');
            charList.AddItem('c');
            ShowArray(charList);

            MyList<string> stringList = new MyList<string>();
            stringList.AddItem("first");
            stringList.AddItem("second");
            stringList.AddItem("third");
            ShowArray(stringList);

            MyList<int> intList = new MyList<int>();
            intList.AddItem(1);
            intList.AddItem(2);
            intList.AddItem(3);
            ShowArray(intList);
        }
    }
}
