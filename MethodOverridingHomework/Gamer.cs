public class Gamer : Person
{
    public string FavoriteGame { get; set; }

    public Gamer(string firstName, string lastName, int age, string favoriteGame) : base(firstName, lastName, age)
    {
        FavoriteGame = favoriteGame;
    }

    public override string GetPersonInfo()
    {
        return base.GetPersonInfo() + $"\nFavorite Game: {FavoriteGame}";
    }
}