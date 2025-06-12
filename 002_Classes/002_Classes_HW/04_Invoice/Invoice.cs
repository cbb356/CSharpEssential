namespace Classes
{
    internal class Invoice
    {
        //Invoice credentials
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        //Goods quantity
        private string article;
        private int quantity;

        //VAT
        private const double VAT_RATE = 0.2;

        public Invoice(int account, string customer, string provider) 
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void SetGoodsDetails(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }

        public void CalculateTotalCost(double price)
        {
            double totalCost = quantity * price;

            Console.WriteLine($"Invoice #{account}");
            Console.WriteLine($"Customer: {customer}, Provider: {provider}");
            Console.WriteLine($"The total cost for {quantity} of {article}s is: ");
            Console.WriteLine($"{totalCost:F2} (excluding VAT)");
            Console.WriteLine($"{totalCost * (1 + VAT_RATE):F2} (including VAT)");
        }
    }
}
