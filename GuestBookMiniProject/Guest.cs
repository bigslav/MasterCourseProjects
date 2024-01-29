namespace GuestBookMiniProject;

public class Guest
{
    public string name => _name;
    public int companionsCount => _companionsCount;

    string _name;
    int _companionsCount;

    public Guest(string name, int companionsCount)
    {
        _name = name;
        _companionsCount = companionsCount;
    }
}
