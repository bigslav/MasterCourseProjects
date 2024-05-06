using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public class CarModel : InventoryItemModel, IPurchasable, IRentable
{
    public bool IsRented { get; set; }

    public CarModel(string uniqueName) : base(uniqueName)
    {
    }

    public void Purchase()
    {
        throw new NotImplementedException();
    }

    public bool Rent()
    {
        throw new NotImplementedException();
    }

    public bool Return()
    {
        throw new NotImplementedException();
    }
}
