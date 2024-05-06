namespace InterfacesHomework;

public class Person : Animal
{
    public Person(int speed) : base(speed)
    {
    }

    public override void Run()
    {
        base.Run();
        Console.WriteLine($"^^^ Animal is a Person");
    }
}
