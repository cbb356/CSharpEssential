namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(15, "Customer Company", "Provider Company");
            invoice1.SetGoodsDetails("umbrella", 120);
            invoice1.CalculateTotalCost(12.75, true);

            Console.WriteLine();

            Invoice invoice2 = new Invoice(16, "Customer Company", "Provider Company");
            invoice2.SetGoodsDetails("table", 175);
            invoice2.CalculateTotalCost(28.50, false);

            //Delay
            Console.ReadKey();
        }
    }
}
