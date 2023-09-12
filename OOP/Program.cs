namespace OOP;

public class Program
{
    private static void Main()
    {
        Vehicle boat = new Vehicle("Diesel", "White");
        //boat.engine = "Diesel";
        boat.maxSpeed = 100;
        
        
        Console.WriteLine("boat engine: " + boat.Engine);
        Console.WriteLine("//////////////////////////////");
        Console.WriteLine("//////////////////////////////");

        Car supra = new Car("Gasoline", "Red", 6);
        supra.maxSpeed = 200;
        supra.Wheels = 4;
        supra.Doors = 2;

        supra.Specification();

        //IMoveCar move = new IMoveCar();
        IMoveCar move = new MoveCar();
        move.Accelerate();
        
        IMoveCar move2 = new MoveCar();
    }
}