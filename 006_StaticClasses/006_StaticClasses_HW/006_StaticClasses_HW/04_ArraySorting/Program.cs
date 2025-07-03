namespace ArraySorting
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. 
     */
    internal static class ExtensionClass
    {
        public static void SortArray(this int[] array)
        {
            Array.Sort(array);
        }
    }


    internal class Program
    {
        static void ShowArray(string name, int[] array)
        {
            Console.Write(name);

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
            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            ShowArray("Initial array:", array);
            array.SortArray();
            ShowArray("Sorted array:", array);

            // Delay.
            Console.ReadKey();
        }
    }
}
