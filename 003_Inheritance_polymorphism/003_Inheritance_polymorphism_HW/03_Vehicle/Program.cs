namespace Inheritance_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane()
            {
                Latitude = 43.4567,
                Longitude = 23.7643,
                Speed = 800,
                Price = 1000000,
                YearOfProduction = 2010,
                Altitude = 10000, 
                Passengers = 100
            };

            Ship ship = new Ship()
            {
                Latitude = 42.4767,
                Longitude = 27.5003,
                Speed = 80,
                Price = 300000,
                YearOfProduction = 2005,
                Passengers = 20,
                Port = "Burgas"
            };

            Car car = new Car()
            {
                Latitude = 50.4067,
                Longitude = 30.6098,
                Speed = 200,
                Price = 15000,
                YearOfProduction = 2016,
                Color = "Red"
            };
            
            Vehicle[] vehicles = new Vehicle[] { plane, ship, car };
            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i].ShowInfo();
            }

            //Delay
            Console.ReadKey();
        }
    }
}
