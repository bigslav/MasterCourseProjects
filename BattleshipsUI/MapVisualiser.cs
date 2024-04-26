using BattleshipsLibrary.Models;

namespace BattleshipsUI;

public static class MapVisualiser
{
    public static void ShowMap(CellModel[][] map, bool needHide)
    {
        Console.Write(" ");
        for (int y = 0; y < map[0].Length; y++)
        {
            Console.Write(y);
        }

        Console.WriteLine();

        for (int x = 0; x < map.Length; x++)
        {
            Console.Write(x);
            for (int y = 0; y < map.Length; y++)
            {
                CellModel cell = map[x][y];

                if (!needHide)
                {
                    Console.Write(cell.hasShip ? "o" : "=");
                }
                else
                {
                    if (!cell.isRevealed)
                    {
                        Console.Write("?");
                    }
                    else
                    {
                        Console.Write(cell.hasShip ? "x" : "=");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}