using System;

namespace MyMatrix
{
    internal class MyMatrix
    {
        private Random random = new Random(); 
        private int[,] matrix;

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }
        public int Columns
        {
            get { return matrix.GetLength(1); }
        }


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
            Console.WriteLine("The matrix with {0} rows and {1} columns:", Rows, Columns);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ChangeMatrix(int newRows, int newColumns)
        { 
            int[,] newMatrix = new int[newRows, newColumns];

            int oldRows = Rows;
            int oldColumns= Columns;

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
