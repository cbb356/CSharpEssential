namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Show();

            Console.WriteLine();

            Book book2 = new Book("John Doe", "The Book", "Some text");
            book2.Show();

            Console.WriteLine();

            // Delay.
            Console.ReadKey();
        }
    }
}
