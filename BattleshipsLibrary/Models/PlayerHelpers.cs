namespace BattleshipsLibrary.Models;

public static class PlayerHelpers
{
    public static int ChooseRandomPlayerIndex(List<PlayerModel> players, int? excludedPlayerIndex)
    {
        int chosenPlayerIndex;

        if (excludedPlayerIndex == null)
        {
            var rnd = new Random();
            chosenPlayerIndex = rnd.Next(0, players.Count);
        }
        else
        {
            do
            {
                var rnd = new Random();
                chosenPlayerIndex = rnd.Next(0, players.Count);
            } while (chosenPlayerIndex == excludedPlayerIndex);
        }

        return chosenPlayerIndex;
    }

    public static string TryGetWinnerName(List<PlayerModel> players)
    {
        return players.Count == 1 ? players.First().name : string.Empty;
    }
}