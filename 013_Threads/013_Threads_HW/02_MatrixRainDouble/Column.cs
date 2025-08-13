using System;

namespace MatrixRainDouble
{
    internal class Column
    {
        private static Random random = new Random();
        private Chain[] chains;

        public Column(int x, int consoleHeight)
        {
            // Create two chains for this column
            chains = new Chain[2];
            chains[0] = new Chain(x, consoleHeight);
            chains[1] = new Chain(x, consoleHeight);
        }

        // Main method to be executed in a separate thread
        public void Animate()
        {
            while (true)
            {
                // Update each chain in this column in turn
                chains[0].UpdateAndDraw();
                chains[1].UpdateAndDraw();

                // One shared delay for the whole column
                Thread.Sleep(random.Next(40, 100));
            }
        }
    }
}
