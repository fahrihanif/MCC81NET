namespace OOP;

public class Car : Vehicle
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int Gears { get; set; }

    public Car(string engine, string color, int gears) : base(engine, color)
    {
        Gears = gears;
        Console.WriteLine("Car Constructor");
    }

    public override void Specification()
    {
        Console.WriteLine("Car Specification");
        base.Specification();
        Console.WriteLine($"Wheels: {Wheels}");
        Console.WriteLine($"Doors: {Doors}");
        Console.WriteLine($"Gears: {Gears}");
    }
}
