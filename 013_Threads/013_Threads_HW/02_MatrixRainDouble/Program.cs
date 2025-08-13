namespace MatrixRainDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Matrix Rain (Optimized)";
            Console.CursorVisible = false;
            int width = 80;
            int height = 30;
            Console.SetWindowSize(width, height);

            // Create an array for 80 columns
            Column[] columns = new Column[width];
            for (int i = 0; i < columns.Length; i++)
            {
                // Create one column that already contains two chains
                columns[i] = new Column(i, height);

                // Create and start one thread for each column
                Thread thread = new Thread(columns[i].Animate);
                thread.IsBackground = true;
                thread.Start();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}