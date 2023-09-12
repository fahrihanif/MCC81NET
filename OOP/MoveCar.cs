namespace OOP;

public class MoveCar : IMoveCar
{
    public void Accelerate()
    {
        Console.WriteLine("Gass ngeng......");
    }

    public void Brake()
    {
        Console.WriteLine("Brake stoppp......");
    }

    public void Brake2()
    {
        throw new NotImplementedException();
    }
}
