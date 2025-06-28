using System;

namespace MyMatrix
{
    internal class MyMatrix
    {
        private Random random = new Random(); 
        private int[,] matrix;

        public MyMatrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }
        }

        public void PrintMatrix()
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine("The matrix with {0} rows and {1} columns:", rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ChangeMatrix(int newRows, int newColumns)
        { 
            int[,] newMatrix = new int[newRows, newColumns];

            int oldRows = matrix.GetLength(0);
            int oldColumns= matrix.GetLength(1);

            for (int i = 0; i < newRows; i++)
            {
                for (int j = 0; j < newColumns; j++)
                {
                    if (i < oldRows && j < oldColumns)
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                    else
                    {
                        newMatrix[i, j] = random.Next(0, 100);
                    }
                }
            }

            matrix = newMatrix;
        }
    }
}
