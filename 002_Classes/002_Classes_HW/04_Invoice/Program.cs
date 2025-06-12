namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(15, "Customer Company", "Provider Company");
            invoice1.SetGoodsDetails("umbrella", 120);
            invoice1.CalculateTotalCost(12.75);

            //Delay
            Console.ReadKey();
        }
    }
}
