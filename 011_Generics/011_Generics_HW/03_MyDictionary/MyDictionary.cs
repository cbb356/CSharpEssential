namespace MyDictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        private List<Entry<TKey, TValue>> items;

        public MyDictionary() 
        {
            items = new List<Entry<TKey, TValue>>();
        }

        private readonly struct Entry<TKey, TValue>
        {
            public TKey Key { get; }
            public TValue Value { get; }

            public Entry(TKey key, TValue value)  
            {
                Key = key;
                Value = value;
            }
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

            items.Add(new Entry<TKey, TValue>(key, value));
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
                        items[i] = new Entry<TKey, TValue>(key, value);
                        return;
                    }
                }
                items.Add(new Entry<TKey, TValue>(key, value));
                return;
            }
        }
        public int Count
        {
            get { return items.Count; }
        }
    }
}
