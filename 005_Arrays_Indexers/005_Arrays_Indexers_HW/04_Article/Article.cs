namespace Article
{
    internal class Article
    {
        private string _name;
        private string _shop;
        private decimal _price;

        public string Name
        { 
            get { return _name; } 
        }

        public Article (string name, string shop, decimal price)
        {
            _name = name;
            _shop = shop;
            _price = price;
        }

        public string ArticleInfo()
        {
            return $"The name of the article is: {_name}. It is sold in the \"{_shop}\". The price is {_price}";
        }
    }
}
