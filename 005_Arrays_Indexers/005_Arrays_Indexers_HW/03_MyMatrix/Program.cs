namespace MyMatrix
{
    /*
     * Створити клас MyMatrix, який забезпечує надання матриці довільного розміру з можливістю 
     * зміни числа рядків і стовпців. Написати програму, яка виводить на екран матрицю і 
     * похідні від неї матриці різних порядків.
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            
            Console.WriteLine("Enter the number of rows:");
            while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
                Console.WriteLine("You entered wrong value for number of rows. Try again");

            Console.WriteLine("Enter the number of columns:");
            while (!int.TryParse(Console.ReadLine(), out columns) || columns <= 0)
                Console.WriteLine("You entered wrong value for number of columns. Try again");

            MyMatrix myMatrix = new MyMatrix(rows, columns);
            Random random = new Random();
            
            myMatrix.PrintMatrix();
            myMatrix.PrintSubMatrix(random.Next(1, rows), random.Next(1, columns));
            myMatrix.PrintSubMatrix(0, 0);
            myMatrix.PrintSubMatrix((rows + 1), (columns + 1));
            myMatrix.PrintMatrixRow(random.Next(0, rows));
            myMatrix.PrintMatrixRow(-1);
            myMatrix.PrintMatrixRow(rows);
            myMatrix.PrintMatrixColumn(random.Next(0, columns));
            myMatrix.PrintMatrixColumn(-1);
            myMatrix.PrintMatrixColumn(columns);

            // Delay.
            Console.ReadKey();
        }
    }
}
