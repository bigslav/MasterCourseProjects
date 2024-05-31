using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject.Models;

public abstract class InventoryItemModel : IInventoryItem
{
    public string Name { get; set; }

    protected InventoryItemModel(string uniqueName)
    {
        Name = uniqueName;
    }
}