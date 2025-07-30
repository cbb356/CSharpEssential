namespace MyList
{
    internal class MyList<T>
    {
        private T [] array;
        private int size;
        public int Count { get { return size; } }

        public MyList()
        {
            array = [];
            size = 0;
        }

        public void Add(T item)
        {
            if (size == array.Length)
            {
                IncreaseCapacity();
            }
            array[size] = item;
            size++;
        }

        private void IncreaseCapacity()
        {
            // Define new capacity
            int newCapacity = array.Length == 0 ? 4 : array.Length * 2;
            // Change array capacity
            T[] tempArray = new T[newCapacity];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return default;
            }
        }

    }
}
