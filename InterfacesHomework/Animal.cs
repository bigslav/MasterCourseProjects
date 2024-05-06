namespace InterfacesHomework;

public class Animal : IRun
{
    public int Speed { get; set; }

    public Animal(int speed)
    {
        Speed = speed;
    }

    public virtual void Run()
    {
        Console.WriteLine($"An animal runs with speed {Speed}");
    }
}
