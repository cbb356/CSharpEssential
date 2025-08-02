using System;

namespace CarCollection
{
    internal class CarCollection
    {
        private List<Car> cars = new List<Car>();

        public int Count
        {  
            get { return cars.Count; } 
        }

        public void Add (string name, int year)
        {
            cars.Add (new Car (name, year));
        }

        public Car this[int index]
        {
            get
            {
                if (index >= 0 && index < cars.Count)
                    return cars[index];
                else
                    return default;
            }
        }

        public void Clear()
        { 
            cars.Clear();
            Console.WriteLine("All cars have been deleted from the fleet");
        }

    }
}

