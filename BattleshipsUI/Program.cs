using BattleshipsLibrary.Models;
using ConsoleRequestDataLibrary;

const int fieldSize = 5;
const int maxShipCount = 5;

CellModel[,] playerMap = new CellModel[fieldSize,fieldSize];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < fieldSize; j++)
    {
        playerMap[i, j] = new CellModel(false);
    }
}

Console.WriteLine("Fill ships:");
for (int i = 1; i <= maxShipCount; i++)
{
    bool canPlaceShip = false;

    do
    {
        int horizontalPosition = RequestData.RequestInt($"Ship {i}: type in ship's horizontal position from 1 to {fieldSize}", IntType.PositiveOnly);
        int verticalPosition = RequestData.RequestInt($"Ship {i}: type in ship's vertical position from 1 to {fieldSize}", IntType.PositiveOnly);

        if (playerMap[horizontalPosition, verticalPosition].CellState == CellState.Empty)
        {
            playerMap[horizontalPosition, verticalPosition].SetState(CellState.ShipHealthy);
            canPlaceShip = true;
        }
        else
        {
            Console.WriteLine("Ship spot is already taken!");
        }
    } while (!canPlaceShip);
}
