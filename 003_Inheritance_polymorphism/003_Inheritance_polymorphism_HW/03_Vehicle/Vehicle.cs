namespace Inheritance_polymorphism;

public class Vehicle
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Speed { get; set; }
    public decimal Price { get; set; }
    public int YearOfProduction { get; set; }
    
    public virtual void ShowInfo()
    {
        Console.WriteLine($"\nThe vehicle is a {this.GetType().Name}");
        Console.WriteLine($"The vehicle's latitude is {Latitude}");
        Console.WriteLine($"The vehicle's longitude is {Longitude}");
        Console.WriteLine($"The vehicle's speed is {Speed} kmp/h");
        Console.WriteLine($"The vehicle's price is {Price} USD");
        Console.WriteLine($"The year of production of the vehicle is {YearOfProduction}");
    }
}

public class Plane : Vehicle
{
    public int Passengers { get; set; }
    public double Altitude { get; set; }
    
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"The plane's capacity is {Passengers} passengers");
        Console.WriteLine($"The plane's max altitude is {Altitude} meters");
    }
}

public class Ship : Vehicle
{
    public int Passengers { get; set; }
    public string Port { get; set; }
    
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"The ship's capacity is {Passengers} passengers");
        Console.WriteLine($"The ship's port is {Port}");
    }
}

public class Car : Vehicle
{
    public string Color { get; set; }
    
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"The car's color is {Color}");
    }
}