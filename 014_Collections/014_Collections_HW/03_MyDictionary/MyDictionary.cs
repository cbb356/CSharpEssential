using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
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

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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

