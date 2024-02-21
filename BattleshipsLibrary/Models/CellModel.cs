using System.Numerics;

namespace BattleshipsLibrary.Models;

public enum CellState
{
    Empty,
    ShipHealthy,
    ShipHit
}

public class CellModel
{
    public CellState CellState => _cellState;
    public int VerticalPosition => _verticalPosition;
    public int HorizontalPosition => _horizontalPosition;

    readonly int _verticalPosition;
    readonly int _horizontalPosition;
    CellState _cellState;

    public CellModel(int verticalPosition, int horizontalPosition, bool hasShip)
    {
        _verticalPosition = verticalPosition;
        _horizontalPosition = horizontalPosition;
        _cellState = hasShip ? CellState.ShipHealthy : CellState.Empty;
    }

    public void SetState(CellState cellState)
    {
        _cellState = cellState;
    }
}
