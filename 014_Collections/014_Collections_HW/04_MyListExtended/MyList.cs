using System.Collections;

namespace MyListExtended
{
    internal class MyList<T> : IEnumerable<T>
    {
        private T[] _array;
        private int _size;
        public int Count { get { return _size; } }

        public MyList()
        {
            _array = Array.Empty<T>();
            _size = 0;
        }

        public MyList(params T[] values)
        {
            _array = values;
            _size = values.Length;
        }

        public void Add(T item)
        {
            if (_size == _array.Length)
            {
                IncreaseCapacity();
            }
            _array[_size] = item;
            _size++;
        }

        private void IncreaseCapacity()
        {
            // Define new capacity
            int newCapacity = _array.Length == 0 ? 4 : _array.Length * 2;
            // Change array capacity
            T[] tempArray = new T[newCapacity];
            for (int i = 0; i < _array.Length; i++)
            {
                tempArray[i] = _array[i];
            }
            _array = tempArray;
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _size)
                    return _array[index];
                else
                    return default;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
