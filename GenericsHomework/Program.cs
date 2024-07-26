Helper<string>.PrintToString("123");
Helper<PlayerModel>.PrintToString(new PlayerModel());

var player = new PlayerModel{playerName = "Bill"};
var pet = new PetModel { petName = "Fluff" };

player.PrintCollaborationName(pet);

public static class Helper<T>
{
    public static void PrintToString(T item)
    {
        Console.WriteLine(item.ToString());
    }
}

public class PlayerModel
{
    public string playerName { get; set; }

    public void PrintCollaborationName<T>(T collaborator) where T: IHasName
    {
        Console.WriteLine($"{playerName} & {collaborator.GetName()}");
    }
}

public interface IHasName
{
    string GetName();
}

public class PetModel : IHasName
{
    public string petName { get; set; }

    public string GetName()
    {
        return petName;
    }
}

public class FriendModel : IHasName
{
    public string friendName { get; set; }

    public string GetName()
    {
        return friendName;
    }
}