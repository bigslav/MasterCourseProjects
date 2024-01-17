Person person = new Person("Billy", 24, true, "911");

Console.WriteLine($@"Name: {person.name}
Age: {person.age}
Is alive: {person.isAlive}
Phone number: {person.phoneNumber}");

public class Person
{
    public string name => _name;
    // age can't be less than zero and can't be very big, can use ushort for micro-optimization
    public ushort age => _age;
    public bool isAlive => _isAlive;
    public string phoneNumber => _phoneNumber;

    string _name;
    ushort _age;
    bool _isAlive;
    string _phoneNumber;

    public Person(string name, ushort age, bool isAlive, string phoneNumber)
    {
        _name = name;
        _age = age;
        _isAlive = isAlive;
        _phoneNumber = phoneNumber;
    }
}