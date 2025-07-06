using System.Text;

namespace Book
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext (string str) 
     * для пошуку по книзі з прикладу уроку 005_Book. 
     * При виклику цього методу, проводиться послідовний пошук рядка в книзі. 
     */

    internal class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
    }

    internal static class FindAndReplaceManager
    {
        static private Book book = new Book();

        public static void FindNext(string str)
        {
            book.FindNext(str);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("Text");
            
            // Delay.
            Console.ReadKey();
        }
    }
}
