using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Title
    {
        public string Value { get; set; } = "Title is not set";

        public void Show () 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Value);
            Console.ResetColor();
        }
    }
}
