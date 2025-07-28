namespace MatrixRainDouble
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
                y = -random.Next(10, 20);
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

            public void UpdateAndDraw()
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

        class Column
        {
            private Chain[] chains;

            public Column(int x, int consoleHeight)
            {
                // Створюємо два ланцюжки для цієї колонки
                chains = new Chain[2];
                chains[0] = new Chain(x, consoleHeight);
                chains[1] = new Chain(x, consoleHeight);
            }

            // Головний метод, який буде виконуватися в окремому потоці
            public void Animate()
            {
                while (true)
                {
                    // По черзі оновлюємо кожен ланцюжок всередині цієї колонки
                    chains[0].UpdateAndDraw();
                    chains[1].UpdateAndDraw();

                    // Одна загальна затримка на всю колонку
                    Thread.Sleep(random.Next(40, 100));
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Matrix Rain (Optimized)";
            Console.CursorVisible = false;
            int width = 80;
            int height = 30;
            Console.SetWindowSize(width, height);

            // Створюємо масив на 80 колонок
            Column[] columns = new Column[width];
            for (int i = 0; i < columns.Length; i++)
            {
                // Створюємо одну колонку, яка вже містить у собі два ланцюжки
                columns[i] = new Column(i, height);

                // Створюємо та запускаємо ОДИН потік на КОЖНУ КОЛОНКУ
                Thread thread = new Thread(columns[i].Animate);
                thread.IsBackground = true;
                thread.Start();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}