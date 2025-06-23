namespace Article
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine(store[3]);
            Console.WriteLine(store[5]);

            Console.WriteLine("Enter the name of the goods article:");
            string articleName = Console.ReadLine().Trim().ToLower();
            Console.WriteLine(store[articleName]);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
