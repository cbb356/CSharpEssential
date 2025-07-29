namespace MyList
{
    internal class MyList<T>
    {
        private T [] array;
        public int Count { get { return array.Length; } }

        public MyList()
        {
            array = [];
        }

        public void Add(T item)
        {
            int length = array.Length;
            T [] tempArray = new T[length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[length] = item;
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
