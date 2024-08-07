using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public class CarModel : InventoryItemModel, IPurchasable, IRentable
{
    public bool IsRented { get; set; }
    public bool IsPurchased { get; set; }

    public CarModel(string uniqueName) : base(uniqueName)
    {
    }

    public void Purchase()
    {
        IsPurchased = true;
    }

    public void Rent()
    {
        IsRented = true;
    }

    public void Return()
    {
        IsRented = false;
    }
}
