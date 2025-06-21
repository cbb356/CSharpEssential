namespace AbstractHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string documentType;
            AbstractHandler handler = null;

            while (true)
            {
                Console.WriteLine("\nInput the document type (XML, TXT, DOC) or \"quit\": ");
                documentType = Console.ReadLine().Trim().ToUpper();

                switch (documentType)
                {
                    case "XML":
                        handler = new XMLHandler();
                        break;
                    case "TXT":
                        handler = new TXTHandler();
                        break;
                    case "DOC":
                        handler = new DOCHandler();
                        break;
                    case "QUIT":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Wrong input. Try again");
                        break;
                }
                if (handler != null)
                {
                    handler.Open();
                    handler.Create();
                    handler.Change();
                    handler.Save();
                    Console.WriteLine();
                    handler = null;
                }
                
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
