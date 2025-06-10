namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(15, "Customer Company", "Provider Company")
            {
                Article = "goods",
                Quantity = 18,
                PricePerItem = 113.45
            };

            invoice.TotalCost();
        }
    }
}
