using System.Text;

namespace Dictionary
{
    /*
     * Розширте приклад 5 (російсько-англійський словник) ще і українським словником. 
     * Реалізуйте можливість пошуку не тільки за ключовими російським словами і словами на інших мовах.
     */
    
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["дім"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(dictionary["pencil"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }

}
