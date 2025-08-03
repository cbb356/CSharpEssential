namespace MyDictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> items;

        public MyDictionary() 
        {
            items = new List<KeyValuePair<TKey, TValue>>();
        }

        public void Add(TKey key, TValue value)
        {
            
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Key.Equals(key))
                {
                    Console.WriteLine($"Error! An item with the same key has already been added. Key: {key}");
                    return;
                }
            }

            items.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Key.Equals(key))
                    {
                        return items[i].Value;
                    }
                }
                return default;
            }
            set
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Key.Equals(key))
                    {
                        items[i] = new KeyValuePair<TKey, TValue>(key, value);
                        return;
                    }
                }
                items.Add(new KeyValuePair<TKey, TValue>(key, value));
                return;
            }
        }
        public int Count
        {
            get { return items.Count; }
        }
    }
}
