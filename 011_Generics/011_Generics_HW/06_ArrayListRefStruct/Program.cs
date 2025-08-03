/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * У колекцію ArrayList, через виклик методу Add додайте елементи структурного та посилального типу, 
 * переберіть цю колекцію за допомогою циклу for. З якою проблемою ви зіткнулися?
 */

using System.Collections;

namespace ArrayListRefStruct
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            
            // Adding array elements
            arrayList.Add(1);
            arrayList.Add(1.25);
            arrayList.Add("test");
            arrayList.Add(new Person("Alice", 25));

            // Showing array elements
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"The array element at index {i} has type '{arrayList[i].GetType().Name}' and value '{arrayList[i].ToString()}'");
            }
            Console.WriteLine();

            // Calculating sum of array elements
            int sum = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"The array element at index {i} has type '{arrayList[i].GetType().Name}' and value '{arrayList[i].ToString()}'");
                sum += (int)arrayList[i]; //Runtime InvalidCastException on non-integer element
            }
            Console.WriteLine($"The total sum of elements: {sum}");

            // Delay.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
