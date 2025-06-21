namespace AbstractHandler
{
    /*
     * Створити клас AbstractHandler. У тілі класу створити методи void Open(), 
     * void Create(), void Change(), void Save(). Створити похідні класи 
     * XMLHandler, TXTHandler, DOCHandler від базового класу AbstractHandler. 
     * Написати програму, яка виконуватиме визначення документа і для кожного 
     * формату мають бути методи відкриття, створення, редагування, збереження певного формату документа.
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            string documentType;
            AbstractHandler handler = null;

            while (true)
            {
                Console.WriteLine("\nInput the document type (XML, TXT, DOC) or \"exit\": ");
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
                    case "EXIT":
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
