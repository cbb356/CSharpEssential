using System;

namespace MyMatrix
{
    internal class MyMatrix
    {
        private int[,] matrix;

        public int Rows => matrix.GetLength(0);
        public int Columns => matrix.GetLength(1);


        public MyMatrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }
        }

        public int this[int row, int column]
        {
            get
            {
                return matrix[row, column];
            }
            set
            {
                matrix[row, column] = value;
            }
        }

        public void PrintMatrix()
        {
            PrintSubMatrix(Rows, Columns);
        }

        public void PrintSubMatrix(int rows, int columns)
        {
            if ((rows <= 0 || rows > Rows) || (columns <= 0 || columns > Columns))
            {
                Console.WriteLine("\nWrong values for rows or/and columns");
                return;
            }

            Console.WriteLine("\nThe matrix with {0} rows and {1} columns:", rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void PrintMatrixRow(int row)
        {
            if (row >= Rows || row < 0)
            {
                Console.WriteLine("\nWrong value for the row");
                return;
            }

            Console.WriteLine("\nThe {0} row of the matrix:", row);
            for (int i = 0; i < Columns; i++)
            {
               Console.Write(matrix[row, i] + "\t");
            }
            Console.WriteLine();
        }

        public void PrintMatrixColumn(int column)
        {
            if (column >= Columns || column < 0)
            {
                Console.WriteLine("\nWrong value for the column");
                return;
            }

            Console.WriteLine("\nThe {0} column of the matrix:", column);
            for (int i = 0; i < Rows; i++)
            {
                Console.Write(matrix[i, column] + "\n");
            }
        }
    }
}
