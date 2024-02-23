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

    CellState _cellState;

    public CellModel(bool hasShip)
    {
        _cellState = hasShip ? CellState.ShipHealthy : CellState.Empty;
    }

    public void SetState(CellState cellState)
    {
        _cellState = cellState;
    }
}
