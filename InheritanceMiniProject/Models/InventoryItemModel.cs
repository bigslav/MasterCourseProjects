using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public abstract class InventoryItemModel : IInventoryItem
{
    public string UniqueName { get; set; }

    protected InventoryItemModel(string uniqueName)
    {
        UniqueName = uniqueName;
    }
}
