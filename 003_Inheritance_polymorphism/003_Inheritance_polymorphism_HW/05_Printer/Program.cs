namespace Inheritance_polymorphism
{
    internal class Program
    {
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

            //Delay
            Console.ReadKey();
        }
    }
}
