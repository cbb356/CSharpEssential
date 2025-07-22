namespace ColorPrint

{
    public enum PrintColor
    {
        Red,
        Green,
        Blue,
        Yellow
    }

    internal static class Printer
    {
        public static void Print(string stroka, int color)
        {
            PrintColor printColor = (PrintColor)color;
            if (Enum.TryParse(printColor.ToString(), out ConsoleColor consoleColor))
            {
                Console.ForegroundColor = consoleColor;
            }
            
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
