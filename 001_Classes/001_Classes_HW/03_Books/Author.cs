namespace Classes
{
    internal class Author
    {
        public string Value { get; set; } = "Author is not set";

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Value);
            Console.ResetColor();
        }
    }
}
