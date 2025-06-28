namespace Array
{
    /*
    * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    * Потрібно: Створити масив розмірністю N елементів, заповнити його довільними цілими значеннями. 
    * Вивести найбільше значення масиву, найменше значення масиву, загальну суму елементів, 
    * середнє арифметичне всіх елементів, вивести всі непарні значення.
    */

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

        static int[] GetArrayOddNumbers(int[] array)
        {
            int oddCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            int[] result = new int[oddCount];
            int currentIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    result[currentIndex] = array[i];
                    currentIndex++;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            ShowArray("Elements of the array: ", array);
            Console.WriteLine($"The biggest value of the array: {array.Max()}");
            Console.WriteLine($"The biggest value of the array: {array.Min()}");
            Console.WriteLine($"The biggest value of the array: {array.Sum()}");
            Console.WriteLine($"The biggest value of the array: {array.Average()}");
            ShowArray("Odd values: ", GetArrayOddNumbers(array));

            // Delay.
            Console.ReadKey();
        }
    }
}
