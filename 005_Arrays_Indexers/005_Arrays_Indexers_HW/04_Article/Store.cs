namespace Article
{
    internal class Store
    {
        private Article[] goods = new Article[5];

        public Store()
        {
            goods[0] = new Article("ball", "Sport", 11.25m);
            goods[1] = new Article("shoes", "Clothes", 84.75m);
            goods[2] = new Article("bag", "Travel", 45.50m);
            goods[3] = new Article("pencil", "Office", 1.15m);
            goods[4] = new Article("suit", "Clothes", 95.00m);
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < goods.Length)
                    return goods[index].ArticleInfo();
                else
                    return "Attempt to access an array out of bounds";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < goods.Length; i++)
                {
                    if (index == goods[i].Name)
                        return goods[i].ArticleInfo();
                }                
                return "The article is not found";
            }
        }
    }

}
