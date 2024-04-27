using BattleshipsLibrary.Models;
using BattleshipsUI;

const int mapWidth = 5;
const int mapHeight = 5;
const int shipsCount = 1;
const int playersCount = 2;

var playersManager = new PlayersManager(mapWidth, mapHeight, shipsCount);

for (int i = 0; i < playersCount; i++)
{
    playersManager.CreatePlayer();
}

int? lastAttackingPlayerIndex = null;
string winnerName;

do
{
    int attackingPlayerIndex = PlayerHelpers.ChooseRandomPlayerIndex(playersManager.players, lastAttackingPlayerIndex);
    int defendingPlayerIndex = PlayerHelpers.ChooseRandomPlayerIndex(playersManager.players, attackingPlayerIndex);

    playersManager.AttackPlayer(attackingPlayerIndex, defendingPlayerIndex);

    lastAttackingPlayerIndex = attackingPlayerIndex;
    winnerName = PlayerHelpers.TryGetWinnerName(playersManager.players);
} while (winnerName == string.Empty);

Console.WriteLine($"{winnerName} WON!");