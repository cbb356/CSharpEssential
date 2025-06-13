namespace Inheritance_polymorphism
{
    internal class Program
    {
        /* Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
         * Потрібно: Створити клас Printer. У тілі класу створіть метод void Print(string value), 
         * що виводить на екран значення аргументу. Реалізуйте можливість того, щоб у разі успадкування 
         * від даного класу інших класів, та виклику відповідного методу їх екземпляра, рядки, передані 
         * як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи. 
         */
        static void Main(string[] args)
        {
            Printer basePrinter = new Printer();
            basePrinter.Print("Printer as Printer");

            BluePrinter bluePrinter = new BluePrinter();
            bluePrinter.Print("BluePrinter as BluePrinter");

            GreenPrinter greenPrinter = new GreenPrinter();
            greenPrinter.Print("GreenPrinter as GreenPrinter");

            YellowPrinter yellowPrinter = new YellowPrinter();
            yellowPrinter.Print("YellowPrinter as YellowPrinter");

            basePrinter = bluePrinter;
            basePrinter.Print("BluePrinter as Printer");

            basePrinter = greenPrinter;
            basePrinter.Print("GreenPrinter as Printer");

            basePrinter = yellowPrinter;
            basePrinter.Print("YellowPrinter as Printer");
        }
    }
}
