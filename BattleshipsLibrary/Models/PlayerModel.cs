namespace BattleshipsLibrary.Models;

public class PlayerModel
{
    public CellModel[][] map => _map;
    public string name => _name;

    readonly CellModel[][] _map;
    readonly string _name;

    public PlayerModel(string name, int mapWidth, int mapHeight)
    {
        _name = name;
        _map = new CellModel[mapWidth][];

        for (int x = 0; x < mapWidth; x++)
        {
            _map[x] = new CellModel[mapWidth];
        }

        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                _map[x][y] = new CellModel();
            }
        }
    }

    public bool IsAlive()
    {
        for (int x = 0; x < _map.Length; x++)
        {
            for (int y = 0; y < _map[x].Length; y++)
            {
                if (_map[x][y].hasShip && !_map[x][y].isRevealed)
                    return true;
            }
        }

        return false;
    }
}