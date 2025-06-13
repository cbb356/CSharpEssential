namespace Inheritance_polymorphism
{
    internal class Printer
    {
        public virtual void Print(string value)
        { 
            Console.WriteLine(value);
        }
    }

    internal class BluePrinter : Printer 
    {
        public override void Print(string value)
        { 
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
            Console.ResetColor();
        }
    }

    internal class GreenPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
            Console.ResetColor();
        }
    }

    internal class YellowPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Print(value);
            Console.ResetColor();
        }
    }
}
