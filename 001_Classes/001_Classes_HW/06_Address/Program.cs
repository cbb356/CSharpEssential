namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "03142";
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Poliova str.";
            address.House = "15";
            address.Apartment = "86";
            Console.WriteLine($"The address is:\nIndex: {address.Index}\nCountry: {address.Country}\nCity: {address.City}\n" +
                $"Street: {address.Street}\nHouse:{address.House}\nApartment:{address.Apartment}");
        }
    }
}
