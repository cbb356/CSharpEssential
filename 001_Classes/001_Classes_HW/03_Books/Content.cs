namespace Classes
{
    internal class Content
    {
        public string Value { get; set; } = "Content is not set";

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Value);
            Console.ResetColor();
        }
    }
}
