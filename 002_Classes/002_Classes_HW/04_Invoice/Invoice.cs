namespace Classes
{
    internal class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public double PricePerItem { get; set; }
        public Invoice(int account, string customer, string provider) 
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void TotalCost()
        {
            double totalCost = Quantity * PricePerItem;
            double totalCostVAT = totalCost * 1.2;
            Console.WriteLine($"Invoice {account}");
            Console.WriteLine($"Customer: {customer}, Provider: {provider}");
            Console.WriteLine($"The total cost for {Quantity} of {Article} is: {totalCost:F2} ({totalCostVAT:F2} including VAT)");
        }
    }
}
