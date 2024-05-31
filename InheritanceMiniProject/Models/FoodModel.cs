using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public class FoodModel : InventoryItemModel, IPurchasable
{
    public bool IsPurchased { get; set; }

    public FoodModel(string uniqueName) : base(uniqueName)
    {
    }

    public void Purchase()
    {
        IsPurchased = true;
    }
}
