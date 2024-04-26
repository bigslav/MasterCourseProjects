using BattleshipsLibrary.Models;
using BattleshipsUI;
using ConsoleRequestDataLibrary;

const int fieldWidth = 5;
const int fieldHeight = 5;
const int maxShipCount = 1;
const int playerCount = 2;

var players = new List<PlayerModel>();

for (int i = 0; i < playerCount; i++)
{
    players.Add(CreatePlayer());
}

int? lastAttackingPlayerIndex = null;
string winnerName = string.Empty;

do
{
    int attackingPlayerIndex = PlayerHelpers.ChooseRandomPlayerIndex(players, lastAttackingPlayerIndex);
    int defendingPlayerIndex = PlayerHelpers.ChooseRandomPlayerIndex(players, attackingPlayerIndex);

    AttackPlayer(players, attackingPlayerIndex, defendingPlayerIndex);

    lastAttackingPlayerIndex = attackingPlayerIndex;
    winnerName = PlayerHelpers.GetWinnerName(players);
} while (winnerName == string.Empty);

Console.WriteLine($"{winnerName} WON!");

PlayerModel CreatePlayer()
{
    var player = new PlayerModel(RequestData.RequestString("Player name"), fieldWidth, fieldHeight);

    Console.WriteLine($"{player.name}, fill ships:");

    for (int i = 1; i <= maxShipCount; i++)
    {
        Console.WriteLine($"{player.name} map:");
        MapVisualiser.ShowMap(player.map, false);

        bool wasShipPlaced = false;

        do
        {
            int horizontalPosition = RequestData.RequestInt($"Ship {i}: type in ship's horizontal position from 0 to {fieldWidth - 1}", 0, fieldWidth - 1);
            int verticalPosition = RequestData.RequestInt($"Ship {i}: type in ship's vertical position from 0 to {fieldHeight - 1}", 0, fieldHeight - 1);

            CellModel targetCell = player.map[horizontalPosition][verticalPosition];

            if (!targetCell.hasShip)
            {
                targetCell.PlaceShip();
                wasShipPlaced = true;
            }
            else
            {
                Console.WriteLine($"Ship spot [{horizontalPosition}, {verticalPosition}] is already taken!");
            }
        } while (!wasShipPlaced);
    }

    return player;
}

void AttackPlayer(List<PlayerModel> players, int attackingPlayerIndex, int defendingPlayerIndex)
{
    PlayerModel attackingPlayer = players[attackingPlayerIndex];
    PlayerModel defendingPlayer = players[defendingPlayerIndex];

    Console.WriteLine($"{attackingPlayer.name} attacks {defendingPlayer.name}");

    bool attackFinished = false;

    do
    {
        Console.WriteLine($"{defendingPlayer.name} map:");
        MapVisualiser.ShowMap(defendingPlayer.map, true);

        Console.WriteLine($"{attackingPlayer.name} choose cell coordinates to attack:");
        int horizontalPosition = RequestData.RequestInt($"Type in cell's horizontal position from 0 to {fieldWidth - 1}", 0, fieldWidth - 1);
        int verticalPosition = RequestData.RequestInt($"Type in cell's vertical position from 0 to {fieldHeight - 1}", 0, fieldHeight - 1);

        CellModel chosenCell = defendingPlayer.map[horizontalPosition][verticalPosition];

        if (chosenCell.isRevealed)
        {
            Console.WriteLine($"Cell [{horizontalPosition}, {verticalPosition}] was already hit");
        }
        else
        {
            chosenCell.Reveal();

            if (chosenCell.hasShip)
            {
                Console.WriteLine($"HIT on [{horizontalPosition}, {verticalPosition}]");
                if (!defendingPlayer.IsAlive())
                {
                    Console.WriteLine($"Player {defendingPlayerIndex} is DEAD");
                    players.Remove(defendingPlayer);
                    attackFinished = true;
                }
            }
            else
            {
                Console.WriteLine($"MISS on [{horizontalPosition}, {verticalPosition}]");
                attackFinished = true;
            }
        }
    } while (!attackFinished);
}