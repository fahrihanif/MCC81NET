namespace OOP;

public class Vehicle
{
    public string Engine { get; protected set; }
    public string Color { get; set; }
    public int maxSpeed;

    public Vehicle()
    {
        Console.WriteLine("Vehicle Constructor");
    }

    public Vehicle(string engine, string color)
    {
        Engine = engine;
        Color = color;
    }
    
    public virtual void Specification()
    {
        Console.WriteLine($"Engine: {Engine}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Max Speed: {maxSpeed}");
    }
}
