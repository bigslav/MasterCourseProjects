using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public class StadiumModel : InventoryItemModel, IRentable
{
    public bool IsRented { get; set; }

    public StadiumModel(string uniqueName) : base(uniqueName)
    {
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
