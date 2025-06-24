namespace MyMatrix
{
    internal class MyMatrix
    {
        private int[,] matrix;

        public MyMatrix(int rows, int colons)
        {
            _matrix = new int[rows, colons];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }
        }

        public void PrintMatrix()
        {
            Console.WriteLine(""
        }
    }
}
