namespace MatrixRainDouble
{
    class Chain
    {
        // Lock-object for console access
        private static readonly object _consoleLock = new object();
        static Random random = new Random();
        static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+";

        private int x;
        private int length;
        private int y;
        private int consoleHeight;

        public Chain(int x, int consoleHeight)
        {
            this.x = x;
            this.consoleHeight = consoleHeight;
            Reset();
        }

        public void Reset()
        {
            y = -random.Next(5, consoleHeight * 2);
            length = random.Next(3, consoleHeight / 2);
        }

        // Main method that will run in a separate thread
        public void Animate()
        {
            while (true)
            {
                UpdateAndDraw();
                Thread.Sleep(random.Next(40, 100)); // Each thread has its own small delay
            }
        }

        public void UpdateAndDraw()
        {
            // Lock the console while drawing one full step of the chain
            lock (_consoleLock)
            {
                // Erase the tail
                int tailY = y - length;
                if (tailY >= 0 && tailY < consoleHeight)
                {
                    Console.SetCursorPosition(x, tailY);
                    Console.Write(' ');
                }

                // Draw the head (white)
                if (y >= 0 && y < consoleHeight)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    Console.Write(GetRandomChar());
                }

                // Draw the second character (light green)
                int secondY = y - 1;
                if (secondY >= 0 && secondY < consoleHeight)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(x, secondY);
                    Console.Write(GetRandomChar());
                }

                // Draw the rest of the "body" (dark green characters)
                for (int i = 2; i < length; i++)
                {
                    int bodyY = y - i;
                    if (bodyY >= 0 && bodyY < consoleHeight)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(x, bodyY);
                        Console.Write(GetRandomChar());
                    }
                }
            }

            // Move the chain down
            y++;

            if (y - length > consoleHeight)
            {
                Reset();
            }
        }

        private char GetRandomChar() => chars[random.Next(chars.Length)];
    }
}
