using BattleshipsLibrary.Models;
using ConsoleRequestDataLibrary;

namespace BattleshipsUI;

public class PlayersManager
{
    public List<PlayerModel> players => _players;

    readonly List<PlayerModel> _players;
    readonly int _mapWidth;
    readonly int _mapHeight;
    readonly int _shipsCount;

    public PlayersManager(int mapWidth, int mapHeight, int shipsCount)
    {
        _players = new List<PlayerModel>();
        _mapWidth = mapWidth;
        _mapHeight = mapHeight;
        _shipsCount = shipsCount;
    }

    public void CreatePlayer()
    {
        var player = new PlayerModel(RequestData.RequestString("Player name:"), _mapWidth, _mapHeight);

        Console.WriteLine($"{player.name}, fill ships:");

        for (int i = 1; i <= _shipsCount; i++)
        {
            Console.WriteLine($"{player.name} map:");
            MapVisualiser.ShowMap(player.map, false);

            bool wasShipPlaced = false;

            do
            {
                int horizontalPosition = RequestData.RequestInt($"Ship {i}: type in ship's horizontal position from 0 to {_mapWidth - 1}", 0, _mapWidth - 1);
                int verticalPosition = RequestData.RequestInt($"Ship {i}: type in ship's vertical position from 0 to {_mapHeight - 1}", 0, _mapHeight - 1);

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

        _players.Add(player);
    }

    public void AttackPlayer(int attackingPlayerIndex, int defendingPlayerIndex)
    {
        PlayerModel attackingPlayer = _players[attackingPlayerIndex];
        PlayerModel defendingPlayer = _players[defendingPlayerIndex];

        Console.WriteLine($"{attackingPlayer.name} attacks {defendingPlayer.name}");

        bool attackFinished = false;

        do
        {
            Console.WriteLine($"{defendingPlayer.name} map:");
            MapVisualiser.ShowMap(defendingPlayer.map, true);

            Console.WriteLine($"{attackingPlayer.name} choose cell coordinates to attack:");
            int horizontalPosition = RequestData.RequestInt($"Type in cell's horizontal position from 0 to {_mapWidth - 1}", 0, _mapWidth - 1);
            int verticalPosition = RequestData.RequestInt($"Type in cell's vertical position from 0 to {_mapHeight - 1}", 0, _mapHeight - 1);

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
}