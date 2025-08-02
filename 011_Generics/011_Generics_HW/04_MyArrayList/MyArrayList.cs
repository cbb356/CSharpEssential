namespace MyArrayList
{
    internal class MyArrayList
    {
        private object[] array;
        private int size;
        public int Count { get { return size; } }

        public MyArrayList()
        {
            array = [];
            size = 0;
        }

        public void Add(object item)
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
            object[] tempArray = new object[newCapacity];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                    return array[index];
                else
                    return default;
            }
        }

    }
}
