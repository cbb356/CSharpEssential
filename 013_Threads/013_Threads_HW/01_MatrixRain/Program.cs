namespace MatrixRain
{
    class Program
    {
        // Об'єкт-замок для синхронізації доступу до консолі
        private static readonly object _consoleLock = new object();
        static Random random = new Random();
        static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+";

        class Chain
        {
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
                y = -random.Next(5, 11);
                length = random.Next(3, 11);
            }

            // Головний метод, який буде виконуватися в окремому потоці
            public void Animate()
            {
                while (true)
                {
                    UpdateAndDraw();
                    Thread.Sleep(random.Next(40, 100)); // Кожен потік має свою невелику затримку
                }
            }

            private void UpdateAndDraw()
            {
                // Блокуємо консоль на час малювання одного повного кроку ланцюжка
                lock (_consoleLock)
                {
                    // Стираємо хвіст
                    int tailY = y - length;
                    if (tailY >= 0 && tailY < consoleHeight)
                    {
                        Console.SetCursorPosition(x, tailY);
                        Console.Write(' ');
                    }

                    // Малюємо голову (білий)
                    if (y >= 0 && y < consoleHeight)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(x, y);
                        Console.Write(GetRandomChar());
                    }

                    // Малюємо другий символ (світло-зелений)
                    int secondY = y - 1;
                    if (secondY >= 0 && secondY < consoleHeight)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x, secondY);
                        Console.Write(GetRandomChar());
                    }

                    // Малюємо решту "тіла" (темно-зелені символи)
                    for (int i = 2; i < length; i++)
                    {
                        int bodyY = y - i;
                        if (bodyY >= 0 && bodyY < consoleHeight)
                        {
                            Console.SetCursorPosition(x, bodyY);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(GetRandomChar());
                        }
                    }
                }

                // Рухаємо ланцюжок вниз
                y++;

                if (y - length > consoleHeight)
                {
                    Reset();
                }
            }

            private char GetRandomChar() => chars[random.Next(chars.Length)];
        }

        static void Main(string[] args)
        {
            Console.Title = "Matrix Rain";
            Console.CursorVisible = false;
            int width = 80;
            int height = 30;
            Console.SetWindowSize(width, height);

            Chain[] chains = new Chain[width];
            for (int i = 0; i < chains.Length; i++)
            {
                chains[i] = new Chain(i, height);

                // Для кожного ланцюжка створюємо та запускаємо окремий потік
                Thread thread = new Thread(chains[i].Animate);
                thread.IsBackground = true;
                thread.Start();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
