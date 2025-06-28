namespace Article
{
    /*
    * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    * Потрібно: Створити клас Article, що містить наступні закриті поля: Назва товару;
    * назва магазину, в якому продається товар; вартість товару в гривнях. 
    * Створити клас Store, який містить закритий масив елементів типу Article.
    * Забезпечити такі можливості: висновок інформації про товар за номером за допомогою індексу;
    * висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, 
    * видати відповідне повідомлення.
    * Написати програму, виведення на екран інформацію про товар. 
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine(store[3]);
            Console.WriteLine(store[5]);    //Error: Out of bound

            Console.WriteLine("Enter the name of the goods article:");
            string articleName = Console.ReadLine().Trim().ToLower();
            Console.WriteLine(store[articleName]);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
