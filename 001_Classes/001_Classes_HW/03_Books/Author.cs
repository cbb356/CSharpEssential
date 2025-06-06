using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
