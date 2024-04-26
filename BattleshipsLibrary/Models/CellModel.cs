namespace BattleshipsLibrary.Models;

public class CellModel
{
    public bool isRevealed => _isRevealed;
    public bool hasShip => _hasShip;

    bool _isRevealed;
    bool _hasShip;

    public void Reveal()
    {
        _isRevealed = true;
    }

    public void PlaceShip()
    {
        _hasShip = true;
    }
}