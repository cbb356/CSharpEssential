namespace Inheritance_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker doc;
            
            Console.WriteLine("Enter the product key");
            string productKey = Console.ReadLine();

            switch(productKey.ToLower())
            {
                case "pro":
                    doc = new ProDocumentWorker();
                    break;
                case "exp":
                    doc = new ExpertDocumentWorker();
                    break;
                default:
                    doc = new DocumentWorker();
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            //Delay
            Console.ReadKey();
        }
    }
}
