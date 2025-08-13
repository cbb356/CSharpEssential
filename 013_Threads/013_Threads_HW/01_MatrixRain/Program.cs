namespace MatrixRain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Matrix Rain";
            Console.CursorVisible = false;
            int width = 80;
            int height = 30;
            Console.SetWindowSize(width, height);

            // Create an array for 80 chains
            Chain[] chains = new Chain[width];
            for (int i = 0; i < chains.Length; i++)
            {
                chains[i] = new Chain(i, height);

                // For each chain, create and start a separate thread
                Thread thread = new Thread(chains[i].Animate);
                thread.IsBackground = true;
                thread.Start();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
