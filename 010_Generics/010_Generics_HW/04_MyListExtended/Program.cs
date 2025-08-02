/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть розширює метод: public static T [] GetArray <T> (this MyList <T> list) 
 * Застосуйте розширює метод до примірника типу MyList <T>, розробленим в домашньому завданні 2 для 
 * даного уроку. Виведіть на екран значення елементів масиву, який повернув розширює метод GetArray (). 
 */


namespace MyListExtended
{
    internal static class Program
    {
        internal static void ShowArray<T>(T[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < (array.Length - 1))
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
            ShowArray(charList.GetArray());

            MyList<string> stringList = new MyList<string>();
            stringList.Add("first");
            stringList.Add("second");
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
