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
            //Initial matrix
            MyMatrix matrix = new MyMatrix(5, 5);
            Console.WriteLine("Initial matrix");
            matrix.PrintMatrix();

            //Expanded matrix
            matrix.ChangeMatrix(6, 7);
            Console.WriteLine("\nExpanded matrix");
            matrix.PrintMatrix();

            //Contracted matrix
            matrix.ChangeMatrix(4, 3);
            Console.WriteLine("\nContracted matrix");
            matrix.PrintMatrix();

            // Delay.
            Console.ReadKey();
        }
    }
}
