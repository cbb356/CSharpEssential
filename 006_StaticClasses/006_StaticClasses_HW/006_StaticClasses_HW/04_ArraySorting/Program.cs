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
            for (int i = 0; i < array.Length; i++)
            {
                //Get Index of the element with minimal value
                int minValue = array[i];
                int minValueIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (minValue >= array[j])
                    {
                        minValue = array[j];
                        minValueIndex = j;
                    }
                }

                //Swap array elements 
                int temp = array[i];
                array[i] = array[minValueIndex];
                array[minValueIndex] = temp;
            }
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

            ShowArray("Initial array: ", array);
            array.SortArray();
            ShowArray("Sorted array: ", array);

            // Delay.
            Console.ReadKey();
        }
    }
}
