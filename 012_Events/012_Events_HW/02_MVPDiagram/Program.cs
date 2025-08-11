namespace MVPDiagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            Model model = new Model();
            Presenter presenter = new Presenter(view, model);

            view.TriggerAction();

            // Delay.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
