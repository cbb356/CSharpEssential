namespace Book
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Розширте приклад уроку 005_Book, створивши в класі Book, вкладений клас Notes, 
     * який дозволить зберігати замітки читача. 
     */

    internal class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }

        public class Notes
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            // Delay.
            Console.ReadKey();
        }
    }
}
