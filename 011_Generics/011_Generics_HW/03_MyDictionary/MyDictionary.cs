namespace MyDictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        private List<Entry<TKey, TValue>> myDictionary = new List<Entry<TKey, TValue>>();

        private struct Entry<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }

            public Entry<TKey, TValue>(TKey key, TValue value)  
            {
                Key = key;
                Value = value;
            }
        }

        public int Count
        {
            get { return myDictionary.Count; }
        }

        public void Add(TKey key, TValue value)
        {
            myDictionary.Add(new Entry<TKey, TValue>(key, value));
        }

        public Entry<TKey, TValue> this[int index]
        {
            get
            {
                if (index >= 0 && index < myDictionary.Count)
                    return myDictionary[index];
                else
                    return default;
            }
        }
    }
}
