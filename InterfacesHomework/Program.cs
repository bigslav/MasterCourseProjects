using InterfacesHomework;

var runners = new List<IRun>
{
    new Animal(10),
    new Animal(3),
    new Person(5)
};

foreach (IRun runner in runners)
{
    runner.Run();
}