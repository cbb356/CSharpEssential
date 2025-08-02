namespace CarCollection
{
    internal class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Car(string name, int year) 
        {
            Name = name;
            Year = year;
        }

        public override string ToString()
        {
            return $"Car of brand {Name}, year of manufacture {Year}";
        }
    }
}
