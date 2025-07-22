namespace ColorPrint

/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
 * Створіть статичний клас із методом void Print (string stroka, int color), 
 * який виводить на екран рядок заданим кольором. Використовуючи перелік, створіть набір кольорів, 
 * доступних користувачеві. Введення рядка та вибір кольору надайте користувачеві. 
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Text input
            string printText;
            while (true)
            {
                Console.Write("Input text for printing: ");
                printText = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(printText))
                {
                    Console.WriteLine("Try again");
                    continue;
                }
                break;
            }

            //Color input
            int textColor;
            Console.WriteLine("Enter the number for the text color from the list: ");
            //Show the list of colors
            foreach (var item in Enum.GetNames(typeof(PrintColor)))
            {
                Console.WriteLine($"{(int)Enum.Parse(typeof(PrintColor), item)} - {item}");
            }
            //Check if color from the list
            while (!int.TryParse(Console.ReadLine(), out textColor) || !Enum.IsDefined(typeof(PrintColor), textColor))
            {
                Console.WriteLine("You have entered wrong number");
                Console.Write("Enter the number for the text color from the list: ");
            }

            //Print text
            Console.WriteLine();
            Printer.Print(printText, textColor);

            //Delay
            Console.ReadKey();
        }
    }
}
